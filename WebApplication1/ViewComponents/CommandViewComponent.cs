using AssociationCRMDawanPoe.Entity;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.ViewComponents
{
    public class CommandViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return  View(OrderViewModel.GetOrder());
        }


    }
}
