using Xunit;

namespace Tests
{
    public static class TestExtensions {
        public static void ShouldEqual<T>(this T actual, T expected)
        {
            Assert.Equal(expected, actual);
        }
    }
}
