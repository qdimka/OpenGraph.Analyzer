namespace OpenGraph.Analyzer.Parser
{
    public interface INameSpaceStore
    {
        OpenGraphNameSpace Get(string prefix);

        void Set(OpenGraphNameSpace nameSpace);
    }
}