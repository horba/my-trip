export default {
  props: {
    transfer: {
      type: Object,
      required: true
    }
  },
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
  }
};
