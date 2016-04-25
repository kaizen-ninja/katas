class FizzBuzz {
    def getResult(input) {
		[
		  [3, "fizz"],
		  [5, "buzz"],
		  [input, input.toString()]
		].find { input % it[0] == 0 }[1]
	}
}