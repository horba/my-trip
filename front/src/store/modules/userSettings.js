import axios from 'axios';
const { serverPath } = require('@/config/config.dev.json');

export default {
  namespaced: true,
  state: {
    userSettings: null
  },
  mutations: {
    SET_USER_SETTINGS (state, userSettings) {
      state.userSettings = userSettings;
    }
  },
  actions: {
    loadUserSettings ({ commit }) {
      axios.get(`${serverPath}api/userSettings`)
        .then(({ data }) => {
          commit('SET_USER_SETTINGS', data);
        });
    },
    updateUserSettings ({ commit }, formData) {
      return axios.put(`${serverPath}api/userSettings`, formData)
        .then(() => commit('SET_USER_SETTINGS', formData));
    }
  },
  getters: {
    userSettings (state) {
      return state.userSettings;
    }
  }
};
