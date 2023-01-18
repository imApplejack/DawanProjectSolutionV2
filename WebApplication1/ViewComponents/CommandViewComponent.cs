using Microsoft.AspNetCore.Mvc;

namespace MVCProject.ViewComponents
{
    public class CommandViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            return  View(10);
        }


    }
}
