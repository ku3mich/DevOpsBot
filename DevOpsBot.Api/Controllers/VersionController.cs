using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevOpsBot.Api.Controllers
{
    [ApiController]
    [Route("_[controller]")]
    public class VersionController : ControllerBase
    {
        private readonly ILogger<VersionController> _logger;

        public VersionController(ILogger<VersionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var assemblyName = typeof(VersionController).Assembly.GetName();
            var version = assemblyName.Version.ToString();
            _logger.LogInformation($"got the version: {version}");
            return version;
        }
    }
}
