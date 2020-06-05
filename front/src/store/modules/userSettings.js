import axios from 'axios';
import config from '@config';

const { serverPath } = config;

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
      axios.get(`${serverPath}/api/userSettings`)
        .then(({ data }) => {
          commit('SET_USER_SETTINGS', data);
        });
    },
    updateUserSettings ({ commit }, formData) {
      return axios.put(`${serverPath}/api/userSettings`, formData)
        .then(() => commit('SET_USER_SETTINGS', formData));
    }
  }
};
