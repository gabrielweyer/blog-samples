using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [Route("[controller]")]
    public class FeedController : Controller
    {
        private static readonly List<int> MemoryHog = new List<int>();

        [HttpGet("me")]
        public void Me()
        {
            MemoryHog.AddRange(Enumerable.Range(1, 1_000_000));
        }
    }
}
