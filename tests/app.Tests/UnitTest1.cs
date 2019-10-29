using System;
using Xunit;
using app;

namespace app.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          var dummy = new Dummy();
          string hello = dummy.GetHello();
          Assert.Equal("hello", hello);
        }
    }
}
