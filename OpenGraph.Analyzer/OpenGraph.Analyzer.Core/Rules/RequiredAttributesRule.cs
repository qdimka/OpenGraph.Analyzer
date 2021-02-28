using System.Linq;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Rules
{
    public class RequiredAttributesRule : AnalyzerRuleBase
    {
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
                .Select(x => (IAnalyzerRuleError)new DefaultAnalyzerRuleError(x, "Required"))
                .ToList();
            
            return errors.Any()
                ? DefaultAnalyzerRuleResult.Failed(errors) 
                : DefaultAnalyzerRuleResult.Succeeded();
        }
    }
}