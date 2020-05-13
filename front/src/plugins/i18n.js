import Vue from 'vue';
import VueI18n from 'vue-i18n';

Vue.use(VueI18n);

export default new VueI18n({
  locale: window.localStorage.Language || 'ru',
  fallbackLocale: 'en',
  messages: {
    en: require('@/locales/en.json'),
    ru: require('@/locales/ru.json'),
    ua: require('@/locales/ua.json')
  }
});
