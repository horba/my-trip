using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

    public Task<string> DownloadFileAsync(string fileUrl, AssetType assetType)
    {
      try
      {
        var fileName = $"{Guid.NewGuid()}.jpg";
        var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, GetPathByFileType(assetType), fileName);

        var webClient = new System.Net.WebClient();
        webClient.DownloadFileAsync(new Uri(fileUrl), filePath);

        return Task.FromResult(fileName);
      }
      catch
      {
        return null;
      }
    }

    public IEnumerable<string> DownloadFilesAsync(IEnumerable<string> filesUrls, AssetType assetType)
    {
      var tasks = filesUrls.Select(fileUrl => DownloadFileAsync(fileUrl, assetType)).ToArray();
      Task.WaitAll(tasks);

      return tasks.Select(t => t.Result).Where(r => r != null).ToList();
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
        case AssetType.Entertainment:
          return Consts.EntertainmentsPath;
        case AssetType.WaypointFile:
          return Consts.WaypointsFilesPath;
        case AssetType.Accommodation:
          return Consts.AccommodationsPath;
        default:
          break;
      }

      throw new Exception("Unsupported asset type");
    }
  }
}
