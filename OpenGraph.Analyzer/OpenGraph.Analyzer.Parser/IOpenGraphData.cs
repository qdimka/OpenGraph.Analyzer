using System.Collections.Generic;

namespace OpenGraph.Analyzer.Parser
{
    public interface IOpenGraphMetaData
    {
        OpenGraphNameSpace NameSpace { get; }
        Dictionary<string, OpenGraphMeta> Meta { get; }
    }

    public class OpenGraphMetaData : IOpenGraphMetaData
    {
        public OpenGraphMetaData(OpenGraphNameSpace nameSpace, Dictionary<string, OpenGraphMeta> meta)
        {
            Meta = meta;
            NameSpace = nameSpace;
        }

        public OpenGraphNameSpace NameSpace { get; }
        
        public Dictionary<string, OpenGraphMeta> Meta { get; }
    }

    public class OpenGraphNameSpace
    {
        public string Url { get; }
    }

    public class OpenGraphMeta
    {
        public OpenGraphMeta(string property, string content)
        {
            Name = property;
            Value = content;

            NameSpace = property
                .Split(':')[0];
        }
        
        public string Name { get; }

        public string NameSpace { get; }

        public string Value { get; }
    }
}