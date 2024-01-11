using AOMSecurityPrice.API.Dto;
using AOMSecurityPrice.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AOMSecurityPrice.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecurityPriceController : ControllerBase
    {
        private readonly ILogger<SecurityPriceController> _logger;
        private readonly ISecurityPriceService _securityPriceService;

        public SecurityPriceController(ILogger<SecurityPriceController> logger, ISecurityPriceService securityPriceService) 
        {
            _logger = logger;
            _securityPriceService = securityPriceService;
        }

        [HttpGet(Name = "GetSecurityPriceAsync")]
        public async Task<SecurityPriceDto> GetSecurityPriceAsync(string isin)
        {
            var result = await _securityPriceService.GetSecurityPriceList(isin);

            var _securityPriceDto = new SecurityPriceDto() { ISIN = result.ISIN, Price = result.Price };

            return _securityPriceDto;
        }


    }
}