import { VSelect } from 'vuetify/lib';

export default {
  name: 'mmt-locale-switcher',
  components: {
    VSelect
  },
  computed: {
    locales () {
      return [
        {
          text: this.$t('locale.en'),
          value: 'en'
        },
        {
          text: this.$t('locale.ru'),
          value: 'ru'
        },
        {
          text: this.$t('locale.ua'),
          value: 'ua'
        }
      ];
    },
    currentLanguage: {
      get: function () {
        return this.$store.state.locale.language;
      },
      set: function (language) {
        this.$store.dispatch('locale/setLanguage', language);
      }
    }
  }
};
