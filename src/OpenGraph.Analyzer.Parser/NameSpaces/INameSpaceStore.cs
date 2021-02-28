using System.Collections.Generic;

namespace OpenGraph.Analyzer.Parser.NameSpaces
{
    public interface INameSpaceStore
    {
        List<OpenGraphNameSpace> GetAll();
        
        OpenGraphNameSpace Get(string prefix);
        
        void Add(OpenGraphNameSpace ns);

        void Remove(string prefix);
    }
}