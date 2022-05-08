using AutoMapper;
using RetroShirtDtos.Responses;
using RetroShirtDtos.Requests;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.MapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product,ProductListResponse>();
            CreateMap<ProductListResponse, Product>();
            CreateMap<ProductAddingRequest, Product>();
            CreateMap<ProductUpdateRequest, Product>();
           

           
        }
    }
}
