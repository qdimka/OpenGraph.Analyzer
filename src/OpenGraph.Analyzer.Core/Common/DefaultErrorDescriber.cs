using System;
using System.Collections.Generic;
using OpenGraph.Analyzer.Core.Rules;

namespace OpenGraph.Analyzer.Core.Common
{
    public class DefaultErrorDescriber : IErrorDescriber
    {
        private readonly Dictionary<string, string> _errors = new Dictionary<string, string>()
        {
            {nameof(RequiredGlobalNameSpaceRule), "Global namespace is required"},
            {nameof(RequiredAttributesRule), "Attribute {0} is required for {1}"},
        };
        
        public string GetError(string key, params string[] args)
        {
            if (!_errors.ContainsKey(key))
                throw new InvalidOperationException();

            return string.Format(_errors[key], args);
        }
    }
}