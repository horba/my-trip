import { VSelect } from 'vuetify/lib';
import { mapState } from 'vuex';

export default {
  name: 'mmt-locale-switcher',
  components: {
    VSelect
  },
  computed: {
    ...mapState({
      language: state => state.locale.language
    }),
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
  methods: {
    changeLanguage (language) {
      this.$store.commit('locale/CHANGE_LANGUAGE', language);
    }
  }
};
