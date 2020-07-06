using System.Linq;
using System.Threading.Tasks;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebAPI.Services.Assets;

namespace WebAPI.Services
{
  public interface IWaypointFileService
  {
    bool HasFreeSpace(int waypointId);
    Task<string> AddFile(int waypointId, IFormFile file);
    void DeleteFile(string actualName);
    void DeleteAllFilesOfWaypoint(int waypointId);
  }

  public class WaypointFileService : IWaypointFileService
  {
    private readonly IWaypointFileRepository _waypointFileRepository;
    private readonly IWaypointRepository _waypointRepository;
    private readonly AssetsService _assetsService;

    public WaypointFileService(IWaypointFileRepository waypointFileRepository, AssetsService assetsService, IWaypointRepository waypointRepository)
    {
      _waypointFileRepository = waypointFileRepository;
      _assetsService = assetsService;
      _waypointRepository = waypointRepository;
    }

    public bool HasFreeSpace(int waypointId)
    {
      return _waypointFileRepository.GetFiles().Count(waypointFile => waypointFile.WaypointId == waypointId) < Consts.MaxWaypointFileCount;
    }

    public async Task<string> AddFile(int waypointId, IFormFile file)
    {
      var actualName = await _assetsService.SaveFileAsync(file, AssetType.WaypointFile);

      _waypointFileRepository.CreateFile(new WaypointFile { WaypointId = waypointId, ActualFileName = actualName, UserFileName = file.FileName });

      return actualName;
    }

    public void DeleteFile(string actualName)
    {
      var waypointf = _waypointFileRepository.GetFiles()
        .FirstOrDefault(waypointFile => waypointFile.ActualFileName == actualName);

      if (waypointf == null)
        return;

      _assetsService.DeleteFile(actualName, AssetType.WaypointFile);
      _waypointFileRepository.DeleteFile(waypointf);
    }

    public void DeleteAllFilesOfWaypoint(int waypointId)
    {
      var actualNames = _waypointRepository.GetWaypoints()
        .Include(waypoint => waypoint.Files)
        .FirstOrDefault(waypoint => waypoint.Id == waypointId)
        .Files.Select(file => file.ActualFileName);
      foreach (var actualName in actualNames)
      {
        DeleteFile(actualName);
      }
    }

  }
}
