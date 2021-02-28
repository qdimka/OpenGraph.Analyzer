using Microsoft.Extensions.DependencyInjection;

namespace OpenGraph.Analyzer.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        public static OpenGraphAnalyzerBuilder AddOpenGraphAnalyzer(this IServiceCollection services)
        {
            var builder = new OpenGraphAnalyzerBuilder(services);
            builder.AddDefaultServices();
            
            return builder;
        }
    }
}