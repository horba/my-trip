import { VSelect } from 'vuetify/lib';

export default {
  name: 'mmt-select',
  components: {
    VSelect
  },
  data () {
    return {
      selected: ''
    };
  },
  props: {
    mmtItem: {
      required: false,
      type: Array,
      default: () => { return []; }
    },
    mmtLabel: {
      required: false,
      type: String,
      default: ''
    },
    mmtValue: {
      required: false,
      type: String,
      default: ''
    }
  },
  methods: {
    change () {
      this.$emit('change', this.selected);
    }
  }
};
