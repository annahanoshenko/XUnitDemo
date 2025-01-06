using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XUnitDemoProj
{
    internal class XUnitTestExample
    {
        public class UnitTest1 : IDisposable
        {
            IWebDriver driver;

            public UnitTest1()
            {
                driver = new ChromeDriver(@"D:\itvdn\Drivers\");
            }

            public void Dispose()
            {
                driver.Close();
            }

            [Fact]
            public void Test1()
            {
                driver.Url = "https://www.google.com/";
                Assert.Contains("Google", driver.Title);
            }
        }

        public class UnitTest2 : IDisposable
        {
            IWebDriver driver;

            public UnitTest2()
            {
                driver = new ChromeDriver(@"D:\itvdn\Drivers\");
            }

            public void Dispose()
            {
                driver.Close();
            }

            [Fact]
            public void Test2()
            {
                driver.Url = "https://www.google.com/";
                Assert.Contains("Google", driver.Title);
            }
        }
    }
}
