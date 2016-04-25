/* eslint no-console: 0 */
var IDontKnow = "";

/**
Too many methods. Encapsulate them in a data structure
*/
function valueFilter(value, number, result, previous) {
  return (value % number) === 0 ? (previous + result) : previous;
}

function numFilter(value, result) {
  return result === IDontKnow ? value : result;
}

function fizbuzzTo(limit) {
  var values = [];
  var result;
  for (var i = 1; i <= limit; i++) {
    result = valueFilter(i, 3, "Fizz", IDontKnow);
    result = valueFilter(i, 5, "Buzz", result);
    result = valueFilter(i, 7, "Whizz", result);
    result = numFilter(i, result);
    values.push(result);
  }
  return values;
}

/**
	Bad version. Works fine but the code is a mess
	I use this version to do mockey patch and mocking the console during testing
**/

function fizzbuzzToconsole () {
  function generate(input) {
    function fizz(input) {
      return ((input % 3) === 0) ? "Fizz" : false;
    }

    function buzz(input) {
      return ((input % 5) === 0) ? "Buzz" : false;
    }

    return ((fizz(input) && buzz(input) && "FizzBuzz") ||
      fizz(input) || buzz(input)) || input;
  }

  var i;
  for (i = 1; i <= 5; i++) {
    console.log(generate(i));
  }
}

/* eslint object-shorthand: 0 */
module.exports = {
  valueFilter: valueFilter,
  numFilter: numFilter,
  fizbuzzTo: fizbuzzTo,
  fizzbuzz_toconsole: fizzbuzzToconsole
};
