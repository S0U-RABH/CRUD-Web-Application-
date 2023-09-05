using Library_DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BusinessLogic.Services
{
    public interface ILibraryService
    {
        //object getLibraryDb();
        List<LibraryDb> GetLibraryDbs();

        LibraryDb AddNewBook(LibraryDb _libraryDb);

        LibraryDb UpdateBook(LibraryDb _libraryDb);

        LibraryDb DeleteBook(int BookID);

        Task<LibraryDb> GetBook(int BookId);
    }
}
