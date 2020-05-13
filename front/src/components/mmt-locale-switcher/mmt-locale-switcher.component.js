import { VSelect } from 'vuetify/lib';

export default {
  name: 'mmt-locale-switcher',
  components: {
    VSelect
  },
  data () {
    return {
      locales: [
        {
          text: 'locale.en',
          value: 'en'
        },
        {
          text: 'locale.ru',
          value: 'ru'
        },
        {
          text: 'locale.ua',
          value: 'ua'
        }]
    };
  },
  methods: {
    switchLocale (locale) {
      this.$root.$i18n.locale = locale;
      window.localStorage.Language = locale;
    }
  }
};
