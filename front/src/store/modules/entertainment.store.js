import api from '@api';
import { PAGINTAION_ENTERTAINMENT_PAGE_SIZE } from '@constants';

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
    async getEntertainments ({ commit }, pageNumber) {
      return await api.get('/entertainment', {
        pageNumber: pageNumber,
        pageSize: PAGINTAION_ENTERTAINMENT_PAGE_SIZE
      })
        .then(r => {
          commit('INIT_ENTERTAINMENTS', r.data.data);
          return r.data;
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
