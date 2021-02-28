using Microsoft.Extensions.DependencyInjection;
using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Rules.Registry;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Core.Services;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.AspNetCore
{
    public class OpenGraphAnalyzerBuilder
    {
        private IServiceCollection _services;

        public OpenGraphAnalyzerBuilder(IServiceCollection services)
        {
            _services = services;
        }

        public void AddDefaultServices()
        {
            _services.AddScoped<IErrorDescriber, DefaultErrorDescriber>();
            _services.AddScoped<IRulesRegistry<IOpenGraphMetaData, IAnalyzerRuleResult>, DefaultRuleRegistry>();
            _services.AddScoped<IOpenGraphAnalyzer, OpenGraphAnalyzer>();
            _services.AddScoped<IOpenGraphParser, OpenGraphParser>();
        }
    }
}