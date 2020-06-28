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
  methods: {
    updateCompletedState () {
      this.$store.dispatch('waypoints/switchCompletedState', this.waypoint.id);
    },
    updateDetailsState () {
      this.$store.dispatch('waypoints/switchDetailsState', this.waypoint.id);
    },
    deleteWaypoint () {
      this.$store.dispatch('waypoints/deleteWaypoint', this.waypoint.id);
    }
  }
};
