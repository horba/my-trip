import api from '@api';

export default {
  namespaced: true,
  state: {
    entertainments: []
  },
  mutations: {
    INIT_ENTERTAINMENTS (state, entertainments) {
      state.entertainments = entertainments;
    }
  },
  actions: {
    async initEntertainments ({ commit }) {
      await api.get('/entertainment')
        .then(r => {
          commit('INIT_ENTERTAINMENTS', r.data);
        });
    },
    getEntertainment ({ commit }, id) {
      return api.get(`/entertainment/${id}`);
    },
    addOrUpdateEntertainment ({ commit }, formData) {
      return api.post('/entertainment', formData);
    },
    uploadFile ({ commit }, formData) {
      return api.postFile('/assets/entertainment', formData);
    },
    deleteFile ({ commit }, fileName) {
      return api.delete(`/assets/entertainment/${fileName}`);
    },
    deleteFilePath ({ commit }, id) {
      return api.delete(`/entertainment/${id}`);
    }
  }
};
