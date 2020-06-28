import { MmtWaypointCard, MmtWaypointTransferCard } from '@components';
import { mapState } from 'vuex';

export default {
  props: [ 'id' ],
  components: {
    MmtWaypointCard,
    MmtWaypointTransferCard
  },
  computed: {
    ...mapState('waypoints', [ 'waypoints' ])
  },
  mounted () {
    this.$store.dispatch('waypoints/loadWaypoints', [ +this.id ]);
  }
};
