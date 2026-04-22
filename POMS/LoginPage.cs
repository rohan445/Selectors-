using Microsoft.Playwright; 
using System.Threading.Tasks;

public class LoginPage
{
    private readonly IPage _page;

    public LoginPage(IPage page)
    {
        _page = page;
    }

    private ILocator EmailInput => _page.Locator("input[type='email']");
    private ILocator PasswordInput => _page.Locator("#password");

    private ILocator LoginButton => _page.Locator("#loginBtn");

    private ILocator HomeBreadcrumb => _page.Locator("a.breadcrumb-item.text-dark");

    private ILocator NavbarIcon => _page.Locator("span.navbar-toggler-icon");

    private ILocator NavbarCollapse => _page.Locator("#navbarCollapse");

    private ILocator ScrollTopButton => _page.Locator("a.btn[href='#']"); 

    public async Task EnterEmail(string email)
    {
        await EmailInput.FillAsync(email);
    }

    public async Task EnterPassword(string password)
    {
        await PasswordInput.FillAsync(password);
    }

    public async Task ClickLogin()
    {
        await LoginButton.ClickAsync();
    }

    public async Task Login(string email, string password)
    {
        await EnterEmail(email);
        await EnterPassword(password);
        await ClickLogin();
    }

    public async Task ClickHome()
    {
        await HomeBreadcrumb.ClickAsync();
    }

    public async Task OpenNavbar()
    {
        await NavbarIcon.ClickAsync();
    }

    public async Task ScrollToTop()
    {
        await ScrollTopButton.ClickAsync();
    }
}