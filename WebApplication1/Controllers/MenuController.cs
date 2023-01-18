using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Extensions;
using MVCProject.Models;
using ProjectAPI.Persistance;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MenuController : Controller
    {
        
        IMenuService _menuService;

        IProductService _productService;

        public MenuController(IMenuService menuService, IProductService productService)
        {

            _menuService = menuService;
            _productService = productService;
        }

        public IActionResult Menu()
        {
            return View(new CommandePageViewModel() { 
                Menus = _menuService.GetAll(),
                Products = _productService.GetAll() 
            });
        }

    }
}