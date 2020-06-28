import api from '@api';
import { SERVER_SCHEDULED_PLACE_TO_EAT_PATH } from '@constants';

const { baseUrl } = require('@/config/config.dev.json');

export default {
  namespaced: true,
  actions: {
    getEatingUser ({ commit }) {
      return api.get('/scheduledPlaceToEat');
    },
    getEatingUserByEatingId ({ commit }, payload) {
      return api.get('/scheduledPlaceToEat/' + payload.id)
        .then(response => {
          const scheduledPlaceToEat = response.data;
          if (scheduledPlaceToEat.fileNames.length > 0) {
            scheduledPlaceToEat.files = [];
            scheduledPlaceToEat.fileNames.forEach(fileName => {
              scheduledPlaceToEat.files
                .push(`${baseUrl}/${SERVER_SCHEDULED_PLACE_TO_EAT_PATH}/${fileName}`);
            });
          }
          return scheduledPlaceToEat;
        }).catch(error => Promise.reject(error));
    },
    createNewEating ({ commit }, payload) {
      return api.post('/ScheduledPlaceToEat/create/', payload);
    },
    updateEating ({ commit }, payload) {
      return api.post('/scheduledPlaceToEat/update/', payload);
    },
    deleteEating ({ commit }, payload) {
      if (payload.id) {
        return api.post('/scheduledPlaceToEat/deleteById/' + payload.id);
      } else {
        return api.post('/scheduledPlaceToEat/delete/', payload);
      }
    },
    uploadNewFilesEating ({ commit }, { eatingId, files }) {
      return api.post('/ScheduledPlaceToEat/uploadEatingMultiFile/' + eatingId, files,
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        });
    }
  }
};
