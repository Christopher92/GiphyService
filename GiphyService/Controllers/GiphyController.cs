using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiphyService.Services;
using Microsoft.AspNetCore.Mvc;

namespace GiphyService.Controllers
{
    public class GiphyController : Controller
    {
        public GiphyServices _giphyServices { get; }

        public GiphyController(GiphyServices giphyServices)
        {
            _giphyServices = giphyServices;
        }


        public async Task<IActionResult> GetRandomGif(string searchCriteria)
        {
            var result = await _giphyServices.GetRandomGifBasedOnSearchCriteria(searchCriteria);

            return Ok(result);
        }
    }
}