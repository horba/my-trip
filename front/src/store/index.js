import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';
import locale from './modules/locale';
import trip from './modules/trip';
import config from '@config';

const { serverPath } = config;

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    user: null,
    email: ''
  },
  modules: {
    locale,
    trip
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
    },
    SET_EMAIL_DATA (state, email) {
      state.email = email;
      localStorage.setItem('email', email);
    },
    CLEAR_EMAIL_DATA (state) {
      state.email = '';
      localStorage.removeItem('email');
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
    recoveryPasswordSendEmail ({ commit }, payload) {
      return new Promise((resolve, reject) => {
        axios.post(`${serverPath}api/ForgotPassword`,
          { Email: payload.email }).then(resp => {
          if (resp.status !== 200) {
            reject(resp.data);
          } else {
            commit('SET_EMAIL_DATA', payload.email);
            resolve();
          }
        });
      });
    },
    recoveryPasswordSendPassword ({ commit, state }, passwordandtoken) {
      return new Promise((resolve, reject) => {
        axios.post(`${serverPath}api/ForgotPassword/ResetPassword`,
          { Email: state.email, Password: passwordandtoken.password }, {
            headers: { Authorization: 'Bearer ' + passwordandtoken.token }
          }).then(resp => {
          if (resp.data !== '') {
            commit('CLEAR_EMAIL_DATA');
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
    },
    getEmail (state) {
      return state.email;
    }
  }
});
