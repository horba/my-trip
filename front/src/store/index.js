import Vue from 'vue';
import Vuex from 'vuex';
import auth from './modules/auth.store';
import dictionaries from './modules/dictionaries.store';
import entertainment from './modules/entertainment.store';
import locale from './modules/locale.store';
import recoveryPassword from './modules/recoveryPassword.store';
import trip from './modules/trip.store';
import userSettings from './modules/userSettings.store';
import userTickets from './modules/userTickets.store';
import eating from './modules/eating.store';
import waypoints from './modules/waypoints.store';
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
    eating,
    entertainment,
    waypoints,
    dictionaries,
    accommodations
  }
});
