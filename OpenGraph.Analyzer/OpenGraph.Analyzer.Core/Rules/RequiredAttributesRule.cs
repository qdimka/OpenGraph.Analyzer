using System.Linq;
using OpenGraph.Analyzer.Core.Abstractions;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Rules
{
    public class RequiredAttributesRule : AnalyzerRuleBase<IOpenGraphMetaData>
    {
        public override bool Rule(IOpenGraphMetaData meta)
        {
            if (meta.NameSpace == null)
                return false;
            
            var requiredAttributes = meta
                .NameSpace
                .RequiredAttributes
                .Select(x => $"{meta.NameSpace.Prefix}:{x}")
                .ToArray();

            return requiredAttributes
                .All(x => meta.Meta.ContainsKey(x));
        }
    }
}