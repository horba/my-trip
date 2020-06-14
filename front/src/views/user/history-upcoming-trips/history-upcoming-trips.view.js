import { MmtTripCard } from '@components';
import { mapState } from 'vuex';

export default {
  components: {
    MmtTripCard
  },
  computed: {
    ...mapState('trip', [ 'upcomingTrips' ])
  },
  mounted () {
    this.$store.dispatch('trip/initUpcomingTrips');
  }
};
