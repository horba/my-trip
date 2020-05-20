import axios from 'axios';
const { serverPath } = require('@/config/config.dev.json');

export default {
  namespaced: true,
  state: {
    trips: []
  },
  mutations: {
  },
  actions: {
    async getPreviousTrips (context, data) {
      const queryParams = `year=${data.year}&&searchQuery=${data.searchQuery}`;
      return await axios.get(`${serverPath}api/trips/previous?${queryParams}`)
        .then(r => {
          if (r.status === 200) {
            return r;
          }
        })
        .catch(e => {
          return 'ServerError';
        });
    }
  }
};
