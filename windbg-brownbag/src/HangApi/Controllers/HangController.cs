using System.Collections.Generic;
using System.Web.Http;

namespace HangApi.Controllers
{
    public class HangController : ApiController
    {
        public IEnumerable<string> Get()
        {
            var result = GreatClass.DoSomethingAsync().GetAwaiter().GetResult();

            return new[] { result };
        }
    }
}
