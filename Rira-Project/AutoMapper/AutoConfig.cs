using AutoMapper;
using Rira_Project.Models;
using Rira_Project.Repository;

namespace Rira_Project.AutoMapper
{
    public class AutoConfig : Profile
    {
        public AutoConfig()
        {
            CreateMap<Product, ProductDto>()
             .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.ToString()));
        }
    }
}
