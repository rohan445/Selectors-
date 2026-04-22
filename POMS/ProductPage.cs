using Microsoft.Playwright;
using System.Threading.Tasks;

public class ProductsPage
{
    private readonly IPage _page;

    public ProductsPage(IPage page)
    {
        _page = page;
    }
    private ILocator OfferText => _page.Locator("div.offer-text");
    private ILocator ShopButton => _page.Locator("a.btn-primary");
    private ILocator MensWearLink => _page.Locator("a[href='mens-wear.php']");
    
    public async Task ClickShop()
    {
        await ShopButton.ClickAsync();
    }

    public async Task GoToMensWear()
    {
        await MensWearLink.ClickAsync();
    }

    public async Task<string> GetOfferText()
    {
        return await OfferText.InnerTextAsync();
    }
}