using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace PlaywrightTests.pages
{
    public class InstallationPage
    {
        private readonly IPage _page;
        private readonly ILocator _heading;
        public InstallationPage(IPage page)
        {
            _page = page;
            _heading = _page.GetByText("Installation");
        }
        public async Task<bool> IsExistsInstallationHeading() => await _heading.First.IsVisibleAsync();
    }
}