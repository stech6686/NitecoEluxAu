using System.Web.Http;
using Elux.ApiIntergration;
namespace Niteco.EluxApiReflection.Controllers
{
    public class StockController : ApiController
    {
        public double GetStockAvailable(string emailAddress,string modelNumber,string ean)
        {
            return EluxApiIntHelper.GetStockAvailable(string emailAddress,string modelNumber,string ean);
        }
    }
}