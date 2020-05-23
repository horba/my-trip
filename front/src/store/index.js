import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';
import locale from './modules/locale';
const { serverPath } = require('@/config/config.dev.json');

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    user: null
  },
  modules: {
    locale
  },
  mutations: {
    SET_USER_DATA (state, userData) {
      state.user = userData;
      localStorage.setItem('user', JSON.stringify(userData));
      axios.defaults.headers.common.Authorization = `Bearer ${userData.accessToken}`;
    },
    CLEAR_USER_DATA (state) {
      localStorage.removeItem('user');
      location.reload();
    }
  },
  actions: {
    async signUp (context, body) {
      return await axios.post(`${serverPath}api/auth/signup`, body)
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
      return axios.post(`${serverPath}api/auth`, credentials)
        .then(({ data }) => {
          commit('SET_USER_DATA', data);
        });
    },
    logout ({ commit }) {
      commit('CLEAR_USER_DATA');
    },
    recoveryPasswordSendEmail (context, payload) {
      return new Promise((resolve, reject) => {
        axios.post(`${serverPath}api/ForgotPassword`,
          { Email: payload.email }).then(resp => {
          if (resp.status !== 200) {
            reject(resp.data);
          } else {
            localStorage.setItem('email', payload.email);
            resolve();
          }
        });
      });
    },
    recoveryPasswordSendPassword (context, passwordandtoken) {
      return new Promise((resolve, reject) => {
        axios.post(`${serverPath}api/ForgotPassword/ResetPassword`,
          { Email: localStorage.getItem('email'), Password: passwordandtoken.password }, {
            headers: { Authorization: 'Bearer ' + passwordandtoken.token }
          }).then(resp => {
          if (resp.data !== '') {
            localStorage.removeItem('email');
            resolve();
          } else {
            reject(resp.data);
          }
        });
      });
    }
  },
  getters: {
    isLoggedIn (state) {
      return !!state.user;
    }
  }
});
