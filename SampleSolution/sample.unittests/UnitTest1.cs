using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_run_hellow_world()
        {
            // arrange
            var sut = new Sample.SampleLibrary();
            
            // act
            var actual = sut.SayHelloWorld();

            // assert
            Assert.AreEqual("Hello World!", actual);
        }
    }
}
