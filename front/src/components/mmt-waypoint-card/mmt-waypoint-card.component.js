export default {
  data () {
    return {
      iconMap: [
        'mdi-airplane',
        'mdi-train',
        'mdi-bus',
        'mdi-car',
        'mdi-bicycle'
      ]
    };
  },
  props: {
    lastCard: {
      type: Boolean,
      default: false
    },
    firstCard: {
      type: Boolean,
      default: false
    },
    waypoint: {
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
