using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Service;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Extensions;
using MVCProject.Models;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MenuController : Controller
    {
        IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {

            _menuService = menuService;
        }

        public IActionResult Menu()
        {


           

           // OrderViewModel OrderVM = new OrderViewModel(HttpContext.Session);

            OrderViewModel.GetOrder().Products.Add(new Product() { Price = 50 });

            // OrderVM.SaveOrder();

            //HttpContext.Session.SetObject("toto", new Order());


            List<Menu> lm = _menuService.GetAll(); 

            return View(lm);
        }

    }
}