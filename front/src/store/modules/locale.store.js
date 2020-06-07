import i18n from '../../plugins/i18n';

export default {
  namespaced: true,
  state: {
    language: localStorage.getItem('language')
  },
  mutations: {
    INIT_LANGUAGE (state) {
      const language = localStorage.getItem('language');
      if (language) {
        i18n.locale = language;
        localStorage.setItem('language', language);
        state.language = language;
      }
    },
    CHANGE_LANGUAGE (state, language) {
      i18n.locale = language;
      localStorage.setItem('language', language);
      state.language = language;
    }
  }
};
