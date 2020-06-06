import api from '@api';
import axios from 'axios';

const { serverPath } = require('@/config/config.dev.json'),
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
      return axios.post(`${serverPath}/api/assets/useravatar`, formData,
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        });
    },
    deleteUserAvatarFile ({ commit }, fileName) {
      return axios.delete(`${serverPath}/api/assets/useravatar/${fileName}`);
    }
  },
  getters: {
    getUserProfile: state => {
      return state.userSettings ? {
        fullName: `${state.userSettings.firstName} ${state.userSettings.lastName}`,
        email: state.userSettings.email,
        avatar: state.userSettings.avatarFileName
          ? `${serverPath}/${SERVER_AVATARS_PATH}/${state.userSettings.avatarFileName}`
          : null
      }
        : {};
    }
  }
};
