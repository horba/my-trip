export default {
  namespaced: true,
  state: {
    language: localStorage.getItem('language')
  },
  mutations: {
    SET_LANGUAGE (state, language) {
      localStorage.setItem('language', language);
      state.language = language;
    }
  },
  actions: {
    setLanguage ({ commit }, locales) {
      commit('SET_LANGUAGE', locales);
    }
  },
  getters: {
    getLanguage (state) {
      return state.language;
    }
  }
};
