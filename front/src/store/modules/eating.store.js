import api from '@api';
import { SERVER_SCHEDULED_PLACE_TO_EAT_PATH } from '@constants';

const { baseUrl } = require('@/config/config.dev.json');

export default {
  namespaced: true,
  actions: {
    async getEatingUser ({ commit }) {
      return api.get('/scheduledPlaceToEat');
    },
    async getEatingUserByEatingId ({ commit }, payload) {
      return new Promise((resolve, reject) => {
        api.get('/scheduledPlaceToEat/' + payload.id).then(r => {
          const scheduledPlaceToEat = r.data;
          if (scheduledPlaceToEat.fileNames.length > 0) {
            scheduledPlaceToEat.files = [];
            scheduledPlaceToEat.fileNames.forEach(fileName => {
              scheduledPlaceToEat.files
                .push(`${baseUrl}/${SERVER_SCHEDULED_PLACE_TO_EAT_PATH}/${fileName}`);
            });
          }
          resolve(scheduledPlaceToEat);
        }).catch(r => reject(r));
      });
    },
    async createNewEating ({ commit }, payload) {
      return await api.post('/ScheduledPlaceToEat/create/', payload);
    },
    async updateEating ({ commit }, payload) {
      return await api.post('/scheduledPlaceToEat/update/', payload);
    },
    async deleteEating ({ commit }, payload) {
      return await api.post('/scheduledPlaceToEat/delete/', payload);
    },
    async uploadNewFilesEating ({ commit }, payload) {
      return await api.post('/ScheduledPlaceToEat/uploadEatingMultiFile/', payload);
    }
  }
};
