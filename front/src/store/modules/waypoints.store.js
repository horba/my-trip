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
    SWITCH_WP_STATE (_, wp) {
      wp.isCompleted = !wp.isCompleted;
    },
    SWITCH_WP_DETAILS (_, wp) {
      wp.isDetails = !wp.isDetails;
    },
    DETELE_WAYPOINT (state, id) {
      state.waypoints = state.waypoints.filter(wp => wp.id !== id);
    },
    SET_TRIP_ID (state, id) {
      state.tripId = id;
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
          commit('SET_TRIP_ID', tripId);
        });
    },
    switchCompletedState ({ commit, state }, id) {
      const wp = state.waypoints.find(wp => wp.id === id);
      commit('SWITCH_WP_STATE', wp);
      api.put('/waypoints/set-completed-state', { id, state: wp.isCompleted });
    },
    switchDetailsState ({ commit, state }, id) {
      const wp = state.waypoints.find(wp => wp.id === id);
      commit('SWITCH_WP_DETAILS', wp);
      api.put('/waypoints/set-details-state', { id, state: wp.isDetails });
    },
    deleteWaypoint ({ commit, state }, id) {
      if (state.waypoints.length === 2) {
        commit('CLEAR_WAYPOINTS');
      } else {
        commit('DETELE_WAYPOINT', id);
      }
      api.delete(`/waypoints/${id}`);
    },
    insertWaypoint ({ commit, dispatch, state }, wp) {
      commit('CLEAR_WAYPOINTS');
      return api.post('/waypoints', wp)
        .then(() => {
          dispatch('loadWaypoints', [state.tripId, true]);
        });
    },
    updateWaypoint ({ commit, dispatch, state }, wp) {
      commit('CLEAR_WAYPOINTS');
      return api.put('/waypoints', wp)
        .then(() => {
          dispatch('loadWaypoints', [state.tripId, true]);
        });
    }
  },
  getters: {
    cardedWaypoints (state) {
      const wps = [];
      state.waypoints.forEach(wp => {
        wps.push(Object.assign({}, wp));
      });

      for (let i = wps.length - 1; i > 0; i--) {
        wps[i].arrivalDate = wps[i - 1].arrivalDate;
        wps[i].details = wps[i - 1].details;
      }

      return wps;
    }
  }
};
