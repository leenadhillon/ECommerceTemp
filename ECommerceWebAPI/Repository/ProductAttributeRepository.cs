using ECommerceWebAPI.DataAccessLayer;
using ECommerceWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWebAPI.Repository
{
    public class ProductAttributeRepository : IDisposable
    {
        private readonly DLProductAttributeRepository productAttributeRepository;
        public ProductAttributeRepository()
        {
            productAttributeRepository = new DLProductAttributeRepository();
        }
        public async Task<List<ProductAttribute>> GetAllProductAttribute(GetProductAttributeRequest getProductAttributeRequest)
        {
            SqlParameter[] parameter = {
                    new SqlParameter("@ProductCatID", getProductAttributeRequest.ProdCatId)
                };

            return await productAttributeRepository.GetAllProductAttribute(parameter);
        }
        public void Dispose()
        {

        }
    }
}
