namespace StringBuilderExtention
{
    using System;
    using System.Text;

    public static class Extentions
    {
        public static string Substring(this StringBuilder stringBuilderElement, int startIndex, int length)
        {
            var maxLength = stringBuilderElement.Length;
            Func<int, int, bool> outOfRange =
                (firstIndex, lengthOfArgument) =>
                    firstIndex > maxLength || (firstIndex + lengthOfArgument) > maxLength;

            if (outOfRange(startIndex, length))
            {
                throw new ArgumentOutOfRangeException();
            }

            var substringValue = stringBuilderElement.ToString().Substring(startIndex, length);

            return substringValue;
        }

        public static StringBuilder RemoveText(this StringBuilder stringBuilderElement, string text)
        {
            stringBuilderElement.Replace(text, string.Empty);

            return stringBuilderElement;
        }

        private static void Main()
        {
            var strBuilder = new StringBuilder("sdkfhsdjnkfsdnfjsdkfnsdjghsdngjsdgnsg");
            var substring = strBuilder.Substring(5, 7);
            Console.WriteLine(substring);

            var removeText = strBuilder.RemoveText("sdk");
            Console.WriteLine(removeText);
        }
    }
}
