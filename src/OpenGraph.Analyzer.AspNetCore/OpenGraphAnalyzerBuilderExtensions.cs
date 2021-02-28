using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Rules.Registry;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;
using OpenGraph.Analyzer.Parser.NameSpaces;

namespace OpenGraph.Analyzer.AspNetCore
{
    public static class OpenGraphAnalyzerBuilderExtensions
    {
        public static OpenGraphAnalyzerBuilder AddRulesRegistry<TRegistry>(this OpenGraphAnalyzerBuilder builder)
            where TRegistry : IRulesRegistry<IOpenGraphMetaData, IAnalyzerRuleResult>
        {
            return builder;
        }
        
        public static OpenGraphAnalyzerBuilder AddErrorDescriber<TErrorDescriber>(this OpenGraphAnalyzerBuilder builder)
            where TErrorDescriber : IErrorDescriber
        {
            return builder;
        }
        
        public static OpenGraphAnalyzerBuilder AddNameSpaceRegistry<TStore>(this OpenGraphAnalyzerBuilder builder)
            where TStore : INameSpaceStore
        {
            return builder;
        }
        
        public static OpenGraphAnalyzerBuilder AddOpenGraphParser<TOpenGraphParser>(this OpenGraphAnalyzerBuilder builder)
            where TOpenGraphParser : IOpenGraphParser
        {
            return builder;
        }
    }
}