using System;
using OpenGraph.Analyzer.Core.Abstractions;

namespace OpenGraph.Analyzer.Core.Rules
{
    public abstract class AnalyzerRuleBase<T> : IAnalyzerRule<T>
    {
        public abstract bool Rule(T meta);
    }
}