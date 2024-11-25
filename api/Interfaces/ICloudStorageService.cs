using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace api.Interfaces
{
    public interface ICloudStorageService
    {
        Task<UploadResult> UploadFileAsync(IFormFile file);
    }
}