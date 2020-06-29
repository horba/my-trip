export const dateValidationMixin = {
  data () {
    return {
      rules: {
        date: value => /^(19|20|21)\d{2}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[01])$/.test(value)
        || this.$t('validationRules.enterCorrectDate')
      }
    };
  }
};
