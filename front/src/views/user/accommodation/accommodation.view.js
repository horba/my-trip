import { VBtn, VIcon } from 'vuetify/lib';
import { MmtTextInput, MmtStepper, MmtAccommodationCard } from '@components';
import { accommodationGoogleApiMixin } from '@mixins';
import { mapState } from 'vuex';

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
    ...mapState('accommodations', [ 'paginationInfo' ]),
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
    },
    onPaginationChange (page) {
      this.$store.dispatch('accommodations/fetchAccommodations', page - 1);
    }
  },
  async mounted () {
    await this.$store.dispatch('accommodations/fetchAccommodations', 0);
  }
};
