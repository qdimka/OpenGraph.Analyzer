using System.Collections.Generic;
using System.Linq;

namespace OpenGraph.Analyzer.Core.Rules.Result
{
    public class DefaultAnalyzerRuleResult : IAnalyzerRuleResult
    {
        protected DefaultAnalyzerRuleResult()
        {
            Errors = new List<IAnalyzerRuleError>();
        }
        
        public List<IAnalyzerRuleError> Errors { get; private set; }

        public bool Success => !Errors.Any();

        public static DefaultAnalyzerRuleResult Failed(List<IAnalyzerRuleError> errors)
        {
            return new DefaultAnalyzerRuleResult()
            {
                Errors = errors
            };
        }

        public static DefaultAnalyzerRuleResult Succeeded() 
            => new DefaultAnalyzerRuleResult();
    }
}