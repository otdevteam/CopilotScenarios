namespace TestCopilot.Common
{
    public class StringHelper
    {
        public static string RemoveLastCharacter(string str)
        {
            return str.Remove(str.Length - 1);
        }

        // a method to sanitize a string for use in a URL
        public static string SanitizeForUrl(string str)
        {
            // remove all non-alphanumeric characters
            str = System.Text.RegularExpressions.Regex.Replace(str, @"[^a-zA-Z0-9\s]", "");

            // replace all whitespace with a single dash
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", "-");

            // replace multiple dashes with a single dash
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\-+", "-");

            // remove all leading and trailing dashes
            str = str.Trim('-');

            return str.ToLower();
        }
        public static string SanitizeString(string str)
        {
            // remove any invalid characters
            str = str.Replace(" ", "-").ToLower();

            // trim dashes from beginning and end of string (if any)
            str = str.Trim('-');

            // replace double occurences of - or _ with a single occurence
            str = str.Replace("--", "-").Replace("__", "_");

            return str;
        }

        public static string SanitizeString(string str, bool allowSpaces)
        {
            // remove any invalid characters
            str = str.Replace(" ", "-").ToLower();

            // trim dashes from beginning and end of string (if any)
            str = str.Trim('-');

            // replace double occurences of - or _ with a single occurence
            str = str.Replace("--", "-").Replace("__", "_");

            return str;
        }

    }
}
