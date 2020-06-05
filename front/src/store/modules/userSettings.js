import api from '@api';

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
      api.get('/userSettings')
        .then(({ data }) => {
          commit('SET_USER_SETTINGS', data);
        });
    },
    updateUserSettings ({ commit }, formData) {
      return api.put('/userSettings', formData)
        .then(() => commit('SET_USER_SETTINGS', formData));
    }
  }
};
