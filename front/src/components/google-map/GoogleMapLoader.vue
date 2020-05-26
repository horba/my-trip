<template>
  <div>
    <div class="google-map" ref="googleMap"></div>
    <!-- eslint-disable-next-line vue/this-in-template -->
    <template v-if="Boolean(this.google) && Boolean(this.map)">
      <slot :google="google" :map="map" />
    </template>
  </div>
</template>

<script>
import GoogleMapsApiLoader from 'google-maps-api-loader';

export default {
  props: {
    mapConfig: Object,
    apiKey: String
  },
  data () {
    return {
      google: null,
      map: null,
      center: null
    };
  },
  async mounted () {
    const googleMapApi = await GoogleMapsApiLoader({
      libraries: [ 'places' ],
      apiKey: this.apiKey
    });
    this.google = googleMapApi;
    this.initializeMap();
    this.setCurrentPosition(this.map);
  },
  methods: {
    initializeMap () {
      const mapContainer = this.$refs.googleMap;
      this.map = new this.google.maps.Map(mapContainer, this.mapConfig);
    },
    setCurrentPosition (map) {
      if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(this.setMapCenter);
      } else {
        this.setMapCenter();
      }
    },
    setMapCenter (position) {
      if (position) {
        const pos = {
          lat: position.coords.latitude,
          lng: position.coords.longitude
        };
        this.center = pos;
        this.map.setCenter(pos);
      } else {
        this.map.setCenter({ lat: 48.459286, lng: 35.052698 });
      }
    }
  }
};
</script>

<style scoped>
.google-map {
  width: 100%;
  min-height: 100%;
}
</style>
