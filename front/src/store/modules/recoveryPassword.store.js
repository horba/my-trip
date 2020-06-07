import api from '@api';

export default {
  namespaced: true,
  actions: {
    recoveryPasswordSendEmail ({ commit }, payload) {
      return api.post('/recoveryPassword/', { email: payload.email });
    },
    recoveryPasswordSendPassword ({ commit, state }, payload) {
      return api.post('/recoveryPassword/updatePassword/', payload);
    }
  }
};
