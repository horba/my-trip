import Vue from 'vue';

Vue.filter('trim',
  function (value, length) {
    if (!value) {
      return value;
    }
    return value.length > length ? value.substr(0, length) + '...' : value;
  }
);
