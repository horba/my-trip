using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using WebAPI.DTO;

namespace WebAPI.Services
{
  public class WaypointService
  {

    private WaypointRepository _waypointRepository;
    private IMapper _mapper;

    public WaypointService(WaypointRepository waypointRepository, IMapper mapper)
    {
      _waypointRepository = waypointRepository;
      _mapper = mapper;
    }

    public IEnumerable<WaypointDTO> GetWaypoints(int tripId)
    {
      return _mapper.Map<IEnumerable<WaypointDTO>>(_waypointRepository.GetWaypointsByTripId(tripId));
    }

    public void UpdateCompletedState(int wpId, bool state)
    {
      var wp = _waypointRepository.GetWaypoint(wpId);

      if (wp != null)
      {
        wp.IsCompleted = state;
        _waypointRepository.UpdateWaypoint(wp);
      }
    }

    public bool IsWaypointAllowed(int userId, int wpId)
    {
      return _waypointRepository.GetWaypointUserOwner(wpId) == userId;
    }

  }
}
