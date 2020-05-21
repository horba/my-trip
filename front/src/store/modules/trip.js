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
    },
    FILTER_TRIPS_HISTORY (state, data) {
      let filterFunc;

      if (data.year && data.month) {
        filterFunc = function (trip) {
          return new Date(trip.startDate).getFullYear() === data.year
            && new Date(trip.startDate).getMonth() + 1 === data.month;
        };
      } else if (data.year) {
        filterFunc = function (trip) {
          return new Date(trip.startDate).getFullYear() === data.year;
        };
      }

      const trips = state.tripsHistory.filter(filterFunc);
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
  }
};
