<template>
  <google-map-loader
    :map-config="mapConfig"
    api-key="AIzaSyDuiiLqO-HTj8vP0POPrsBGJdWc7esHdOY"
  >
    <template slot-scope="{ google, map }">
      <google-map-marker
        v-for="marker in markers"
        :key="marker.id"
        :marker="marker"
        :google="google"
        :map="map"
      />
      <google-map-line
        v-for="line in lines"
        :key="line.id"
        :path.sync="line.path"
        :google="google"
        :map="map"
      />
    </template>
  </google-map-loader>
</template>

<script>
import { GoogleMapLoader, GoogleMapMarker, GoogleMapLine } from '@components';
import { mapSettings } from '@constants';

export default {
  components: {
    GoogleMapLoader,
    GoogleMapMarker,
    GoogleMapLine
  },
  data () {
    return {
      markers: [],
      lines: []
    };
  },
  computed: {
    mapConfig () {
      return {
        ...mapSettings,
        zoom: 13
      };
    }
  }
};
</script>
