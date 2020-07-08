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
      changedPage: 1,
      filters: {
        countries: [],
        year: null,
        price: [0, Number.MAX_VALUE],
        isPriceChosen: false
      }
    };
  },
  computed: {
    ...mapState('accommodations', ['paginationInfo', 'maxPrice']),
    ...mapGetters('dictionaries', [ 'accommodationSorting' ]),
    countries () {
      return this.$store.getters['dictionaries/countries']
        .filter(country => country.value !== null);
    },
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
    onFilterUpdate () {
      this.changedPage = 1;
      this.updateQuery();
    },
    updateQuery () {
      this.$store.dispatch('accommodations/fetchAccommodations',
        {
          pageNumber: this.changedPage - 1,
          ...this.sortInfo,
          minPrice: this.filters.isPriceChosen ? this.filters.price[0] : undefined,
          maxPrice: this.filters.isPriceChosen ? this.filters.price[1] : undefined,
          year: this.filters.year,
          countries: this.filters.countries.reduce((acc, id) => `${acc}${id};`, '')
        });
    }
  },
  async mounted () {
    this.updateQuery();
    this.$store.dispatch('accommodations/loadMaxPrice');
  }
};
