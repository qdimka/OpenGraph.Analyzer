using System.Linq;
using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Rules
{
    public class RequiredAttributesRule : AnalyzerRuleBase
    {
        public override string Key => nameof(RequiredAttributesRule);

        public RequiredAttributesRule(IErrorDescriber errorDescriber) : base(errorDescriber)
        {
        }
        
        public override IAnalyzerRuleResult Rule(IOpenGraphMetaData meta)
        {
            if (meta.NameSpace == null)
                return DefaultAnalyzerRuleResult.Succeeded();
            
            var requiredAttributes = meta
                .NameSpace
                .RequiredAttributes
                .Select(x => $"{meta.NameSpace.Prefix}:{x}")
                .ToArray();

            var errors = requiredAttributes
                .Where(x => !meta.Meta.ContainsKey(x))
                .Select(x => 
                    (IAnalyzerRuleError)new DefaultAnalyzerRuleError(x, Key, ErrorDescriber.GetError(Key, x, meta.NameSpace.Prefix)))
                .ToList();
            
            return errors.Any()
                ? DefaultAnalyzerRuleResult.Failed(errors) 
                : DefaultAnalyzerRuleResult.Succeeded();
        }
    }
}