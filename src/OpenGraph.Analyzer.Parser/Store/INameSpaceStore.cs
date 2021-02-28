namespace OpenGraph.Analyzer.Parser.Store
{
    public interface INameSpaceStore
    {
        OpenGraphNameSpace Get(string prefix);

        void Set(OpenGraphNameSpace nameSpace);
    }
}