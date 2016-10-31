package org.nspectator.katas.fizzbuzz

import spock.lang.Specification

/**
 * Created by user on 31.10.16.
 */
class FizzBuzzSpec extends Specification {
	def "trivial check"() {
		given:
			def solution = new FizzBuzz()
		expect:
			solution != null
	}

	def "check if solution finds fizzs"() {
		given:
			def solution = new FizzBuzz()
		expect:
			answer == solution.isFizz(number)
		where:
			number	|	answer
			1		|	false
			2		|	false
			3		|	true
			5		|	false
			6		|	true
			15		|	true
	}

	def "check if solution finds buzzs"() {
		given:
			def solution = new FizzBuzz()
		expect:
			answer == solution.isBuzz(number)
		where:
			number	|	answer
			1		|	false
			2		|	false
			3		|	false
			5		|	true
			6		|	false
			15		|	true
	}

	def "check if solution findes fizzbuzzs"() {
		given:
			def solution = new FizzBuzz()
		expect:
			answer == solution.isFizzBuzz(number)
		where:
			number	|	answer
			1		|	false
			2		|	false
			3		|	false
			5		|	false
			6		|	false
			15		|	true
			20		|	false
			30		|	true
	}

	def "check if print works in a right manner"() {
		given:
			def solution = new FizzBuzz()
		expect:
			answer == solution.print(numbers)
		where:
			numbers				|	answer
			[1,2,3,4,5,15,20]	|	["1","2","fizz","4","buzz","fizzbuzz","buzz"]
			[1,2,3,4,6,30]		|	["1","2","fizz","4","fizz","fizzbuzz"]
			[1,2,3,4,7,45]		|	["1","2","fizz","4","7","fizzbuzz"]
			[1,2,3,4,8]			|	["1","2","fizz","4","8"]
			[1,2,3,4]			|	["1","2","fizz","4"]
	}
}
