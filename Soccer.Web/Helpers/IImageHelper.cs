using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Soccer.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string folder);
        //Task<string> UploadImageAsync(object logoFile, string v);

        // string UploadImage(byte[] pictureArray, string folder);
    }
}
