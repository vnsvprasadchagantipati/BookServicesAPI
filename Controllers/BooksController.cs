using BookServicesAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookServicesAPI.Entity;


namespace BookServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksServices booksServices;
        public BooksController()
        {
            booksServices = new BookServices();
        }

        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {

            try
            {
                List<Books> books = booksServices.GetAllBooks();
                return StatusCode(200, books);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

       

       [HttpGet,Route("GetProductByAuthor/{author}")]

        public IActionResult GetBookByAuthor(string Author)
        {

          
            try
            {
                List<Books> books = booksServices.GetBooksByAuthor(Author);
                if (books != null)
                    return StatusCode(200, books);
                else
                    return StatusCode(404, new JsonResult("Invalid Author"));
            }
            catch (Exception)
            {

                throw;
            }

            }

            [HttpPost, Route("AddBook")]

            public IActionResult Add([FromBody] Books books)
            {
                try
                {
                    booksServices.AddBook(books);
                    return Ok();//return same product in json form 
                                                  //  return Ok();
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }

            }
            //PUT/EDIT PRODUCT
            [HttpPut, Route("EditBook")]
            public IActionResult Edit(Books books)
            {
                try
                {
                    booksServices.UpdateBook(books);
                    return StatusCode(200, books);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
            [HttpDelete,Route("deleteBook/{Bookid}")]
                public IActionResult Delete(string Bookid)
            {

                try
                {

                booksServices.DeleteBook(Bookid);
                    return StatusCode(200, new JsonResult($"Product with string {Bookid} is deleted"));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
        [HttpGet,Route("GetBookByYear/{year}")]

        public IActionResult GetBookByYear(DateTime releasedate)
        {
            try
            {
               List< Books> books = booksServices.GetBooksByYear(releasedate);
                if (books != null)
                    return StatusCode(200, books);
                else
                    return StatusCode(404, new JsonResult("Invalid id"));

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet,Route("GetBookBylang/{lang}")]

        public IActionResult GetBookByLang(string Language)
        {
            try
            {
                List<Books> books = booksServices.GetBooksByLang(Language);
                if (books != null)
                    return StatusCode(200, books);
                else
                    return StatusCode(404, new JsonResult("Invalid language"));

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
    } 

