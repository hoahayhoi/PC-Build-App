using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace api.Service
{
    public class CloudStorageService : ICloudStorageService
    {
        private readonly Cloudinary _cloudinary;

        public CloudStorageService(Cloudinary cloudinary)
        {
            _cloudinary = cloudinary;
        }

        public async Task<UploadResult> UploadFileAsync(IFormFile file)
        {
            if (file.Length <= 0) return null;

            using (var stream = file.OpenReadStream())
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation().Width(500).Height(500).Crop("fill")
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);
                return uploadResult;
            }
        }
    }
}