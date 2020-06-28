import api from '@api';

export default {
  namespaced: true,
  state: {
    waypoints: [],
    tripId: null,
    isFresh: true
  },
  mutations: {
    SET_WAYPOINTS (state, newWaypoints) {
      state.waypoints = newWaypoints;
    },
    CLEAR_WAYPOINTS (state) {
      state.waypoints = [];
    },
    SET_WAYPOINT_STATE (state, { id, isChecked }) {
      state.waypoints.find(waypoint => waypoint.id === id).isCompleted = isChecked;
    },
    SET_WAYPOINT_DETAILS (state, { id, isChecked }) {
      state.waypoints.find(waypoint => waypoint.id === id).isDetails = isChecked;
    },
    DETELE_WAYPOINT (state, id) {
      state.waypoints = state.waypoints.filter(waypoint => waypoint.id !== id);
    },
    SET_TRIP_ID (state, id) {
      state.tripId = +id;
    },
    DELETE_FILE (state, [fileName, waypointId]) {
      const targetWaypoint = state.waypoints.find(waypoint => waypoint.id === waypointId);
      targetWaypoint.files = targetWaypoint.files.filter(f => f.actualFileName !== fileName);
    },
    ADD_FILE (state, [userFileName, actualFileName, waypointId]) {
      const targetWaypoint = state.waypoints.find(waypoint => waypoint.id === waypointId);
      targetWaypoint.files.push({ actualFileName, userFileName });
    }
  },
  actions: {
    loadWaypoints ({ commit, state }, [tripId, isForce]) {
      if (state.tripId === tripId && !isForce) {
        return Promise.resolve();
      }

      return api.get(`/waypoints/bytrip/${tripId}`)
        .then(({ data }) => {
          commit('SET_WAYPOINTS', data);
          commit('SET_TRIP_ID', +tripId);
        });
    },
    setCompletedState ({ commit, state }, { id, isChecked }) {
      api.put('/waypoints/set-completed-state', { id, state: isChecked })
        .then(() => commit('SET_WAYPOINT_STATE', { id, isChecked }));
    },
    setDetailsState ({ commit, state }, { id, isChecked }) {
      api.put('/waypoints/set-details-state', { id, state: isChecked })
        .then(() => commit('SET_WAYPOINT_DETAILS', { id, isChecked }));
    },
    deleteWaypoint ({ commit, state }, id) {
      if (state.waypoints.length === 2) {
        commit('CLEAR_WAYPOINTS');
      } else {
        commit('DETELE_WAYPOINT', id);
      }
      api.delete(`/waypoints/${id}`);
    },
    insertWaypoint (_, waypoint) {
      return api.post('/waypoints', waypoint);
    },
    updateWaypoint (_, waypoint) {
      return api.put('/waypoints', waypoint);
    },
    deleteFile ({ commit }, [fileName, waypointId]) {
      commit('DELETE_FILE', [fileName, waypointId]);
      api.delete(`/waypointFile/${waypointId}/${fileName}`);
    },
    addFile ({ commit }, [formData, fileName, waypointId]) {
      api.post(`/waypointFile/${waypointId}`, formData,
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        })
        .then(({ data }) => commit('ADD_FILE', [fileName, data, waypointId]));
    },
    sendMultipleFiles (_, [formData, waypointId]) {
      return api.post(`/waypointFile/multiple/${waypointId}`, formData,
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        });
    }
  }
};
