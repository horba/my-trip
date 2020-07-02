import Vue from 'vue';

Vue.filter('price',
  function (value) {
    if (!value) {
      return value;
    }

    const val = (value / 1).toFixed(0).replace('.', ',');
    return `${val.toString().replace(/\B(?=(\d{3})+(?!\d))/g, '.')}`;
  }
);
