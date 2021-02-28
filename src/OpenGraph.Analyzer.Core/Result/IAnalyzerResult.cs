namespace OpenGraph.Analyzer.Core.Result
{
    public interface IAnalyzerResult
    {
        (string Rule, string Result)[] Rules { get; }
    }
}