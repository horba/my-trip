import { VSelect } from 'vuetify/lib';

export default {
  name: 'mmt-locale-switcher',
  components: {
    VSelect
  },
  computed: {
    language () {
      return this.$store.state.locale.language;
    },
    locales () {
      return [
        {
          text: this.$t('locale.enUS'),
          value: 'enUS'
        },
        {
          text: this.$t('locale.ru'),
          value: 'ru'
        },
        {
          text: this.$t('locale.uk'),
          value: 'uk'
        }
      ];
    }
  },
  methods: {
    changeLanguage (language) {
      this.$store.commit('locale/CHANGE_LANGUAGE', language);
    }
  }
};
