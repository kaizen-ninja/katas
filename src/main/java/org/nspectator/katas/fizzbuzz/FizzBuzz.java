package org.nspectator.katas.fizzbuzz;

import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

/**
 * Created by user on 31.10.16.
 */
public class FizzBuzz {
	public Boolean isFizz(Integer n) {
		return n % 3 == 0;
	}

	public Boolean isBuzz(Integer n) {
		return n % 5 == 0;
	}

	public Boolean isFizzBuzz(Integer n) {
		return n % 3 == 0 && n % 5 == 0;
	}

	public List<String> print(List<Integer> numbers) {
		return numbers.stream().map(n -> {
			if (this.isFizzBuzz(n))
				return "fizzbuzz";
			if (this.isBuzz(n)) {
				return "buzz";
			}
			if (this.isFizz(n)) {
				return "fizz";
			}
			return n.toString();
		}).collect(Collectors.toList());
	}

	public static void main(String[] args) {
		FizzBuzz solution = new FizzBuzz();
		List<Integer> numbers = IntStream.rangeClosed(1, 100).boxed().collect(Collectors.toList());
		solution.print(numbers).forEach(System.out::println);
	}
}
