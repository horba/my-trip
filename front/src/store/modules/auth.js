import axios from 'axios';
import config from '@config';
const { serverPath } = config;

export default {
  namespaced: true,
  state: {
    user: null
  },
  mutations: {
    SET_USER_DATA (state, userData) {
      state.user = userData;
      localStorage.setItem('user', JSON.stringify(userData));
      axios.defaults.headers.common.Authorization = `Bearer ${userData.accessToken}`;
    },
    CLEAR_USER_DATA (state) {
      localStorage.removeItem('user');
      delete axios.defaults.headers.common.Authorization;
      location.reload();
    }
  },
  actions: {
    async signUp (context, body) {
      return await axios.post(`${serverPath}/api/auth/signup`, body)
        .then(r => {
          if (r.status === 200) {
            return 'Ok';
          }
        })
        .catch(e => {
          if (e && e.response.status === 422) {
            return 'UnprocessableEntity';
          }
        });
    },
    login ({ commit }, credentials) {
      return axios.post(`${serverPath}/api/auth`, credentials)
        .then(({ data }) => {
          commit('SET_USER_DATA', data);
        });
    },
    loginWithGoogle ({ commit }, code) {
      return axios.post(`${serverPath}/api/auth/google`, { code })
        .then(({ data }) => {
          commit('SET_USER_DATA', data);
        });
    },
    logout ({ commit }) {
      commit('CLEAR_USER_DATA');
    }
  },
  getters: {
    isLoggedIn (state) {
      return !!state.user;
    }
  }
};
