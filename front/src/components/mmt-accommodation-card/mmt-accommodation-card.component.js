import {
  VCard, VCardTitle, VCardSubtitle, VCardText,
  VCarousel, VCarouselItem, VImg,
  VRating, VIcon
} from 'vuetify/lib';
const { baseUrl } = require('@/config/config.dev.json');
const { SERVER_ACCOMODATIONS_PATH } = require('@constants');

export default {
  name: 'mmt-accommodation-card',
  components: {
    VCard,
    VCardTitle,
    VCardSubtitle,
    VCardText,
    VCarousel,
    VCarouselItem,
    VImg,
    VRating,
    VIcon
  },
  props: [ 'accommodation' ],
  methods: {
    getFilePath (fileName) {
      return `${baseUrl}/${SERVER_ACCOMODATIONS_PATH}/${fileName}`;
    }
  }
};
