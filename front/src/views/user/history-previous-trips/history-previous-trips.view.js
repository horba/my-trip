import { MmtTripCard, MmtTextInput } from '@components';

export default {
  components: {
    MmtTripCard,
    MmtTextInput
  },
  data: () => ({
    searchQuery: '',
    filter: {
      year: 0,
      month: 0
    }
  }),
  computed: {
    trips () {
      return this.$store.state.trip.tripsHistory;
    },
    years () {
      return this.trips.map(function (trip) {
        return new Date(trip.startDate).getFullYear();
      }).filter(function (trip, index, self) {
        return self.indexOf(trip) === index;
      }) || [];
    },
    months () {
      if (this.filter.year) {
        const lang = this.$store.state.locale.language || 'default';
        return this.trips.map(function (trip) {
          return {
            name: new Date(trip.startDate).toLocaleString(lang, { month: 'long' }),
            id: new Date(trip.startDate).getMonth() + 1
          };
        }).filter(function (trip, index, self) {
          return self.indexOf(trip) === index;
        });
      }

      return [];
    }
  },
  methods: {
    async searchTrips () {
      if (this.searchQuery) {
        await this.$store.dispatch('trip/searchTripsHistory', this.searchQuery);
      } else {
        await this.$store.dispatch('trip/initTripsHistory');
        this.filter.year = this.filter.month = 0;
      }
    },
    filterTrips (filter) {
      this.filter.year = filter.year || this.filter.year;
      this.filter.month = filter.month || this.filter.month;

      this.$store.commit('trip/FILTER_TRIPS_HISTORY', this.filter);
    }
  },
  async mounted () {
    await this.$store.dispatch('trip/initTripsHistory');
  }
};
