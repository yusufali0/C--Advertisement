using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Business.Interfaces;
using YAB.AdvertisementApp.UI.Extensions;

namespace YAB.AdvertisementApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceService _providedServiceService;
        private readonly IAdvertisementService _advertisemetService;

        public HomeController(IProvidedServiceService providedServiceService, IAdvertisementService advertisemetService)
        {
            _providedServiceService = providedServiceService;
            _advertisemetService = advertisemetService;
        }

        public async Task<IActionResult> Index()
        {
           var response= await _providedServiceService.GetAllAsync();
            return this.ResponseView(response);
        }


        public async Task<IActionResult> HumanResource()
        {
            var response = await _advertisemetService.GetActivesAsync();
            return this.ResponseView(response);
        }
    }
}
