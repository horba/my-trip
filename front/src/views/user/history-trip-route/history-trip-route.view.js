import { MmtWaypointCard } from '@components';

export default {
  components: {
    MmtWaypointCard
  },
  computed: {
    waypoints () {
      return this.$store.getters['waypoints/cardedWaypoints'];
    }
  },
  mounted () {
    this.$store.dispatch('waypoints/loadWaypoints', this.$route.params.id);
  }
};
