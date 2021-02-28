using System;

namespace OpenGraph.Analyzer.Parser.NameSpaces
{
    public static class Default
    {
        public static OpenGraphNameSpace[] OpenGraphNameSpaces => new[]
        {
            new OpenGraphNameSpace(String.Empty, String.Empty, null)
        };
    }
}
