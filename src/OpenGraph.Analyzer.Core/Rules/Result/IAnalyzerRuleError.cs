namespace OpenGraph.Analyzer.Core.Rules.Result
{
    public interface IAnalyzerRuleError
    {
        string AttributeName { get; set; }
        
        string RuleKey { get; set; }

        string Error { get; set; }
    }
}