import { VSelect } from 'vuetify/lib';

export default {
  name: 'mmt-select',
  components: {
    VSelect
  },
  data () {
    return {};
  },
  props: {
    mmtItem: {
      required: false,
      type: [ { text: String, value: String } ],
      default: () => { return [ { text: '', value: '' } ]; }
    }
  }
};
