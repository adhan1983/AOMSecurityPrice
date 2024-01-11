using AOMSecurityPrice.API.Data;

namespace AOMSecurityPrice.API.Service.Interfaces
{
    public interface ISecurityPriceService
    {
        public Task<SecurityPriceData?> GetSecurityPriceList(string isin); 
    }
}
