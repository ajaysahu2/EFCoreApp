using Microsoft.AspNetCore.Mvc;

namespace EFCoreApp.Controllers
{
    public interface ControllerBase
    {
        IActionResult Index();
    }
}