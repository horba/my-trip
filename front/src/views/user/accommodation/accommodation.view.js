import { VBtn, VIcon } from 'vuetify/lib';
import { MmtTextInput, MmtStepper, MmtAccommodationCard } from '@components';
import { accommodationGoogleApiMixin } from '@mixins';
import { mapState, mapGetters } from 'vuex';

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
      mapSelector: 'map-holder',
      sortInfo: {
        sortBy: 0,
        sortDirection: 0
      },
      changedPage: 1
    };
  },
  computed: {
    ...mapState('accommodations', [ 'paginationInfo' ]),
    ...mapGetters('dictionaries', [ 'accommodationSorting' ]),
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
    onQueryCange () {
      this.$store.dispatch('accommodations/fetchAccommodations',
        { pageNumber: this.changedPage - 1, ...this.sortInfo });
    }
  },
  async mounted () {
    this.onQueryCange();
  }
};
