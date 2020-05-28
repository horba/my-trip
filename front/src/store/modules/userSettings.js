import axios from 'axios';
const { serverPath } = require('@/config/config.dev.json');
const { serverImagesPath } = require('@/config/constants.json');

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
    },
    uploadUserAvatarFile ({ commit }, formData) {
      return axios.put(`${serverPath}api/assets/useravatar`, formData,
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        });
    },
    deleteUserAvatarFile ({ commit }, formData) {
      return axios.delete(`${serverPath}api/assets/useravatar`, formData);
    }
  },
  getters: {
    getUserProfile: state => {
      return state.userSettings ? {
        fullName: `${state.userSettings.firstName} ${state.userSettings.lastName}`,
        email: state.userSettings.email,
        avatar: state.userSettings.avatarFileName
          ? `${serverPath}${serverImagesPath.avatars}/${state.userSettings.avatarFileName}`
          : null
      }
        : {};
    }
  }
};
