using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Service;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    public class CommandController : Controller
    {


        IProductService ProductService;

        IMenuService MenuService;

        IOrderService OrderService;

        


        public CommandController(IProductService productService, IMenuService menuService, IOrderService orderService)
        {
            ProductService = productService;
            MenuService = menuService;
            OrderService = orderService;
        }

        // permet d'ajouter par son id un menu à la commande en cours
        [HttpGet]
        public IActionResult AddMenu( int id )
        {
            try
            {
                 Menu m = MenuService.GetById(id);
                 OrderViewModel.GetOrder().Menus.Add(m);

                 return Ok(Json(400));
            }
            catch(Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpGet]
        public IActionResult AddProduct(int id)
        {
            return Ok(Json("pouet" + id));
        }


        //public

    }
}