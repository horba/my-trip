export default {
  props: {
    hideDeparture: {
      type: Boolean,
      default: false
    },
    hideArrival: {
      type: Boolean,
      default: false
    },
    waypoint: {
      type: Object,
      required: true
    },
    prevWaypoint: {
      type: Object,
      required: true
    }
  },
  data () {
    return {
      isCompleted: null,
      isDetails: null
    };
  },
  methods: {
    updateCompletedState () {
      this.isCompleted = !this.isCompleted;
      this.$store.dispatch('waypoints/setCompletedState',
        { id: this.waypoint.id, isChecked: this.isCompleted });
    },
    updateDetailsState () {
      this.isDetails = !this.isDetails;
      this.$store.dispatch('waypoints/setDetailsState',
        { id: this.waypoint.id, isChecked: this.isDetails });
    },
    deleteWaypoint () {
      this.$store.dispatch('waypoints/deleteWaypoint', this.waypoint.id);
    }
  },
  mounted () {
    this.isCompleted = this.waypoint.isCompleted;
    this.isDetails = this.waypoint.isDetails;
  }
};
