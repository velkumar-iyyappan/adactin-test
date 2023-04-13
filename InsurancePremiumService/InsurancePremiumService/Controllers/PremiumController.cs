using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsurancePremiumService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiumController : ControllerBase
    {
        private readonly ILogger<PremiumController> _logger;
        private readonly IPremiumProcessor _premiumProcessor;

        public PremiumController(ILogger<PremiumController> logger, IPremiumProcessor premiumProcessor)
        {
            _logger = logger;
            _premiumProcessor = premiumProcessor;
        }

        [HttpGet(Name = "GetPremium")]
        public PremiumDetails Get(InsuredPersonDetails insuredPersonDetails)
        {
            var premiumDetails = _premiumProcessor.GetPremiumDetails(insuredPersonDetails);
            return premiumDetails;
        }
    }
}
