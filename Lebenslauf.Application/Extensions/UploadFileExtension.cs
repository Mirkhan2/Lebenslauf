using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Application.Extensions
{
    public static class UploadFileExtension
    {
        public static async Task AddImageAjaxToServer(IFormFile file, string fileName, string originalPath)
        {
            if (file != null)
            {
                if (!Directory.Exists(originalPath)) Directory.CreateDirectory(originalPath);

                string OriginalPath = originalPath + fileName;

                using (var stream = new FileStream(originalPath, FileMode.Create))
                {
                    if (!Directory.Exists(originalPath)) await file.CopyToAsync(stream);
                }
            }
        }
    }
}
