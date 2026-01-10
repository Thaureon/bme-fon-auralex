function isPalindrome(x: number): boolean {
  let s: string = x.toString();
  for (let pos: number = 0; pos < s.length / 2; pos++) {
    let end: number = s.length - pos - 1;
    if (s[pos] != s[end]) {
      return false;
    }
  }
  return true;
}
