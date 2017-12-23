
using System;
using System.Collections.Generic;

namespace src.Webapi
{
    public class Parameters : Dictionary<string, object>
    {
        public Parameters() : base() { }

        public Parameters(string field, object value)
            : base()
        {
            this.Add(field, value);
        }

        /// <summary>
        /// Returns a URL/Formbody representation of the parameters
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> output = new List<string>();
            foreach (string key in this.Keys)
            {
                output.Add(String.Format("{0}={1}", UrlEncode(key), UrlEncode(this[key])));
            }
            return String.Join("&", output.ToArray());
        }

        /// <summary>
        /// Parses objects into URL escaped strings
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string UrlEncode(object obj)
        {
            string result = Uri.EscapeDataString(Parse(obj));

            // These characters are not escaped by EscapeDataString() 
            result = result
                .Replace("(", "%28")
                .Replace(")", "%29")
                .Replace("$", "%24")
                .Replace("!", "%21")
                .Replace("*", "%2A")
                .Replace("'", "%27");

            // Tilde gets escaped but is a reserved character and is thus allowed.
            // @see https://dev.twitter.com/oauth/overview/percent-encoding-parameters
            result = result.Replace("%7E", "~");
            return result;
        }

        public static string Parse(object obj)
        {
            string result = String.Empty;
            if (obj != null)
            {
                switch (obj.GetType().FullName)
                {
                    case "System.Boolean":
                        result = String.Format("{0}", obj).ToLower();
                        break;
                    case "System.DateTime":
                        result = String.Format("{0}", ((DateTime)obj).Ticks);
                        break;
                    default:
                        result = String.Format("{0}", obj);
                        break;
                }
            }
            return result;
        }
    }
}