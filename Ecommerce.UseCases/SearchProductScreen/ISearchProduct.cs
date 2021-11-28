using Ecommerce.CoreBusiness.Models;
using System.Collections.Generic;

namespace Ecommerce.UseCases.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}