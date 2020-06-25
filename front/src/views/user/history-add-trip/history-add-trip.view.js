import { MmtTextInput } from '@components';
import { requiredValidationMixin } from '@mixins';
import { mapGetters } from 'vuex';

export default {
  mixins: [
    requiredValidationMixin
  ],
  components: {
    MmtTextInput
  },
  data () {
    return {
      newTripValues: {
        departureDate: this.$options.filters.date(new Date(), 'yyyy-MM-dd'),
        arrivalDate: this.$options.filters.date(new Date(), 'yyyy-MM-dd'),
        departureTime: this.$options.filters.date(new Date(), 'HH:mm'),
        arrivalTime: this.$options.filters.date(new Date(), 'HH:mm'),
        currency: 'USD',
        departureCountryId: null,
        arrivalCountryId: null
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
    ...mapGetters('dictionaries', ['genders', 'countries', 'languages'])
  },
  methods: {
    createNewTrip () {
      this.$refs.form.validate();
      if (!this.formValidity) {
        return;
      }
      this.$store.dispatch('trip/createNewTrip', {
        departureCountryId: this.newTripValues.departureCountryId,
        departureCity: this.newTripValues.departureCity,
        departureDate: `${this.newTripValues.departureDate}T${this.newTripValues.departureTime}Z`,
        arrivalCountryId: this.newTripValues.arrivalCountryId,
        arrivalCity: this.newTripValues.arrivalCity,
        arrivalDate: `${this.newTripValues.arrivalDate}T${this.newTripValues.arrivalTime}Z`,
        totalPrice: +this.newTripValues.totalPrice,
        currency: this.newTripValues.currency,
        flightTime: this.newTripValues.flightTime,
        transplantTime: this.newTripValues.transplantTime,
        differenceInTime: this.newTripValues.differenceInTime
      })
        .then(() => this.$router.push({ name: 'MyHistoryNext' }));
    }
  }
};
