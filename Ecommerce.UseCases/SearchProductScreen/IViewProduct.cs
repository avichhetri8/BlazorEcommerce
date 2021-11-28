using Ecommerce.CoreBusiness.Models;

namespace Ecommerce.UseCases.SearchProductScreen
{
    public interface IViewProduct
    {
        Product Execute(int? id);
    }
}