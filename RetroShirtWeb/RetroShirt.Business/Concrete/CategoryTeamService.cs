using AutoMapper;
using RetroShirt.Business.Abstract;
using RetroShirtDAL.Repositories;
using RetroShirtDtos.Requests;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Concrete
{
    public class CategoryTeamService : ICategoryTeamService
    {
        private ICategoryTeamRepository categoryTeamRepository;
        private IMapper mapper;

        public CategoryTeamService(ICategoryTeamRepository categoryTeamRepository, IMapper mapper)
        {
           this.categoryTeamRepository = categoryTeamRepository;
           this.mapper = mapper;
        }
        public async Task addMany2Many(ProductAddingRequest productDto, CategoryTeam categoryTeam)
        {
            var addedData = mapper.Map<Product>(productDto);
            await categoryTeamRepository.addMany2Many(addedData, categoryTeam);
        }
    }
}
