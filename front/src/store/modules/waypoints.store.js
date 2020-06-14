import api from '@api';

export default {
  namespaced: true,
  state: {
    waypoints: []
  },
  mutations: {
    SET_WAYPOINTS (state, newWaypoints) {
      state.waypoints = newWaypoints;
    },
    CLEAR_WAYPOINTS (state) {
      state.waypoints = [];
    },
    SWITCH_WP_STATE (state, wp) {
      wp.isCompleted = !wp.isCompleted;
    },
    DETELE_WAYPOINT (state, id) {
      state.waypoints = state.waypoints.filter(wp => wp.id !== id);
    }
  },
  actions: {
    loadWaypoints ({ commit }, tripId) {
      commit('CLEAR_WAYPOINTS');
      api.get(`/waypoints/bytrip/${tripId}`)
        .then(({ data }) => commit('SET_WAYPOINTS', data));
    },
    switchCompletedState ({ commit, state }, id) {
      const wp = state.waypoints.find(wp => wp.id === id);
      commit('SWITCH_WP_STATE', wp);
      api.put('/waypoints/set-completed-state', { id, state: wp.isCompleted });
    },
    deleteWaypoint ({ commit }, id) {
      commit('DETELE_WAYPOINT', id);
      api.delete(`/waypoints/${id}`);
    }
  },
  getters: {
    cardedWaypoints (state) {
      const wps = [];
      state.waypoints.forEach(wp => {
        wps.push(Object.assign({}, wp));
      });

      for (let i = wps.length - 1; i > 0; i--) {
        wps[i].arrival = wps[i - 1].arrival;
      }

      return wps;
    }
  }
};
