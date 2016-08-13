package org.nspectator.fizzbuzz

import org.specs2.mutable.Specification

trait FizzBuzzSpec extends Specification {
  val fizzbuzz: FizzBuzz

  "numbers dividable by 3" should {
    "returns fizz" in {
      fizzbuzz.getResult(3) must be_==("fizz")
      fizzbuzz.getResult(6) must be_==("fizz")
    }
  }

  "numbers dividable by 5" should {
    "returns buzz" in {
      fizzbuzz.getResult(5) must be_==("buzz")
      fizzbuzz.getResult(10) must be_==("buzz")
    }
  }

  "numbers dividable by 15" should {
    "returns fizzbuzz" in {
      fizzbuzz.getResult(15) must be_==("fizzbuzz")
      fizzbuzz.getResult(30) must be_==("fizzbuzz")
    }
  }

  "when no other requirement is fulfilled" should {
    "returns the same number" in {
      fizzbuzz.getResult(1) must be_==("1")
      fizzbuzz.getResult(2) must be_==("2")
      fizzbuzz.getResult(4) must be_==("4")
    }
  }

}

class FizzBuzz1Spec extends FizzBuzzSpec {
  override val fizzbuzz = new FizzBuzz1
}

class FizzBuzz2Spec extends FizzBuzzSpec {
  override val fizzbuzz = new FizzBuzz2
}