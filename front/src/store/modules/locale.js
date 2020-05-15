import i18n from '../../plugins/i18n';

export default {
  namespaced: true,
  state: {
    language: localStorage.getItem('language')
  },
  mutations: {
    SET_LANGUAGE (state, language) {
      i18n.locale = language;
      localStorage.setItem('language', language);
      state.language = language;
    }
  },
  actions: {
    setLanguage ({ commit }, locales) {
      commit('SET_LANGUAGE', locales);
    }
  }
};
