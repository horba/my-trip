import { MmtWaypointCard } from '@components';

export default {
  props: [ 'id' ],
  components: {
    MmtWaypointCard
  },
  computed: {
    waypoints () {
      return this.$store.getters['waypoints/cardedWaypoints'];
    }
  },
  mounted () {
    this.$store.dispatch('waypoints/loadWaypoints', [ this.id ]);
  }
};
