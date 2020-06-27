import { MmtWaypointCard, MmtWaypointTransferCard } from '@components';
import { mapGetters } from 'vuex';

export default {
  props: [ 'id' ],
  components: {
    MmtWaypointCard,
    MmtWaypointTransferCard
  },
  computed: {
    ...mapGetters('waypoints', [ 'cardedWaypoints' ])
  },
  mounted () {
    this.$store.dispatch('waypoints/loadWaypoints', [ +this.id ]);
  }
};
