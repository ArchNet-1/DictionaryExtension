// ArchNet · Dictionary Extension
// Extension methods for dictionaries: copy without the empty values.
// Docs: https://archnet-plateform.fr/#DictionaryExtension

using System.Collections.Generic;

namespace ArchNet.Extension
{
    public static class DictionaryExtension
    {
        /// <summary>New dictionary with only the entries whose value is not null or empty.</summary>
        public static Dictionary<TKey, string> WithoutEmptyValues<TKey>(this IDictionary<TKey, string> source)
        {
            var result = new Dictionary<TKey, string>();
            foreach (KeyValuePair<TKey, string> pair in source)
            {
                if (!string.IsNullOrEmpty(pair.Value)) result.Add(pair.Key, pair.Value);
            }
            return result;
        }
    }
}
