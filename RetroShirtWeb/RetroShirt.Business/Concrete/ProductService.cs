using AutoMapper;
using RetroShirt.Business.Abstract;
using RetroShirtDAL.Repositories;
using RetroShirtDtos.Requests;
using RetroShirtDtos.Responses;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Concrete
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepostiry;
        private IMapper mapper;

        public ProductService(IProductRepository productRepository,IMapper mapper)
        {
            this.productRepostiry = productRepository;
            this.mapper = mapper;
        }

        public async Task<int> AddProduct(ProductAddingRequest productAdding)
        {
            var addProduct= mapper.Map<Product>(productAdding);
            return await productRepostiry.Add(addProduct);

        }

        public async Task DeleteProduct(int id)
        {
            await productRepostiry.Delete(id);

        }

        public async Task<IList<ProductListResponse>> GetEntitiesWithActiveStatus()
        {
            var productWithoutMapping = await productRepostiry.GetProductsWithActiveStatus();
            var mapProduct= mapper.Map<List<ProductListResponse>>(productWithoutMapping);
            return mapProduct;
        }

        public async Task<Product> GetProductById(int id)
        {
                   
            return await productRepostiry.GetEntityById(id);
        }

        public async Task<IList<ProductListResponse>> GetProducts()
        {
            var products = await productRepostiry.GetAllEntities();
            var convertedProducts = mapper.Map<List<ProductListResponse>>(products);
            return convertedProducts;
        }


        public async Task<bool> ProductIsExist(Product product)
        {           

            return await productRepostiry.IsExist(product);
        }

        public async Task RemoveProductCompletely(int id)
        {
            await productRepostiry.RemoveProductCompletely(id);
        }

        public async Task<IList<ProductListResponse>> SearcyByName(string searchValue)
        {
            var products = await productRepostiry.SearchProducts(searchValue);
            var convertProducts = mapper.Map<List<ProductListResponse>>(products);
            return convertProducts;
        }

        public async Task<int> UpdateProduct(ProductUpdateRequest updateRequest)
        {
            var convertProduct = mapper.Map<Product>(updateRequest);
            var result= await productRepostiry.Update(convertProduct);
            return result;

        }

        
    }
}
