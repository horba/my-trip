export const timeValidationMixin = {
  data () {
    return {
      rules: {
        time: value => /^([01][0-9]|2[0-3]):([0-5][0-9])$/.test(value)
        || this.$t('validationRules.enterCorrectTime')
      }
    };
  }
};
