using System.Threading.Tasks;
using OpenGraph.Analyzer.Core.Result;

namespace OpenGraph.Analyzer.Core.Services
{
    public interface IOpenGraphAnalyzer
    {
        IAnalyzerResult Analyze(string html);
    }
}