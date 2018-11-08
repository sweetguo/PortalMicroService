using Microsoft.AspNetCore.Antiforgery;
using Institute.Portal.Controllers;

namespace Institute.Portal.Web.Host.Controllers
{
    public class AntiForgeryController : PortalControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
