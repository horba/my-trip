import i18n from '@plugins/i18n.js';

export default {
  namespaced: true,
  getters: {
    genders () {
      return [
        {
          text: i18n.t('userSettings.genderIsNotSpecified'),
          value: 0
        },
        {
          text: i18n.t('userSettings.male'),
          value: 1
        },
        {
          text: i18n.t('userSettings.female'),
          value: 2
        },
        {
          text: i18n.t('userSettings.otherGender'),
          value: 3
        }
      ];
    },
    countries () {
      return [
        {
          text: i18n.t('userSettings.countryIsNotSpecified'),
          value: null
        },
        {
          text: i18n.t('countries.Albania'),
          value: 1
        },
        {
          text: i18n.t('countries.Canada'),
          value: 2
        },
        {
          text: i18n.t('countries.Colombia'),
          value: 3
        },
        {
          text: i18n.t('countries.Cyprus'),
          value: 4
        },
        {
          text: i18n.t('countries.Dominica'),
          value: 5
        },
        {
          text: i18n.t('countries.Egypt'),
          value: 6
        },
        {
          text: i18n.t('countries.France'),
          value: 7
        },
        {
          text: i18n.t('countries.Ukraine'),
          value: 8
        }
      ];
    },
    languages () {
      return [
        {
          text: i18n.t('userSettings.languageIsNotSpecified'),
          value: null
        },
        {
          text: i18n.t('locale.en'),
          value: 1
        },
        {
          text: i18n.t('locale.ru'),
          value: 2
        },
        {
          text: i18n.t('locale.ua'),
          value: 3
        }
      ];
    }
  }
};
