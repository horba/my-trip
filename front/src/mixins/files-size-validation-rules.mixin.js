const { MAX_FILE_SIZE_SCHEDULET_PLACE_TO_EAT } = require('@constants'),
      filesSizeValidMixin = {
        data () {
          return {
            rules: {
              filesSizeValid: v => {
                if (v) {
                  let valid = true;
                  v.forEach(file => {
                    if (file.size > MAX_FILE_SIZE_SCHEDULET_PLACE_TO_EAT) {
                      valid = false;
                    }
                  });
                  return valid ? true : this.$t('validationRules.enterCorrectFiles'
                    , [ MAX_FILE_SIZE_SCHEDULET_PLACE_TO_EAT ]);
                } else {
                  return true;
                }
              }
            }
          };
        }
      };

export { filesSizeValidMixin };
