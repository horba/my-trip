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
    }
  },
  data: () => ({
    currentLanguage: String
  }),
  mounted: function () {
    this.currentLanguage = this.$store.state.locale.language;
  },
  methods: {
    switchLocale (language) {
      this.$i18n.locale = language;
      this.$store.dispatch('locale/setLanguage', language);
    }
  }
};
