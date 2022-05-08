using AutoMapper;
using RetroShirtDAL.Repositories;
using RetroShirtDtos.Requests;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Abstract
{
    public interface ICategoryTeamService
    {
        public Task addMany2Many(ProductAddingRequest product, CategoryTeam categoryTeam);
    }
}
