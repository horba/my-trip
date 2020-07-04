import api from '@api';
import router from '@router/index.js';

export default {
  namespaced: true,
  state: {
    user: null
  },
  mutations: {
    SET_USER_DATA (state, userData) {
      state.user = userData;
      localStorage.setItem('user', JSON.stringify(userData));
    },
    CLEAR_USER_DATA (state) {
      localStorage.removeItem('user');
      router.push('/');
    }
  },
  actions: {
    signUp (context, body) {
      return api.post('/auth/signup', body);
    },
    login ({ commit }, credentials) {
      return api.post('/auth', credentials)
        .then(({ data }) => {
          commit('SET_USER_DATA', data);
        });
    },
    loginWithGoogle ({ commit }, code) {
      return api.post('/auth/google', { code })
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
