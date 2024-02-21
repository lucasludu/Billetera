using AutoMapper;
using Billetera.Models.Dto;

namespace Billetera.Models.Mapper
{
    public class ConvertTo : Profile
    {
        public ConvertTo()
        {
            CreateMap<UsuarioRegisterDto, Usuario>().ReverseMap();
            CreateMap<UsuarioLoginDto, Usuario>().ReverseMap();
            CreateMap<UsuarioLoginDto, UsuarioDto>().ReverseMap();
            CreateMap<UsuarioDto, Usuario>().ReverseMap();

            CreateMap<CategoriaDto, Categoria>().ReverseMap();
            CreateMap<CategoriaConsultaDto, Categoria>().ReverseMap();

            CreateMap<MovimientoRegisterDto, Movimiento>().ReverseMap();
        }
    }
}
