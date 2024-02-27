using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller,ControllerBase
    {
        private readonly ApplicationContext _context;
        public ValuesController(ApplicationContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Get()
        {
            var entity = _context.Model.FindEntityType(typeof(Student).FullName);

            if (entity != null)
            {
                var tableName = entity.GetTableName();
                var schemaName = entity.GetSchema();
                var key = entity.FindPrimaryKey();
                var properties = entity.GetProperties();

                // Do something with the retrieved information

                // Return an appropriate IActionResult based on your logic
                return Ok();
            }
            else
            {
                // Handle the case where the entity is not found
                return NotFound();
            }
        }

    }
}
