<script>
import { LINE_PATH_CONFIG } from '@constants';

export default {
  props: {
    google: {
      type: Object,
      required: true
    },
    map: {
      type: Object,
      required: true
    },
    path: {
      type: Array,
      required: true
    }
  },
  mounted () {
    const { Polyline } = this.google.maps;
    // eslint-disable-next-line no-new
    new Polyline({
      path: this.path,
      map: this.map,
      ...LINE_PATH_CONFIG
    });
  },
  render () { return null; }
};
</script>
