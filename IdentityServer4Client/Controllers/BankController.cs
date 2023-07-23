using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer4Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public string TranferAmount()
        {
            return "amount transferred";
        }
    }
}
