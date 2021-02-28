using System.Collections.Generic;
using System.Linq;

namespace OpenGraph.Analyzer.Parser.NameSpaces
{
    public class DefaultNameSpaceStore : INameSpaceStore
    {
        private readonly Dictionary<string, OpenGraphNameSpace> _internalStore = 
            new Dictionary<string, OpenGraphNameSpace>
            {
                
            };

        public List<OpenGraphNameSpace> GetAll()
        {
            return _internalStore
                .Select(x => x.Value)
                .ToList();
        }

        public OpenGraphNameSpace Get(string prefix)
        {
            return _internalStore.ContainsKey(prefix)
                ? _internalStore[prefix]
                : null;
        }

        public void Add(OpenGraphNameSpace nameSpace)
        {
            if (_internalStore.ContainsKey(nameSpace.Prefix))
                _internalStore[nameSpace.Prefix] = nameSpace;
            else 
                _internalStore.Add(nameSpace.Prefix, nameSpace);
        }

        public void Remove(string prefix)
        {
            if (_internalStore.ContainsKey(prefix))
                _internalStore.Remove(prefix);
        }
    }
}