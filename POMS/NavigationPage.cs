using Microsoft.Playwright;
using System.Threading.Tasks;


public class NavigationPage
{
    private readonly IPage _page;

    public NavigationPage(IPage page)
    {
        _page = page;
    }

    private ILocator NavbarToggle => _page.Locator("span.navbar-toggler-icon");
    private ILocator NavbarMenu => _page.Locator("#navbarCollapse");
    private ILocator HomeBreadcrumb => _page.Locator("a.breadcrumb-item.text-dark");
    private ILocator ScrollTopButton => _page.Locator("a.btn[href='#']");

    public async Task OpenNavbar()
    {
        await NavbarToggle.ClickAsync();
    }

    public async Task GoHome()
    {
        await HomeBreadcrumb.ClickAsync();
    }

    public async Task ScrollToTop()
    {
        await ScrollTopButton.ClickAsync();
    }

    public async Task<bool> IsNavbarVisible()
    {
        return await NavbarMenu.IsVisibleAsync();
    }
}