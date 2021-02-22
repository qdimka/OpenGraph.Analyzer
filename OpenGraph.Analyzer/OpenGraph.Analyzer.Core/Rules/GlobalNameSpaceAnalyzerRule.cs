using System;
using OpenGraph.Analyzer.Core.Abstractions;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Rules
{
    public class GlobalNameSpaceAnalyzerRule : AnalyzerRuleBase<IOpenGraphMetaData>
    {
        public override bool Rule(IOpenGraphMetaData meta) 
            => meta.NameSpace != null;
    }
}