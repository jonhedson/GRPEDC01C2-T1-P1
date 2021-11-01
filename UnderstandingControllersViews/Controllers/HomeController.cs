using Microsoft.AspNetCore.Mvc;
using UnderstandingControllersViews.Models;

namespace UnderstandingControllersViews.Controllers
{
    public class HomeController : Controller
    {
        #region Propriedade Request
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceivedDataByRequest()
        {
            string name = Request.Form["name"];
            string sex = Request.Form["sex"];
            

            return View("ReceivedDataByRequest", $"{name} sex is {sex}");
        }
        #endregion

        #region Parameters
        public IActionResult IndexP()
        {
            return View();
        }

        public IActionResult ReceivedDataByParameter(string name, string sex)
        {
            return View("ReceivedDataByParameter", $"{name} sex is {sex}");
        }
        #endregion

        #region Model Binding
        public IActionResult IndexMb()
        {
            return View();
        }

        
        public IActionResult ReceivedDatabyModelBinding(Person person)
        {
            return View("ReceivedDatabyModelBinding", person);
        }
        #endregion

        #region ViewData
        public ViewResult Details()
        {
            
            Person p = new Person()
            {
                name = "Gabriel",
                sex = "M"
            };

            ViewData["Person"] = p;

            return View();
        }
        #endregion
    }
}
