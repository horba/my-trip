import { VAvatar } from 'vuetify/lib';

export default {
  name: 'mmt-avatar',
  props: {
    src: '',
    size: ''
  },
  components: {
    VAvatar
  },
  mounted () {
    this.size = this.size || 48;
  }
};
