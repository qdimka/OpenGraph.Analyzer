namespace OpenGraph.Analyzer.Core.Rules.Result
{
    public class DefaultAnalyzerRuleError : IAnalyzerRuleError
    {
        public DefaultAnalyzerRuleError(string attributeName, string key, string error)
        {
            AttributeName = attributeName;
            RuleKey = key;
            Error = error;
        }
        
        public string AttributeName { get; set; }
        
        public string RuleKey { get; set; }
        
        public string Error { get; set; }
    }
}