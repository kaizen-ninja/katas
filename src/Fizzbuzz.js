IDontKnow = "";

/**
Too many methods. Encapsulate them in a data structure
*/
function valueFilter(value, number, result, previous) {
    if ((value % number) == 0)
        return previous + result;
    return previous;
}


function numFilter(value, result) {
    if (result == IDontKnow)
        return value;
    return result;
}

function fizbuzzTo(limit) {
    values = []
    for (var i = 1; i <= limit; i++) {
        result = valueFilter(i, 3, "Fizz", IDontKnow);
        result = valueFilter(i, 5, "Buzz", result);
        result = valueFilter(i, 7, "Whizz", result);
        result = numFilter(i, result);
        values.push(result);
    };
    return values;
}

/**
	Bad version. Works fine but the code is a mess
	I use this version to do mockey patch and mocking the console during testing
**/

function fizzbuzz_toconsole() {
    function generate(input) {
        return ((fizz(input) && buzz(input) && 'FizzBuzz') ||
            fizz(input) || buzz(input)) || input;

        function fizz(input) {
            return ((input % 3) === 0) ? 'Fizz' : false;
        }

        function buzz(input) {
            return ((input % 5) === 0) ? 'Buzz' : false;
        }
    }

    var i;
    for (i = 1; i <= 5; i++) {
        console.log(generate(i));
    }
}