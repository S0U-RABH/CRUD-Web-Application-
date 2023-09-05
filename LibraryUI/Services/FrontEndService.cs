using Library_DataModels.Models;

namespace LibraryUI.Services
{
    public class FrontEndService : IFrontEndService
    {
        private readonly HttpClient _httpClient = null;

        public FrontEndService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<LibraryDb>> GetLibraryDbs()
        {
            return await _httpClient.GetFromJsonAsync<List<LibraryDb>>("api/Library/getLibraryDbs");

        }

        public async Task<LibraryDb> GetBook(int BookID)
        {
            return await _httpClient.GetFromJsonAsync<LibraryDb>("api/Library/getLibraryDbs/?BookID" + BookID);
        }

        public async Task<LibraryDb> AddNewBook(LibraryDb library)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Library/AddNewBook", library);
            return await response.Content.ReadFromJsonAsync<LibraryDb>();
        }
        public async Task<LibraryDb> UploadImage(byte[] library)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Library/images", library);
            return await response.Content.ReadFromJsonAsync<LibraryDb>();
        }

        public async Task<LibraryDb> UpdateBook(LibraryDb library)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Library/UpdateBook", library);
            return await response.Content.ReadFromJsonAsync<LibraryDb>();
        }

        public async Task<LibraryDb> DeleteBook(int BookID)
        {
            return await _httpClient.GetFromJsonAsync<LibraryDb>("api/Library/DeleteBook/?BookID=" + BookID);
        }
    }
}
