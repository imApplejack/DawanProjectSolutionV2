﻿using AssociationCRMDawanPoe.Entity;
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

        public MenuController(IMenuService menuService)
        {

            _menuService = menuService;
        }

        public IActionResult Menu()
        {
            List<Menu> lm = _menuService.GetAll(); 
            return View(lm);
        }

    }
}