using AssociationCRMDawanPoe.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MVCProject.ViewComponents
{
    public class CommandViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            Order o = new Order() { Products = new List<Product> { new Product() { Price =  10} } };


            return View(o);
        }


    }
}
