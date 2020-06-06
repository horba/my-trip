import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';
import locale from './modules/locale';
import userSettings from './modules/userSettings';
import trip from './modules/trip';
import dictionaries from './modules/dictionaries';
import config from '@config';

const { serverPath } = config;

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    user: null
  },
  modules: {
    locale,
    userSettings,
    trip,
    dictionaries
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
    logout ({ commit }) {
      commit('CLEAR_USER_DATA');
    },
    recoveryPasswordSendEmail ({ commit }, payload) {
      axios.post(`${serverPath}/api/forgotPassword/`,
        { email: payload.email });
    },
    recoveryPasswordSendPassword ({ commit, state }, payload) {
      axios.post(`${serverPath}/api/forgotPassword/resetPassword/`, payload);
    }
  },
  getters: {
    isLoggedIn (state) {
      return !!state.user;
    }
  }
});
