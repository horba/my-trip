import api from '@api';

export default {
  namespaced: true,
  state: {
    tripsHistory: [],
    upcomingTrips: []
  },
  mutations: {
    INIT_UPCOMING_TRIPS (state, trips) {
      state.upcomingTrips = trips;
    },
    INIT_TRIPS_HISTORY (state, trips) {
      state.tripsHistory = trips;
    },
    REQUEST_TRIPS_HISTORY (state, trips) {
      state.tripsHistory = trips;
    }
  },
  actions: {
    createNewTrip (_, tripData) {
      return api.post('/trips', tripData);
    },
    initUpcomingTrips ({ commit }) {
      return api.get('/trips/upcoming')
        .then(r => commit('INIT_UPCOMING_TRIPS', r.data));
    },
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
