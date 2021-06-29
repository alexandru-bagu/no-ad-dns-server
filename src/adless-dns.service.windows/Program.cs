using adless_dns.core;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace adless_dns.service.windows
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await EntryPoint.Main(args, hostBuilder => hostBuilder.UseWindowsService());
        }
    }
}
