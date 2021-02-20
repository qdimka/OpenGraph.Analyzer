namespace OpenGraph.Analyzer.Parser
{
    public interface IOpenGraphParser
    {
        IOpenGraphMetaData Parse(string html);
    }
}