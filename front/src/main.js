import Vue from 'vue';
import App from './App.vue';
import router from '@router';
import store from '@store';
import vuetify from './plugins/vuetify';
import i18n from './plugins/i18n';
import Default from './layouts/Default.vue';
import Authorize from './layouts/Authorize.vue';

Vue.component('default-layout', Default);
Vue.component('authorize-layout', Authorize);

Vue.config.productionTip = false;

new Vue({
  router,
  store,
  vuetify,
  i18n,
  render: h => h(App)
}).$mount('#app');
