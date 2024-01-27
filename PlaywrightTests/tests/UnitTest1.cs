using PlaywrightTests.pageobjects;
using PlaywrightTests.pages;
using PlaywrightTests.tests;

namespace PlaywrightTests;
[Parallelizable(ParallelScope.Children)]
[TestFixture]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class Tests : Hooks
{

    [Test]
    public async Task Test1()
    {
        HomePage homePage = new(Page);
        var isExist = await homePage.IsHeadingExists();
        Assert.IsTrue(isExist);
    }
    [Test]
    public async Task Test2()
    {
        NavigationPage navigationPage = new(Page);
        await navigationPage.NavigateToInstallationPage();
        InstallationPage installationPage = new(Page);
        var isExist = await installationPage.IsExistsInstallationHeading();
        Assert.IsTrue(!isExist);
    }
}