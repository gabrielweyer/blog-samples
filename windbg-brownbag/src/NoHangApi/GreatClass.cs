using System.Threading.Tasks;

namespace NoHangApi
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