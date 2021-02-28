using Microsoft.Extensions.DependencyInjection;
using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Rules.Registry;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Core.Services;
using OpenGraph.Analyzer.Parser;
using OpenGraph.Analyzer.Parser.NameSpaces;

namespace OpenGraph.Analyzer.AspNetCore
{
    public class OpenGraphAnalyzerBuilder
    {
        public readonly IServiceCollection Services;

        public OpenGraphAnalyzerBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public void AddDefaultServices()
        {
            Services.AddScoped<IErrorDescriber, DefaultErrorDescriber>();
            Services.AddScoped<INameSpaceStore, DefaultNameSpaceStore>();
            Services.AddScoped<IRulesRegistry<IOpenGraphMetaData, IAnalyzerRuleResult>, DefaultRuleRegistry>();
            Services.AddScoped<IOpenGraphAnalyzer, OpenGraphAnalyzer>();
            Services.AddScoped<IOpenGraphParser, OpenGraphParser>();
        }
    }
}