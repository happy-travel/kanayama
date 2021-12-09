using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HappyTravel.Kanayama
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _environment = environment;
            Configuration = configuration;
        }
        
        
        public IConfiguration Configuration { get; }
        private readonly IWebHostEnvironment _environment;
    }
}