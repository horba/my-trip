import i18n from '../../plugins/i18n';

export default {
  namespaced: true,
  state: {
    language: localStorage.getItem('language')
  },
  mutations: {
    INIT_LANGUAGE (state, language) {
      state.language = language;
    },
    CHANGE_LANGUAGE (state, language) {
      state.language = language;
    }
  },
  actions: {
    initLanguage ({ commit }) {
      const language = localStorage.getItem('language');
      if (language) {
        i18n.locale = language;
        localStorage.setItem('language', language);
        commit('INIT_LANGUAGE', language);
      }
    },
    changeLanguage ({ commit }, language) {
      i18n.locale = language;
      localStorage.setItem('language', language);
      commit('CHANGE_LANGUAGE', language);
    }
  }
};
