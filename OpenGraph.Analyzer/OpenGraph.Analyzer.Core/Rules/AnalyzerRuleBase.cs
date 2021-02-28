using System;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Rules
{
    public abstract class AnalyzerRuleBase : IAnalyzerRule<IOpenGraphMetaData, IAnalyzerRuleResult>
    {
        public virtual string Key => "BaseRule";
        
        public abstract IAnalyzerRuleResult Rule(IOpenGraphMetaData meta);
    }
}