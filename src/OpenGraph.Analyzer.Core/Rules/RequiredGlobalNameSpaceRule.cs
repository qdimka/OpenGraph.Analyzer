using System;
using System.Collections.Generic;
using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Rules
{
    public class RequiredGlobalNameSpaceRule : AnalyzerRuleBase
    {
        public override string Key => nameof(RequiredGlobalNameSpaceRule);

        public RequiredGlobalNameSpaceRule(IErrorDescriber errorDescriber) : base(errorDescriber)
        {
        }
        
        public override IAnalyzerRuleResult Rule(IOpenGraphMetaData meta)
        {
            return meta.NameSpace == null
                ? DefaultAnalyzerRuleResult.Failed(new List<IAnalyzerRuleError>()
                {
                    new DefaultAnalyzerRuleError(nameof(RequiredGlobalNameSpaceRule), "RequiredGlobalNameSpaceRule")
                })
                : DefaultAnalyzerRuleResult.Succeeded();
        }
    }
}