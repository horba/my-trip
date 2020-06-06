import Vue from 'vue';
import Vuex from 'vuex';
import locale from './modules/locale';
import userSettings from './modules/userSettings';
import trip from './modules/trip';
import auth from './modules/auth';
import recoveryPassword from './modules/recoveryPassword.store';

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    locale,
    userSettings,
    trip,
    auth,
    recoveryPassword
  }
});
