import api from '@api';

export default {
  namespaced: true,
  state: {
    tickets: []
  },
  mutations: {
    SET_USER_TICKETS (state, tickets) {
      state.tickets = tickets;
    }
  },
  actions: {
    refreshTickets ({ commit }) {
      api
        .get('/tickets')
        .then(({ data }) => {
          commit('SET_USER_TICKETS', data);
        });
    }
  },
  getters: {
    tickets (state) {
      return state.tickets;
    }
  }
};
