import spock.lang.Specification

class FizzBuzzSpec extends Specification {

	def "1 turns to '1'"() {
		when:
		def output = fizzbuzz(1)

		then:
		output == "1"
	}

	def "2 turns to '2'"() {
		when:
		def output = fizzbuzz(2)

		then:
		output == "2"
	}

	def "98 turns to '98'"() {
		when:
		def output = fizzbuzz(98)

		then:
		output == "98"
	}

	def "3 turns to 'fizz'"() {
		when:
		def output = fizzbuzz(3)

		then:
		output == "fizz"
	}

	def "6 turns to 'fizz'"() {
		when:
		def output = fizzbuzz(6)

		then:
		output == "fizz"
	}


	def "5 turns to 'buzz'"() {
		when:
		def output = fizzbuzz(5)

		then:
		output == "buzz"
	}


	def fizzbuzz(input) {
		[
		  [3, "fizz"],
		  [5, "buzz"],
		  [input, input.toString()]
		].find { input % it[0] == 0 }[1]
	}
}
