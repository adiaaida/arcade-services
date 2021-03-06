using System.Threading.Tasks;
using Microsoft.DncEng.CommandLineLib;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.DncEng.SecretManager
{
    public class Program : DependencyInjectedConsoleApp
    {
        public static Task<int> Main(string[] args)
        {
            return new Program().RunAsync(args);
        }

        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<SecretTypeRegistry>();
            services.AddSingleton<StorageLocationTypeRegistry>();
        }
    }
}
