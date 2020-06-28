import Vue from 'vue';
import i18n from '../plugins/i18n';

Vue.filter('replacementTypes',
  function (type) {
    if (!type) {
      return type;
    }
    if (type === 'food') {
      return i18n.t('eating.food');
    } else if (type === 'restaurant') {
      return i18n.t('eating.restaurant');
    } else if (type === 'bar') {
      return i18n.t('eating.bar');
    } else if (type === 'establishment') {
      return i18n.t('eating.establishment');
    } else if (type === 'cafe') {
      return i18n.t('eating.cafe');
    } else if (type === 'meal_delivery') {
      return i18n.t('eating.meal_delivery');
    } else if (type === 'meal_takeaway') {
      return i18n.t('eating.meal_takeaway');
    } else {
      return type;
    }
  }
);
