using Ecommerce.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.UseCases.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        Product GetProduct(int? id);
        IEnumerable<Product> GetProducts(string filter = null);
    }
}
