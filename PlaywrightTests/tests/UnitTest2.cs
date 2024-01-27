using PlaywrightTests.pageobjects;
using PlaywrightTests.pages;

namespace PlaywrightTests.tests
{
    [Parallelizable(ParallelScope.Children)]
    [TestFixture]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public class UnitTest2 : Hooks
    {

        [Test]
        public async Task Test3()
        {
            HomePage homePage = new(Page);
            var isExist = await homePage.IsHeadingExists();
            Assert.IsTrue(isExist);
        }
        [Test]
        public async Task Test4()
        {
            NavigationPage navigationPage = new(Page);
            await navigationPage.NavigateToInstallationPage();
            InstallationPage installationPage = new(Page);
            var isExist = await installationPage.IsExistsInstallationHeading();
            Assert.IsTrue(isExist);
        }
    }
}