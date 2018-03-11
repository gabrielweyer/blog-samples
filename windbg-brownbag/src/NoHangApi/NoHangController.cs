using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace NoHangApi
{
    [Route("no-hang")]
    public class NoHangController : Controller
    {
        public IEnumerable<string> Get()
        {
            var result = GreatClass.DoSomethingAsync().GetAwaiter().GetResult();

            return new[] { result };
        }
    }
}
