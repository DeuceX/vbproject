using AutoMapper;
using BLL.Dto.Customer;
using Domain.Users;

namespace BLL.Map
{
    public class CustomerMapperProfile : Profile
    {
        public CustomerMapperProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(x => x.Id, t => t.MapFrom(p => p.Id))
                .ForMember(x => x.Role, t => t.MapFrom(p => p.Role.ToString()));
        }
    }
}
