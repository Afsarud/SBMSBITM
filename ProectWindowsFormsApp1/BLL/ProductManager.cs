using ProectWindowsFormsApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProectWindowsFormsApp1.BLL
{
    class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        Product _product = new Product();

        public bool Add(Product product)
        {
            return _productRepository.Add(product);
        }

    }
}
