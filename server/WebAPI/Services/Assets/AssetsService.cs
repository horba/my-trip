using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebAPI.Services.Assets
{
  public class AssetsService
  {
    private readonly IWebHostEnvironment _webHostEnvironment;

    public AssetsService(IWebHostEnvironment webHostEnvironment)
    {
      _webHostEnvironment = webHostEnvironment;
    }

    public async Task<string> SaveFileAsync(IFormFile file, AssetType assetType)
    {
      var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
      var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, GetPathByFileType(assetType), fileName);

      using (var stream = File.Create(filePath))
      {
        await file.CopyToAsync(stream);
      }

      return fileName;
    }

    public void DeleteFile(string fileName, AssetType assetType)
    {
      if (string.IsNullOrEmpty(fileName))
        return;

      var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, GetPathByFileType(assetType), fileName);
      if (File.Exists(filePath))
      {
        File.Delete(filePath);
      }
    }

    private static string GetPathByFileType(AssetType type)
    {
      switch (type)
      {
        case AssetType.UserAvatar:
          return Consts.UsersAvatarsPath;
        case AssetType.FileEating:
          return Consts.FileEatingPath;
        case AssetType.WaypointFile:
          return Consts.WaypointsFilesPath;
        default:
          break;
      }

      throw new Exception("Unsupported asset type");
    }
  }
}
