using AutoMapper;

namespace Billetera.Models.Mapper
{
    public static class AutoMapperConfig
    {

        public static IMapper Initialize()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ConvertTo());
            });
            return mapperConfig.CreateMapper();
        }

    }
}