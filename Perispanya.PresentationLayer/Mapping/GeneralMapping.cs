using AutoMapper;
using Perispanya.DtoLayer.Dtos.AboutDtos;
using Perispanya.DtoLayer.Dtos.SliderDtos;
using Perispanya.EntityLayer.Concrete;

namespace Perispanya.PresentationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<GetByIdAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultSliderDto, Slider>().ReverseMap();
            CreateMap<CreateSliderDto, Slider>().ReverseMap();
            CreateMap<GetByIdSliderDto, Slider>().ReverseMap();
            CreateMap<UpdateSliderDto, Slider>().ReverseMap();
        }
    }
}
