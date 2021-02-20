using System.Threading.Tasks;

namespace OpenGraph.Analyzer.Core.Abstractions
{
    public interface IOpenGraphAnalyzer
    {
        Task<IAnalyzerResult> AnalyzeAsync(string html);
    }
}