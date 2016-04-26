#include "katas_test.h"

class FizzBuzz {
public:
    static std::string getResult(int number) {
        if (number % 15 == 0) return "fizzbuzz";
        else if (number % 3 == 0) return "fizz";
        else if (number % 5 == 0) return "buzz";
        return to_string(number);
    }
};

Context(FizzBuzz_Kata) {

    Spec(ResultShouldReturnFizzIfTheNumberIsDividableBy3)
    {
        Assert::That("fizz", Is().EqualTo(FizzBuzz::getResult(3)));
    }

    Spec(ResultShouldReturnBuzzIfTheNumberIsDividableBy5)
    {
        Assert::That("buzz", Is().EqualTo(FizzBuzz::getResult(5)));
        Assert::That("buzz", Is().EqualTo(FizzBuzz::getResult(10)));
    }

    Spec(ResultShouldReturnBuzzIfTheNumberIsDividableBy15)
    {
        Assert::That("fizzbuzz", Is().EqualTo(FizzBuzz::getResult(15)));
        Assert::That("fizzbuzz", Is().EqualTo(FizzBuzz::getResult(30)));
    }

    Spec(ResultShouldReturnTheSameNumberIfNoOtherRequirementIsFulfilled)
    {
        Assert::That("1", Is().EqualTo(FizzBuzz::getResult(1)));
        Assert::That("2", Is().EqualTo(FizzBuzz::getResult(2)));
        Assert::That("4", Is().EqualTo(FizzBuzz::getResult(4)));
    }
};