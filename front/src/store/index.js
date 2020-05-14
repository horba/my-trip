import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';

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
    signUp ({ commit }, body) {
      return axios.post('https://localhost:5001/api/auth/signup', body);
    },
    login ({ commit }, credentials) {
      return axios.post('//localhost:3000/login', credentials)
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
});
