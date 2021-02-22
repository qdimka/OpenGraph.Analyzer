using System.Collections.Generic;

namespace OpenGraph.Analyzer.Parser
{
    public interface IOpenGraphMetaData
    {
        OpenGraphNameSpace NameSpace { get; }
        Dictionary<string, OpenGraphMeta[]> Meta { get; }
    }

    public class OpenGraphMetaData : IOpenGraphMetaData
    {
        public OpenGraphMetaData(OpenGraphNameSpace nameSpace, Dictionary<string, OpenGraphMeta[]> meta)
        {
            Meta = meta;
            NameSpace = nameSpace;
        }

        public OpenGraphNameSpace NameSpace { get; }
        
        public Dictionary<string, OpenGraphMeta[]> Meta { get; }
    }

    public class OpenGraphNameSpace
    {
        public OpenGraphNameSpace(string prefix, string url, string[] required)
        {
            Prefix = prefix;
            Url = url;
            RequiredAttributes = required;
        }
        
        public string Prefix { get; }
        
        public string Url { get; }
        
        public string[] RequiredAttributes { get; set; }
    }

    public class OpenGraphMeta
    {
        public OpenGraphMeta(string nameSpace, string property, string content)
        {
            Name = property;
            Value = content;
            NameSpace = nameSpace;
        }

        public string Name { get; }

        public string NameSpace { get; }

        public string Value { get; }
    }
}