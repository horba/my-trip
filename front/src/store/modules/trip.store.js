import api from '@api';

export default {
  namespaced: true,
  state: {
    tripsHistory: []
  },
  mutations: {
    INIT_TRIPS_HISTORY (state, trips) {
      state.tripsHistory = trips;
    },
    REQUEST_TRIPS_HISTORY (state, trips) {
      state.tripsHistory = trips;
    }
  },
  actions: {
    async initTripsHistory ({ commit }) {
      await api.get('/trips/history')
        .then(r => {
          commit('INIT_TRIPS_HISTORY', r.data);
        });
    },
    async searchTripsHistory ({ commit }, searchQuery) {
      await api.get(`/trips/history?searchQuery=${searchQuery}`)
        .then(r => {
          commit('REQUEST_TRIPS_HISTORY', r.data);
        });
    }
  },
  getters: {
    getTripsHistoryByPeriod: state => period => {
      return state.tripsHistory.filter((trip) => {
        const date = new Date(trip.startDate);
        return date.getFullYear() === period.year
          && (period.month ? date.getMonth() + 1 === period.month : true);
      });
    }
  }
};
