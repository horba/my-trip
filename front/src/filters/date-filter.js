import Vue from 'vue';
import { format } from 'date-fns';
import store from '@store';
import { enUS, ru, uk } from 'date-fns/locale';

const locales = { enUS, ru, uk };

Vue.filter('date',
  function (value, filterFormat) {
    if (!value) {
      return value;
    }

    return format(new Date(value), filterFormat || 'dd MMMM',
      {
        locale: locales[store.state.locale.language] || enUS
      }
    );
  }
);
