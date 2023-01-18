using AssociationCRMDawanPoe.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using MVCProject.Extensions;
using SqlKata;

namespace MVCProject.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class CommandePageViewModel 
    {

        public List<Menu> Menus = new List<Menu>();

        public List<Product> Products = new List<Product>();

    }
}