using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Playwright;
using PlaywrightTests.pageobjects;

namespace PlaywrightTests.pages
{
    public class NavigationPage
    {
        private readonly IPage _page;
        public NavigationPage(IPage page){
            _page = page;
        }
        public async Task NavigateToInstallationPage(){
            HomePage homePage = new(_page);
           await homePage.ClickGetStarted();
        }
    }
}