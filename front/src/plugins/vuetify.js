import Vue from 'vue';
import Vuetify from 'vuetify/lib';

Vue.use(Vuetify);

export default new Vuetify({
  icons: {
    iconfont: 'mdi'
  },
  theme: {
    themes: {
      light: {
        primary:
        {
          base: '#2962FF',
          lighten1: '#1565C0',
          lighten2: '#6200EA',
          lighten3: '#F6F4F4',
          lighten4: '#DDDDDD',
          lighten5: '#E5E5E5',
          lighten6: '#C4C4C4',
          lighten7: '#FFFFFF'
        },
        secondary:
        {
          base: '#2962FF'
        },
        success: {
          base: '#00C853',
          lighten1: '#2AEE7B'
        },
        error: {
          base: '#EF0000'
        },
        accent: {
          base: '#4DD0E1',
          lighten1: '#03A9F4',
          lighten2: '#6C6C6C'
        }
      },
      options: {
        customProperties: true
      },
      dark: false
    }
  }
});
