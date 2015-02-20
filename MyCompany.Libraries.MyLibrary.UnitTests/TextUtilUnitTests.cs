using Xunit;

namespace MyCompany.Libraries.MyLibrary.UnitTests
{

    [Trait("Type", "Unit")]
    public class TextUtilUnitTests
    {

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData("a", "a")]
        [InlineData("123abc", "cba321")]
        [InlineData("123 abc", "cba 321")]
        [InlineData("καφές", "ςέφακ")]
        [InlineData("これが", "がれこ")]
        public void ReverseText_IsExpected(string input, string expected)
        {
            var actual = TextUtil.ReverseText(input);
            Assert.Equal(expected, actual);
        }

    }

}
