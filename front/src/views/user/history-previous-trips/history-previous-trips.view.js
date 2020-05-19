import { MmtHistoryTripCard, MmtTextInput } from '@components';

export default {
  components: {
    MmtHistoryTripCard,
    MmtTextInput
  },
  data: () => ({
    searchQuery: '',
    year: 0,
    years: [new Date().getFullYear(), new Date().getFullYear() - 1, new Date().getFullYear() - 2],
    trips: []
  }),
  methods: {
    async getTrips () {
      const queryParams = `year=${this.year}&&searchQuery=${this.searchQuery}`,
            response = await this.$store.dispatch('getPreviousTrips', queryParams);

      if (response && response.data) {
        this.trips = response.data;
      } else {
        this.trips = [];
      }
    },
    filterByYear (y) {
      if (this.year === y) {
        this.year = 0;
      } else {
        this.year = y;
      }

      this.getTrips();
    }
  },
  mounted () {
    this.getTrips();
  }
};
