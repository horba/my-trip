import { MmtTextInput } from '@components';
import { requiredValidationMixin, timeValidationMixin, dateValidationMixin } from '@mixins';
import { mapGetters } from 'vuex';

export default {
  mixins: [
    requiredValidationMixin,
    timeValidationMixin,
    dateValidationMixin
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
        ...this.newTripValues,
        departureDate: `${this.newTripValues.departureDate}T${this.newTripValues.departureTime}Z`,
        arrivalDate: `${this.newTripValues.arrivalDate}T${this.newTripValues.arrivalTime}Z`,
        totalPrice: +this.newTripValues.totalPrice
      })
        .then(() => this.$router.push({ name: 'MyHistoryNext' }));
    }
  }
};
