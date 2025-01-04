using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Perispanya.BusinnesLayer.Abstract;
using Perispanya.DtoLayer.Dtos.AboutDtos;
using Perispanya.EntityLayer.Concrete;

namespace Perispanya.PresentationLayer.Controllers
{
    public class AboutsController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IActionResult AboutList()
        {
            var values = _aboutService.TGetAll();
            return View(_mapper.Map<List<ResultAboutDto>>(values));
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            if (ModelState.IsValid)
            {
                var value = _mapper.Map<About>(createAboutDto);
                _aboutService.TInsert(value);
                return RedirectToAction("AboutList");
            }
            return View(createAboutDto);
        }
        public IActionResult DeleteAbout(int id)
        {
            _aboutService?.TDelete(id);
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            var updateAboutDto = _mapper.Map<UpdateAboutDto>(value);
            return View(updateAboutDto);
        }
        [HttpPost]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            if (ModelState.IsValid)
            {
                var value = _mapper.Map<About>(updateAboutDto);
                _aboutService.TUpdate(value);
                return RedirectToAction("AboutList");
            }
            return View(updateAboutDto);
        }
    }
}
