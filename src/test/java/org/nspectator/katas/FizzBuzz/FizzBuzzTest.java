package org.nspectator.katas.FizzBuzz;

import org.junit.Test;

import static org.hamcrest.CoreMatchers.equalTo;
import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.core.Is.*;

/*
For a given natural number greater than zero return:

* "fizz" if the number is dividable by 3
* "buzz" if the number is dividable by 5
* "fizzbuzz" if the number is dividable by 15
* the same number if no other requirement is fulfilled
 */
public class FizzBuzzTest {

    @Test
    public void getResultShouldReturnFizzIfTheNumberIsDividableBy3() {
        assertThat("fizz", is(equalTo(FizzBuzz.getResult(3))));
    }

    @Test
    public void getResultShouldReturnBuzzIfTheNumberIsDividableBy5() {
        assertThat("buzz", is(equalTo(FizzBuzz.getResult(5))));
        assertThat("buzz", is(equalTo(FizzBuzz.getResult(10))));
    }

    @Test
    public void getResultShouldReturnBuzzIfTheNumberIsDividableBy15() {
        assertThat("fizzbuzz", is(equalTo(FizzBuzz.getResult(15))));
        assertThat("fizzbuzz", is(equalTo(FizzBuzz.getResult(30))));
    }

    @Test
    public void getResultShouldReturnTheSameNumberIfNoOtherRequirementIsFulfilled() {
        assertThat("1", is(equalTo(FizzBuzz.getResult(1))));
        assertThat("2", is(equalTo(FizzBuzz.getResult(2))));
        assertThat("4", is(equalTo(FizzBuzz.getResult(4))));
    }
}
