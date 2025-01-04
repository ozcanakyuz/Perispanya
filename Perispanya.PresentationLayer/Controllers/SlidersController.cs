using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Perispanya.BusinnesLayer.Abstract;
using Perispanya.DtoLayer.Dtos.SliderDtos;
using Perispanya.EntityLayer.Concrete;

namespace Perispanya.PresentationLayer.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public IActionResult SliderList()
        {
            var values = _sliderService.TGetAll();
            return View(_mapper.Map<List<ResultSliderDto>>(values));
        }
        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            if (ModelState.IsValid)
            {
                var value = _mapper.Map<Slider>(createSliderDto);
                _sliderService.TInsert(value);
                return RedirectToAction("SliderList");
            }
            return View(createSliderDto);
        }

        public IActionResult DeleteSlider(int id)
        {
            _sliderService.TDelete(id);
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            var updateSliderDto = _mapper.Map<UpdateSliderDto>(value);
            return View(updateSliderDto);
        }
        [HttpPost]
        public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            if (ModelState.IsValid)
            {
                var value = _mapper.Map<Slider>(updateSliderDto);
                _sliderService.TUpdate(value);
                return RedirectToAction("SliderList");
            }
            return View(updateSliderDto);
        }
    }
}
