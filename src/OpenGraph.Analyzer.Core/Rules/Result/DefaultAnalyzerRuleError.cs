namespace OpenGraph.Analyzer.Core.Rules.Result
{
    public class DefaultAnalyzerRuleError : IAnalyzerRuleError
    {
        public DefaultAnalyzerRuleError(string key, string error)
        {
            
        }
        
        public string Key { get; set; }
        
        public string Error { get; set; }
    }
}