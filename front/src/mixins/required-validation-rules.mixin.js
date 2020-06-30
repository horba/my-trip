export const requiredValidationMixin = {
  data () {
    return {
      rules: {
        required: value => !!value || this.$t('validationRules.noEmpty'),
        greaterThenZero: value => value > 0 || this.$t('validationRules.greaterThanZero')
      }
    };
  }
};
