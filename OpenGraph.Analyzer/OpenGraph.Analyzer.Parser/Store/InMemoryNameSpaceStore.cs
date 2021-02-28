using System.Collections.Generic;

namespace OpenGraph.Analyzer.Parser.Store
{
    public class InMemoryNameSpaceStore : INameSpaceStore
    {
        private readonly Dictionary<string, OpenGraphNameSpace> _internalStore = 
            new Dictionary<string, OpenGraphNameSpace>();
        
        public OpenGraphNameSpace Get(string prefix)
        {
            return _internalStore.ContainsKey(prefix)
                ? _internalStore[prefix]
                : null;
        }

        public void Set(OpenGraphNameSpace nameSpace)
        {
            if (_internalStore.ContainsKey(nameSpace.Prefix))
                _internalStore[nameSpace.Prefix] = nameSpace;
            else 
                _internalStore.Add(nameSpace.Prefix, nameSpace);
        }
    }
}