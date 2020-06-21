import { MmtTextInput } from '@components';
import { requiredValidationMixin } from '@mixins';
import { mapGetters } from 'vuex';

export default {
  props: ['id', 'wpId'],
  mixins: [
    requiredValidationMixin
  ],
  components: {
    MmtTextInput
  },
  data () {
    return {
      newWpValues: {
        departureDate: this.$options.filters.date(new Date(), 'yyyy-MM-dd'),
        arrivalDate: this.$options.filters.date(new Date(), 'yyyy-MM-dd'),
        departureTime: this.$options.filters.date(new Date(), 'HH:mm'),
        arrivalTime: this.$options.filters.date(new Date(), 'HH:mm'),
        transport: 0
      },
      calendarLocale: {
        'header-date-format': dt => this.$options.filters.date(dt, 'LLL yyyy'),
        'month-format': dt => this.$options.filters.date(dt, 'LLL'),
        'title-date-format': dt => this.$options.filters.date(dt, 'iiiiii LLL dd'),
        'weekday-format': dt => this.$options.filters.date(dt, 'EEEEEE')
      },
      formValidity: false
    };
  },
  computed: {
    ...mapGetters('dictionaries', [ 'transportTypes' ]),
    isEditForm () {
      return this.$route.name === 'MyHistoryEditRoute';
    }
  },
  methods: {
    createWaypoint () {
      this.$store.dispatch(
        this.isEditForm ? 'waypoints/updateWaypoint' : 'waypoints/insertWaypoint', {
          departureCity: this.newWpValues.departureCity,
          departureDate: `${this.newWpValues.departureDate}T${this.newWpValues.departureTime}Z`,
          arrivalCity: this.newWpValues.arrivalCity,
          arrivalDate: `${this.newWpValues.arrivalDate}T${this.newWpValues.arrivalTime}Z`,
          pathLength: +this.newWpValues.pathLength,
          pathTime: this.newWpValues.pathTime,
          details: this.newWpValues.details,
          transport: this.newWpValues.transport,
          tripId: +this.id,
          newId: +this.wpId || 0
        });
      this.$router.push({ name: 'MyHistoryFututeRoute' });
    }
  },
  created () {
    if (this.isEditForm) {
      this.$store.dispatch('waypoints/loadWaypoints', [ +this.id ])
        .then(() => {
          const wps = this.$store.state.waypoints.waypoints,
                currentWp = wps.find(wp => wp.id === +this.wpId),
                nextWp = wps[wps.findIndex(wp => wp === currentWp) + 1];

          this.newWpValues.departureCity = currentWp.city;
          this.newWpValues.departureDate
          = this.$options.filters.date(currentWp.departureDate, 'yyyy-MM-dd');
          this.newWpValues.departureTime
          = this.$options.filters.date(currentWp.departureDate, 'HH:mm');

          this.newWpValues.arrivalCity = nextWp.city;
          this.newWpValues.arrivalDate
          = this.$options.filters.date(currentWp.arrivalDate, 'yyyy-MM-dd');
          this.newWpValues.arrivalTime
          = this.$options.filters.date(currentWp.arrivalDate, 'HH:mm');

          this.newWpValues.pathLength = currentWp.pathLength;
          this.newWpValues.pathTime = `${currentWp.pathTime.hours}:${currentWp.pathTime.minutes}`;
          this.newWpValues.details = currentWp.details;
          this.newWpValues.transport = currentWp.transport;

          this.$forceUpdate();
        });
    }
  }
};
