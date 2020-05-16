import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';
const { serverPath } = require('@/config/config.dev.json');

Vue.use(Vuex);

export default new Vuex.Store({
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
      return axios.post('//localhost:3000/login', credentials)
        .then(({ data }) => {
          commit('SET_USER_DATA', data);
        });
    },
    logout ({ commit }) {
      commit('CLEAR_USER_DATA');
    },
    async getPreviousTrips ({ commit }, queryParams) {
      return await axios.get(`${serverPath}api/trips/previous?${queryParams}`)
        .then(r => {
          if (r.status === 200) {
            return r;
          }
        })
        .catch(e => {
          return 'ServerError';
        });
    }
  },
  getters: {
    isLoggedIn (state) {
      return !!state.user;
    }
  }
});
