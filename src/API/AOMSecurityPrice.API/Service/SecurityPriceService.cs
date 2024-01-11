using AOMSecurityPrice.API.Data;
using AOMSecurityPrice.API.Service.Interfaces;

namespace AOMSecurityPrice.API.Service
{
    public class SecurityPriceService : ISecurityPriceService
    {
        private List<SecurityPriceData> _securityPrices = new List<SecurityPriceData>() 
        {
            new SecurityPriceData(){ ISIN = "123456789987", Price = 127 },
            new SecurityPriceData(){ ISIN = "123456789984", Price = 75 },
            new SecurityPriceData(){ ISIN = "123456789998", Price = 89 },
            new SecurityPriceData(){ ISIN = "3456789987", Price = 12 },
            new SecurityPriceData(){ ISIN = "123458979987", Price = 23 },
        };

        public Task<SecurityPriceData?> GetSecurityPriceList(string isin)
        {
            return Task.FromResult(_securityPrices.FirstOrDefault(x => x.ISIN ==  isin));
        }
        
    }
}
