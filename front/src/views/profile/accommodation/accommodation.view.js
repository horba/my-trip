import { VBtn, VIcon } from 'vuetify/lib';
import { MmtTextInput, MmtStepper, MmtAccommodationCard } from '@components';
import { accommodationGoogleApiMixin } from '@mixins';

export default {
  mixins: [ accommodationGoogleApiMixin ],
  components: {
    VBtn,
    VIcon,
    MmtStepper,
    MmtTextInput,
    MmtAccommodationCard
  },
  data () {
    return {
      selectedAccommodation: null,
      mapSelector: 'map-holder'
    };
  },
  computed: {
    accommodations () {
      return this.$store.state.accommodations.accommodations;
    }
  },
  methods: {
    viewAccommodation (accommodation) {
      if (this.selectedAccommodation?.id !== accommodation.id) {
        this.findPlace(accommodation.address);
        this.selectedAccommodation = accommodation;
      }
    }
  },
  async mounted () {
    await this.$store.dispatch('accommodations/initAccommodations');
  }
};
