using Azure;
using Library_DataModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BusinessLogic.Services
{
    public class LibraryServicecs : ILibraryService
    { 
        private readonly LibraryDbContext _DbContext = null;

        public LibraryServicecs(LibraryDbContext DBContext)
        {
            this._DbContext = DBContext;
        }

        public List<LibraryDb> GetLibraryDbs()
        {
          var data = _DbContext.LibraryDbs.ToList();
          return data;
        }

        public async Task<LibraryDb> GetBook(int BookId)
        {
            return await _DbContext.LibraryDbs
                .FirstOrDefaultAsync(e => e.BookId == BookId);
        }

        public LibraryDb AddNewBook(LibraryDb _libraryDb)
        {
                _DbContext.LibraryDbs.Add(_libraryDb);
                _DbContext.SaveChanges();

                return _libraryDb;
        }

        public LibraryDb UpdateBook(LibraryDb _libraryDb)
        {
            
                var data = _DbContext.LibraryDbs.Where(x => x.BookId == _libraryDb.BookId).FirstOrDefault();
                if (data != null)
                {
                    data.Title = _libraryDb.Title;
                    data.Author = _libraryDb.Author;
                    data.Isbn = _libraryDb.Isbn;
                    data.Discription = _libraryDb.Discription;
                    data.PhotoPath= _libraryDb.PhotoPath;

                    _DbContext.LibraryDbs.Update(data);
                    _DbContext.SaveChanges();

                    return data;
                }
                else
                {
                     return _libraryDb;
                }
        }

        public LibraryDb DeleteBook(int BookID)
        {
                
            var data = _DbContext.LibraryDbs.Where(x => x.BookId == BookID).FirstOrDefault();
            if (data != null)
            {

                _DbContext.LibraryDbs.Remove(data);
                _DbContext.SaveChanges();

                return data;
            }
            else
            {
                return data;
            }

        }

    }
}
