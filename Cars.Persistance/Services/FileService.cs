using Microsoft.AspNetCore.Http;
using Cars.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistance.Services
{
    public class FileService : IFileService
    {
        private readonly string _imageDirectory = Path.Combine("wwwroot", "images");

        public FileService()
        {
            if (!Directory.Exists(_imageDirectory))
            {
                Directory.CreateDirectory(_imageDirectory);
            }
        }

        public async Task<string> SaveFileAsync(IFormFile file)
        {
            var filePath = Path.Combine(_imageDirectory, Guid.NewGuid() + Path.GetExtension(file.FileName));
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filePath;
        }

        public async Task DeleteFileAsync(string filePath)
        {
            await Task.Run(() =>
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            });
        }
    }
}