using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    public class CommandController : Controller
    {

        public CommandController()
        {
            
        }

        // permet d'ajouter par son id un menu à la commande en cours
        [HttpGet]
        public IActionResult AddMenu( int id )
        {
            return Ok(Json("pouet" + id));
        }
        

     

        //public


    }
}