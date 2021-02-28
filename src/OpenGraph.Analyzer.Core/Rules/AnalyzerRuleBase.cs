using System;
using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Rules
{
    public abstract class AnalyzerRuleBase : IAnalyzerRule<IOpenGraphMetaData, IAnalyzerRuleResult>
    {
        protected IErrorDescriber ErrorDescriber { get; }
        
        public virtual string Key => "BaseRule";

        protected AnalyzerRuleBase(IErrorDescriber errorDescriber)
        {
            ErrorDescriber = errorDescriber;
        }
        
        public abstract IAnalyzerRuleResult Rule(IOpenGraphMetaData meta);
    }
}