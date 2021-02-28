using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Common
{
    public interface IErrorDescriber
    {
        string GetError(string key, params string[] args);
    }
}