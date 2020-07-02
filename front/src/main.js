import '@filters';

import { Authorize, Default } from '@layout';

import App from './App.vue';
import Vue from 'vue';
import axios from 'axios';
import i18n from './plugins/i18n';
import router from '@router';
import store from '@store';
import vuetify from './plugins/vuetify';

import * as VueGoogleMaps from 'vue2-google-maps';

Vue.use(VueGoogleMaps, {
  load: {
    key: process.env.VUE_APP_GOOGLE_MAP_API,
    libraries: 'places',
    region: 'uk,en,ru'
  }
});

Vue.component('default-layout', Default);
Vue.component('authorize-layout', Authorize);

Vue.use(VueGoogleMaps, {
  load: {
    key: process.env.VUE_APP_GOOGLE_MAP_API,
    libraries: 'places'
  },
  installComponents: true
});

new Vue({
  router,
  store,
  vuetify,
  i18n,
  created () {
    // load data from localStorage to vuex (on f5)
    const userString = localStorage.getItem('user');
    if (userString) {
      const userData = JSON.parse(userString);
      this.$store.commit('auth/SET_USER_DATA', userData);
    }

    this.$store.commit('locale/INIT_LANGUAGE');

    // prevent to use outdated token
    axios.interceptors.response.use(response => response, error => {
      if (error.response.status === 403) {
        this.$store.dispatch('auth/logout');
      }
      return Promise.reject(error);
    });
  },
  render: h => h(App)
}).$mount('#app');
