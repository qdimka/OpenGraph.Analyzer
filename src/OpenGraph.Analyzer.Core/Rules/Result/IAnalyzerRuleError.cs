namespace OpenGraph.Analyzer.Core.Rules.Result
{
    public interface IAnalyzerRuleError
    {
        string Key { get; set; }

        string Error { get; set; }
    }
}