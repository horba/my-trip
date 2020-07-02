import api from '@api';

export default {
  namespaced: true,
  state: {
    accommodations: []
  },
  mutations: {
    INIT_ACCOMODATIONS (state, accommodations) {
      state.accommodations = accommodations;
    }
  },
  actions: {
    async initAccommodations ({ commit }) {
      await api.get('/accommodations')
        .then(r => {
          commit('INIT_ACCOMODATIONS', r.data);
        });
    },
    getAccommodation ({ commit }, id) {
      return api.get(`/accommodations/${id}`);
    },
    addOrUpdateAccommodation ({ commit }, formData) {
      return api.post('/accommodations', formData);
    },
    uploadFile ({ commit }, formData) {
      return api.post('/assets/accommodation', formData,
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        });
    },
    deleteFile ({ commit }, fileName) {
      return api.delete(`/assets/accommodation/${fileName}`);
    }
  }
};
