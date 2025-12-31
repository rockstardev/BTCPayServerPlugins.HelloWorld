using BTCPayServer.Abstractions.Constants;
using BTCPayServer.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BTCPayServer.RockstarDev.Plugins.HelloWorld.Controllers;

[Authorize(Policy = Policies.CanViewInvoices, AuthenticationSchemes = AuthenticationSchemes.Cookie)]
public class HelloWorldController : Controller
{
    [HttpGet("~/plugins/{storeId}/helloworld/")]
    public IActionResult Index(string storeId)
    {
        return View();
    }
}
