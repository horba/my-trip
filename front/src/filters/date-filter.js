import Vue from 'vue';
import { format } from 'date-fns';
import store from '@store';
import { en, ru, ua } from 'date-fns/locale';

const locales = { en, ru, ua };

Vue.filter('date',
  function (value, filterFormat) {
    if (!value) {
      return value;
    }

    return format(new Date(value), filterFormat || 'dd MMMM',
      {
        locale: locales[store.state.locale.language] || en
      }
    );
  }
);
