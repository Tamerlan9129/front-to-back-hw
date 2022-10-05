using front_to_back.Models;
using front_to_back.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var chooseUs = new List<ChooseUs> {
            new ChooseUs {  Title="Our vision",Text="Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra",FilePath="bxs-bulb" },
            
            
            new ChooseUs { Title = "Our mission", Text = "Eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam quis.", FilePath = "bx-revision" },
            new ChooseUs { Title = "Our goal", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit,sed do eiusmod tempor.", FilePath = "bxs-select-multiple" },



            };

            var model = new AboutIndexViewModel { ChooseUS = chooseUs };

            return View(model);
        }
    }
}
