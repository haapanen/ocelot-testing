using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Haapanen.OcelotNetTesting.AuthorizationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{email}")]
        public List<string> AuthorizedItems(string email)
        {
            switch (email)
            {
                case "haapanen.jussi@gmail.com":
                    return new List<string>
                    {
                        "A",
                        "B"
                    };
                default:
                    return new List<string>{"A"};
            }
        }
    }
}
