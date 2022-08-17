using System.Collections.Generic;

namespace ArchNet.Extension.Dictionnary
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [DICTIONNARY] Dictionnary Extension
    /// author : Louis PAKEL
    /// </summary>
    public static class DictionaryExtension
    {
        /// <summary>
        /// Simple method to strip empty values in a dictionnary
        /// </summary>
        /// <param name="dictionnary"></param>
        /// <returns></returns>
        public static Dictionary<string, string> StripEmptyValues(this Dictionary<string, string> dictionnary)
        {
            Dictionary<string, string> cleanDictionary = new Dictionary<string, string>();
            foreach (string key in dictionnary.Keys)
            {
                dictionnary.TryGetValue(key, out string value);
                if (value != "")
                {
                    cleanDictionary.Add(key, value);
                }
            }
            return cleanDictionary;
        }
    }


}