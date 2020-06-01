import axios from 'axios';
const { serverPath } = require('@/config/config.dev.json');

export default {
  namespaced: true,
  actions: {
    recoveryPasswordSendEmail ({ commit }, payload) {
      return axios.post(`${serverPath}/api/forgotPassword/`, { email: payload.email });
    },
    recoveryPasswordSendPassword ({ commit, state }, payload) {
      return axios.post(`${serverPath}/api/forgotPassword/resetPassword/`, payload);
    }
  }
};
