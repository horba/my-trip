import api from '@api';

export default {
  namespaced: true,
  actions: {
    getEatingUser (_context, payload) {
      return api.get('/scheduledPlaceToEat', payload);
    },
    getEatingUserByEatingId (_context, payload) {
      return api.get('/scheduledPlaceToEat/' + payload.id);
    },
    createNewEating (_context, payload) {
      return api.post('/ScheduledPlaceToEat/create/', payload);
    },
    updateEating (_context, payload) {
      return api.post('/scheduledPlaceToEat/update/', payload);
    },
    deleteEating (_context, payload) {
      if (payload.id) {
        return api.post('/scheduledPlaceToEat/deleteById/' + payload.id);
      }
    },
    uploadNewFilesEating (_context, { eatingId, files }) {
      return api.postFile('/ScheduledPlaceToEat/uploadEatingMultiFile/' + eatingId, files);
    }
  }
};
