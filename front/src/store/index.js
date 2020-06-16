import Vue from 'vue';
import Vuex from 'vuex';
import locale from './modules/locale.store';
import recoveryPassword from './modules/recoveryPassword.store';
import auth from './modules/auth.store';
import trip from './modules/trip.store';
import userSettings from './modules/userSettings.store';
import userTickets from './modules/userTickets.store';
import accommodations from './modules/accommodations.store';

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    locale,
    userSettings,
    trip,
    auth,
    userTickets,
    recoveryPassword,
    accommodations
  }
});
