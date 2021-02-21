namespace CodingChallanges
{
    public class StringHelper
    {
        public string Reverse(string text)
        {
            var reversed = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            return string.Join("", reversed);
        }
    }
}
