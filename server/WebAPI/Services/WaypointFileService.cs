using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebAPI.Services.Assets;

namespace WebAPI.Services
{
  public interface IWaypointFileService
  {
    bool HasFreeSpace(int wpId);
    Task<string> AddFile(int wpId, IFormFile file);
    void DeleteFile(string actualName);
    void DeleteAllFilesOfWaypoint(int wpId);
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

    public bool HasFreeSpace(int wpId)
    {
      return _waypointFileRepository.GetFiles().Count(wpf => wpf.WaypointId == wpId) < Consts.MaxWaypointFileCount;
    }

    public async Task<string> AddFile(int wpId, IFormFile file)
    {
      var actualName = await _assetsService.SaveFileAsync(file, AssetType.WaypointFile);

      _waypointFileRepository.CreateFile(new WaypointFile { WaypointId = wpId, ActualFileName = actualName, UserFileName = file.FileName });

      return actualName;
    }

    public void DeleteFile(string actualName)
    {
      var wpf = _waypointFileRepository.GetFiles()
        .FirstOrDefault(wpf => wpf.ActualFileName == actualName);

      if (wpf == null)
        return;

      _assetsService.DeleteFile(actualName, AssetType.WaypointFile);
      _waypointFileRepository.DeleteFile(wpf);
    }

    public void DeleteAllFilesOfWaypoint(int wpId)
    {
      var actualNames = _waypointRepository.GetWaypoints()
        .Include(wp => wp.Files)
        .FirstOrDefault(wp => wp.Id == wpId)
        .Files.Select(f => f.ActualFileName);
      foreach (var actualName in actualNames)
      {
        DeleteFile(actualName);
      }
    }

  }
}
