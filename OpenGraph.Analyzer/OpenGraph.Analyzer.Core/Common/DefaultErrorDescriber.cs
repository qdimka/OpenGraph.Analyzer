using System;
using System.Collections.Generic;
using OpenGraph.Analyzer.Core.Rules;

namespace OpenGraph.Analyzer.Core.Common
{
    public class DefaultErrorDescriber : IErrorDescriber
    {
        private Dictionary<string, string> _errors = new Dictionary<string, string>()
        {
            {nameof(RequiredGlobalNameSpaceRule), ""},
            {nameof(RequiredAttributesRule), ""},
        };
        
        public string GetError(string key, params string[] args)
        {
            if (!_errors.ContainsKey(key))
                throw new InvalidOperationException();

            return string.Format(_errors[key], args);
        }
    }
}