import api from '@api';
import { SERVER_SCHEDULED_PLACE_TO_EAT_PATH } from '@constants';

const { baseUrl } = require('@/config/config.dev.json');

export default {
  namespaced: true,
  actions: {
    getEatingUser () {
      return api.get('/scheduledPlaceToEat');
    },
    createNewEating ({ commit }, payload) {
      return api.post('/assets/UploadEatingMultiFile/', payload.attachments,
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        });
    },
    updateEating ({ commit }, payload) {
      return api.post('/scheduledPlaceToEat/update/', payload);
    },
    deleteEating ({ commit }, payload) {
      return api.post('/scheduledPlaceToEat/delete/', { payload, files: payload.attachments },
        {
          headers: {
            'Content-Type': 'multipart/form-data'
          }
        });
    },
    getFiles ({ commit }, payload) {
      payload.files = [];
      payload.fileNames.forEach(fileName => {
        payload.files.push(`${baseUrl}/${SERVER_SCHEDULED_PLACE_TO_EAT_PATH}/${fileName}`);
      });
    }
  }
};
