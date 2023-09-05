using Library_DataModels.Models;

namespace LibraryUI.Services
{
    public interface IFrontEndService 
    {
        Task<List<LibraryDb>> GetLibraryDbs();

        Task<LibraryDb> GetBook(int id);

        Task<LibraryDb> UploadImage(byte[] image);

        Task<LibraryDb> AddNewBook(LibraryDb library);

        Task<LibraryDb> UpdateBook(LibraryDb library);

        Task<LibraryDb> DeleteBook(int BookID);
    }
}
