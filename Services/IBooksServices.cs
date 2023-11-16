using BookServicesAPI.Entity;

namespace BookServicesAPI.Services
{
    public interface IBooksServices
    {

        void AddBook(Books books);
        void DeleteBook(string BookId);
        void UpdateBook(Books books);
        List<Books> GetAllBooks();
        List<Books> GetBooksByAuthor(string Author);
        List<Books> GetBooksByYear(DateTime year);
        List<Books> GetBooksByLang(string Language);


    }
}
