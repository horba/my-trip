import Vue from 'vue';
import App from './App.vue';
import router from '@router';
import store from '@store';
import vuetify from './plugins/vuetify';
import i18n from './plugins/i18n';
import axios from 'axios';
import { Default, Authorize } from '@layout';

Vue.component('default-layout', Default);
Vue.component('authorize-layout', Authorize);

Vue.config.productionTip = false;

new Vue({
  router,
  store,
  vuetify,
  i18n,
  created () {
    // load data from localStorage to vuex (on f5)
    const userString = localStorage.getItem('user'),
          language = localStorage.getItem('language');
    if (userString) {
      const userData = JSON.parse(userString);
      this.$store.commit('SET_USER_DATA', userData);
    }

    if (language) {
      this.$store.dispatch('locale/setLanguage', language);
    }

    // prevent to use outdated token
    axios.interceptors.response.use(response => response, error => {
      if (error.response.status === 403) {
        this.$store.dispatch('logout');
      }
      return Promise.reject(error);
    });
  },
  render: h => h(App)
}).$mount('#app');
