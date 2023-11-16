using BookServicesAPI.Database;
using BookServicesAPI.Entity;

namespace BookServicesAPI.Services
{
    public class BookServices : IBooksServices
    {
        private readonly MyContext _context;
        public BookServices() 
        { 
            _context = new MyContext();
        }
        public void AddBook(Books books)
        {
            try
            {
                _context.Books.Add(books);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteBook(string BookId)
        {


            try
            {
                Books books = _context.Books.Find(BookId);
                _context.Books.Remove(books);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public List<Books> GetAllBooks()
        {
             try
            {
                return _context.Books.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Books> GetBooksByAuthor(string Author)
        {
             try
            {
                List<Books> books = _context.Books.Where(item=>item.Author==Author).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Books> GetBooksByLang(string Language)
        {
            try
            {
                List<Books> books = _context.Books.Where(item => item.Language == Language).ToList();
                return books;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Books> GetBooksByYear(DateTime year)
        {
            try
            {
                List<Books> books = _context.Books.Where(item => item.ReleaseDate == year).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateBook(Books books)
        {
            try
            {
                _context.Books.Update(books);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
