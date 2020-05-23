import axios from 'axios';
import config from '@config';

const { serverPath } = config;

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
      await axios.get(`${serverPath}api/trips/history`)
        .then(r => {
          if (r.status === 200) {
            commit('INIT_TRIPS_HISTORY', r.data);
          }
        });
    },
    async searchTripsHistory ({ commit }, searchQuery) {
      await axios.get(`${serverPath}api/trips/history?searchQuery=${searchQuery}`)
        .then(r => {
          if (r.status === 200) {
            commit('REQUEST_TRIPS_HISTORY', r.data);
          }
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
