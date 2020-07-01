import { MmtTripCard, MmtTextInput } from '@components';
import { mapState } from 'vuex';

export default {
  components: {
    MmtTripCard,
    MmtTextInput
  },
  data: () => ({
    searchQuery: '',
    period: {
      year: 0,
      month: 0
    }
  }),
  computed: {
    isPrevTripsPage () {
      return this.$route.name === 'MyHistoryPrev';
    },
    ...mapState('trip', [ 'upcomingTrips' ]),
    trips () {
      if (this.isPrevTripsPage) {
        return this.period.year || this.period.month
          ? this.$store.getters['trip/getTripsHistoryByPeriod'](this.period)
          : this.$store.state.trip.tripsHistory;
      }
      return this.$store.state.trip.upcomingTrips;
    },
    years () {
      return this.trips.map((trip) => {
        return new Date(trip.startDate).getFullYear();
      }).filter((trip, index, self) => {
        return self.indexOf(trip) === index;
      }) || [];
    },
    months () {
      if (this.period.year) {
        const lang = this.$store.state.locale.language || 'default';
        return this.trips.map((trip) => {
          const date = new Date(trip.startDate);
          return {
            name: date.toLocaleString(lang, { month: 'long' }),
            id: date.getMonth() + 1
          };
        }).filter((trip, index, self) => {
          return self.findIndex(t => t.id === trip.id) === index;
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
        this.period.year = this.period.month = 0;
      }
    }
  },
  async mounted () {
    await this.$store.dispatch('trip/initTripsHistory');
    this.$store.dispatch('trip/initUpcomingTrips');
  }
};
