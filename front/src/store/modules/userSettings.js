import api from '@api';

const { baseUrl, apiSuffix } = require('@/config/config.dev.json'),
      { SERVER_AVATARS_PATH } = require('@constants');

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
    },
    uploadUserAvatarFile ({ commit }, formData) {
      return api.post('/assets/useravatar', formData,
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        });
    },
    deleteUserAvatarFile ({ commit }, fileName) {
      return api.delete(`/assets/useravatar/${fileName}`);
    }
  },
  getters: {
    getUserProfile: state => {
      return state.userSettings ? {
        fullName: `${state.userSettings.firstName} ${state.userSettings.lastName}`,
        email: state.userSettings.email,
        avatar: state.userSettings.avatarFileName
          ? `${baseUrl}/${apiSuffix}/${SERVER_AVATARS_PATH}/${state.userSettings.avatarFileName}`
          : null
      }
        : {};
    }
  }
};
