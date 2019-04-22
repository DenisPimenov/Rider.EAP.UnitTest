using AutoFixture.Xunit2;
using Xunit;

namespace Rider.EAP.UnitTest
{

    class Foo
    {
        public string Do(string a)
        {
            return a;
        }
    }
    
    public class Test
    {
        [Theory]
        [AutoData]
        public void TestAutoData(string a)
        {
            
            Assert.True(new Foo().Do(a).Length > 0);
        }
    }
}
