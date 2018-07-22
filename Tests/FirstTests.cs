using System;
using Xunit;
using Xunit.Sdk;

namespace Tests
{
    public class FirstTests
    {
        [Fact]
        public void TestHelperExtensions1()
        {
            "s".ShouldEqual("s");
        }

        [Fact]
        public void TestHelperExtensions2()
        {
            Assert.Throws<EqualException>(() => "s".ShouldEqual("S"));
        }
    }
}
