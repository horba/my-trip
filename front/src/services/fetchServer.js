import store from '@store';

export const fetchServer = () => {
  store.dispatch('userSettings/loadUserSettings');
};
