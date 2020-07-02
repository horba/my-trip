const EMAIL_REGEX = '^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$',
  // test1@users.com
      LINK_REGEX = '^((?:https?:)?(?:\\/{2})?)?((?:[\\w]{1,64})\\.(?:[\\w\\.]{2,64}))'
    + '(:\\d{2,6})?((?:\\/|\\?|#|&){1}(?:[\\w\\d\\S]+)?)?$';
// http://example.com
// https://example.com/qwerty/1/:22/0

export {
  EMAIL_REGEX,
  LINK_REGEX
};
