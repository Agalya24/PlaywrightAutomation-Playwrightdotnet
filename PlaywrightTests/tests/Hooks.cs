using Microsoft.Playwright.NUnit;

namespace PlaywrightTests.tests
{
    public class Hooks : PageTest
    {
        public static string _baseUrl;
        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            _baseUrl = TestContext.Parameters["baseUrl"]
                 ?? throw new Exception("BaseUrl is not configured as a parameter.");
        }
        [SetUp]
        public async Task SetUp()
        {
            await Page.GotoAsync(_baseUrl);
        }
        [TearDown]
        public async Task TearDown()
        {
           if (TestContext.CurrentContext.Result.Outcome.ToString() == "Failed")
           {
            await Page.ScreenshotAsync(new()
{
    Path = "../../../screenshots/" + TestContext.CurrentContext.Test.Name +"failed.png",
});
                    }
        }
    }
}