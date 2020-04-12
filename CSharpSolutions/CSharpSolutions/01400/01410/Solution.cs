namespace CSharpSolutions._01400._01410
{
    public class Solution
    {
        public string EntityParser(string text)
        {
            return System.Net.WebUtility.HtmlDecode(text).Replace("⁄", "/");
        }
    }
}
