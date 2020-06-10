const { EMAIL_REGEX } = require('@constants'),
      emailValidationMixin = {
        data () {
          return {
            emailRules: {
              validEmail: value =>
                RegExp(EMAIL_REGEX).test(value)
                  || this.$t('validationRules.enterCorrectEmail')
            }
          };
        }
      };

export { emailValidationMixin };
