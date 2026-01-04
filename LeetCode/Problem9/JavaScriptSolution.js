/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
  var s = '' + x;
  for (var pos = 0; pos < s.length / 2; pos++) {
    var end = s.length - pos - 1;
    if (s[pos] != s[end]) {
      return false;
    }
  }

  return true;
};
