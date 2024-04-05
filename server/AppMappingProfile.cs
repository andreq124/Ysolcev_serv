using AutoMapper;
using server.News;
using server.Users;

namespace server
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<UserEntity, UserDTO>();
            CreateMap<NewsEntity, NewsDTO>();
        }
    }
}
