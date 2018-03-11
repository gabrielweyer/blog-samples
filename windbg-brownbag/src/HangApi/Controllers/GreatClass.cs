using System.Threading.Tasks;

namespace HangApi.Controllers
{
    internal static class GreatClass
    {
        public static async Task<string> DoSomethingAsync()
        {
            await Task.Delay(3000);
            return "value1";
        }
    }
}