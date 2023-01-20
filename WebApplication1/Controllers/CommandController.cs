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
        [HttpPost]
        public IActionResult AddMenu( int id )
        {
            try
            {
                Menu m = MenuService.GetById(id);
                OrderViewModel.GetOrder().Menus.Add(m);
                return Ok(OrderViewModel.GetOrder().GetPrice());
            }
            catch(Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpPost]
        public IActionResult AddProduct(int id)
        {
            try
            {
                Product p = ProductService.GetById(id);
                OrderViewModel.GetOrder().Products.Add(p);
                return Ok(OrderViewModel.GetOrder().GetPrice());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult RemoveMenu(int offset)
        {
            try
            {
                OrderViewModel.GetOrder().Menus.RemoveAt(offset);
                return Ok(OrderViewModel.GetOrder().GetPrice());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }


        [HttpPost]
        public IActionResult RemoveProduct(int offset)
        {
            try
            {
                OrderViewModel.GetOrder().Products.RemoveAt(offset);
                return Ok(OrderViewModel.GetOrder().GetPrice());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        public IActionResult ShowCommand()
        {
            return View(OrderViewModel.GetOrder());
        }

        public IActionResult ValidateCommand()
        {
            OrderService.NewOrder(OrderViewModel.GetOrder());
            OrderViewModel.CleanOrder();
            return View();
        }

    }
}