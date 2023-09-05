using Library_BusinessLogic.Services;
using Library_DataModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Libraby_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService = null;

        public LibraryController(ILibraryService libraryService)
        {
            this._libraryService = libraryService;
        }
    
        [HttpGet]
        [Route("getLibraryDbs")]
        public IActionResult GetLibraryDBs()
        {
            var data = _libraryService.GetLibraryDbs();
            return Ok(data);
        }

        [HttpGet]
        [Route("getLibraryDbs/{id:int}")]
        public async Task<ActionResult<LibraryDb>> GetBook(int id)
        { 
                var result = await _libraryService.GetBook(id);

                if (result == null) return NotFound();

                return Ok(result);
        }

        [HttpGet]
        [Route("DeleteBook")]
        public IActionResult DeleteBook(int BookID)
        {
            var data = _libraryService.DeleteBook(BookID);
            return Ok(data);
        }

        [HttpPost]
        [Route("AddNewBook")]
        public IActionResult AddNewBook(LibraryDb library)
        {
            var data = _libraryService.AddNewBook(library);
            return Ok(data);
        }

        [HttpPost]
        [Route("UpdateBook")]
        public  IActionResult UpdateBook(LibraryDb library)
        {
            var data = _libraryService.UpdateBook(library);
            return Ok(data);
        }
    }
}
 