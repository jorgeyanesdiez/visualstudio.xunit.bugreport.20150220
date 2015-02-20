namespace MyCompany.Libraries.MyLibrary
{

    /// <summary>
    /// Utilities related to text manipulation.
    /// </summary>
    public static class TextUtil
    {

        /// <summary>
        /// Reverses the provided string.
        /// </summary>
        /// <param name="input">The string to reverse.</param>
        /// <returns>The requested result.</returns>
        public static string ReverseText(string input)
        {
            var result = input;
            if (input != null && input.Length > 1)
            {
                var chars = input.ToCharArray();
                for (int posStart = 0, posEnd = input.Length - 1; posStart < posEnd; posStart++, posEnd--)
                {
                    chars[posStart] ^= chars[posEnd];
                    chars[posEnd] ^= chars[posStart];
                    chars[posStart] ^= chars[posEnd];
                }
                result = new string(chars);
            }
            return result;
        }

    }

}
