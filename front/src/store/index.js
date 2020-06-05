import Vue from 'vue';
import Vuex from 'vuex';
import api from '@api';
import locale from './modules/locale';
import trip from './modules/trip';
import userSettings from './modules/userSettings';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    user: null
  },
  modules: {
    locale,
    userSettings,
    trip
  },
  mutations: {
    SET_USER_DATA (state, userData) {
      state.user = userData;
      localStorage.setItem('user', JSON.stringify(userData));
    },
    CLEAR_USER_DATA (state) {
      localStorage.removeItem('user');
      location.reload();
    }
  },
  actions: {
    async signUp (context, body) {
      return await api.post('/auth/signup', body)
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
      return api.post('/auth', credentials)
        .then(({ data }) => {
          commit('SET_USER_DATA', data);
        });
    },
    logout ({ commit }) {
      commit('CLEAR_USER_DATA');
    },
    recoveryPasswordSendEmail ({ commit }, payload) {
      api.post('/forgotPassword/', { email: payload.email });
    },
    recoveryPasswordSendPassword ({ commit, state }, payload) {
      api.post('/forgotPassword/resetPassword/', payload);
    }
  },
  getters: {
    isLoggedIn (state) {
      return !!state.user;
    }
  }
});
