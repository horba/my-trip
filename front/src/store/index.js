import Vue from 'vue';
import Vuex from 'vuex';
import locale from './modules/locale';
import userSettings from './modules/userSettings';
import trip from './modules/trip';
import auth from './modules/auth';
import axios from 'axios';
import config from '@config';

const { serverPath } = config;

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    locale,
    userSettings,
    trip,
    auth
  },
  actions: {
    recoveryPasswordSendEmail ({ commit }, payload) {
      axios.post(`${serverPath}/api/forgotPassword/`,
        { email: payload.email });
    },
    recoveryPasswordSendPassword ({ commit, state }, payload) {
      axios.post(`${serverPath}/api/forgotPassword/resetPassword/`, payload);
    }
  }
});
