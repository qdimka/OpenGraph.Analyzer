using System.Linq;
using HtmlAgilityPack;

namespace OpenGraph.Analyzer.Parser
{
    public class OpenGraphParser : IOpenGraphParser
    {
        private const string PropertyAttribute = "property";
        private const string ContentAttribute = "content";

        public IOpenGraphMetaData Parse(string html)
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            
            var nodes = htmlDocument
                .DocumentNode
                .SelectNodes("//meta");

            var meta = nodes    
                .ToArray()
                .Where(x => x.Attributes.Contains(PropertyAttribute) &&
                               x.GetAttributeValue(PropertyAttribute, "").Contains(":"))
                .Select(x =>
                {
                    var propertyValue = x
                        .GetAttributeValue(PropertyAttribute, "");
                    var contentValue = x
                        .GetAttributeValue(ContentAttribute, "");
                    
                    var prefix = SplitValue(propertyValue);
                    
                    return new OpenGraphMeta(prefix.Prefix, propertyValue, contentValue);
                })
                .GroupBy(x => x.Name)
                .ToDictionary(x => x.Key, 
                    x => x.ToArray());

            return new OpenGraphMetaData(GetNameSpace(htmlDocument), meta);
        }

        private OpenGraphNameSpace GetNameSpace(HtmlDocument htmlDocument)
        {
            var headNode = htmlDocument
                .DocumentNode
                .SelectSingleNode("//head");

            if (!headNode.HasAttributes || headNode.Attributes.All(x => x.Name != "prefix"))
                return null;

            var prefix = SplitValue(headNode
                .GetAttributeValue("prefix", ""));

            return new OpenGraphNameSpace(prefix.Prefix, prefix.Value, new string[0]);
        }

        private (string Prefix, string Value) SplitValue(string attributeValue)
        {
            if (!attributeValue.Contains(":"))
                return (null, attributeValue);

            var splitted = attributeValue
                .Split(':');

            return (splitted[0], splitted[1]);
        }
    }
}