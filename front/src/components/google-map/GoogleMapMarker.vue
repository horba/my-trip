<script>
import { POINT_MARKER_ICON_CONFIG } from '@constants';

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
    marker: {
      type: Object,
      required: true
    }
  },
  mounted () {
    const { Marker } = this.google.maps;
    // eslint-disable-next-line no-new
    new Marker({
      position: this.marker.position,
      marker: this.marker,
      map: this.map,
      icon: POINT_MARKER_ICON_CONFIG
    });
  },
  render () { return null; }
};
</script>
