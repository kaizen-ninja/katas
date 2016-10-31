# Katas : every day short-time xTDD practice

[![Join the chat at https://gitter.im/nspectator/katas](https://badges.gitter.im/nspectator/katas.svg)](https://gitter.im/nspectator/katas?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

Read short guide: [Learning Test Driven Development with TDD Katas](http://goo.gl/5NYpVI)

## What is the Kata?

[Dave Thomas](https://pragdave.me/) ([@pragdave](https://github.com/pragdave)), co-author of the book The Pragmatic Programmer explained:

"What makes a good practice session? You need time without interruptions, and a simple thing you want to try. You need to try it as many times as it takes, and be comfortable making mistakes. You need to look for feedback each time so you can work to improve. There needs to be no pressure: this is why it is hard to practice in a project environment. it helps to keep it fun: make small steps forward when you can. Finally, you’ll recognize a good practice session because you’ll came out of it knowing more than when you went in.

Code Kata is an attempt to bring this element of practice to software development. A kata is an exercise in karate where you repeat a form many, many times, making little improvements in each. The intent behind code kata is similar. Each is a short exercise (perhaps 30 minutes to an hour long). Some involve programming, and can be coded in many different ways. Some are open ended, and involve thinking about the issues behind programming. These are unlikely to have a single correct answer."

### What`s next

Invest some time in your craft and try Kata in different languages - every language has it`s own branch in this repo.

Feel free to make pull request for adding new katas more frequently.

Remember that the point of the kata is not arriving at a correct answer. The point is the stuff you learn along the way. The goal is the practice, not the solution.

## Branch keeping

There are branches for each technology/language. Currently there are:

| Branch | Language | Test suite | Build Status |
| --- | --- | --- | --- |
| [dotnet/csharp](https://github.com/nspectator/katas/tree/dotnet/csharp) | [C#](http://dotnet.github.io/docs/tutorials/index.html) | [NUnit](http://www.nunit.org/) | [![Build Status](https://ci.appveyor.com/api/projects/status/github/nspectator/katas?branch=dotnet/csharp&svg=true)](https://ci.appveyor.com/project/jonny-novikov/katas/history) |
| [java/junit](https://github.com/nspectator/katas/tree/java/junit) | [java](http://www.oracle.com/technetwork/java/javase/documentation/index.html) | [junit](http://junit.org/) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=java/junit)](https://travis-ci.org/nspectator/katas?branch=java/junit) |
| [java/spock](https://github.com/nspectator/katas/tree/java/spock) | [java](http://www.oracle.com/technetwork/java/javase/documentation/index.html) | [spock](http://spockframework.github.io/spock/docs/1.0/index.html) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=java/spock)](https://travis-ci.org/nspectator/katas?branch=java/spock) |
| [groovy/spock](https://github.com/nspectator/katas/tree/groovy/spock) | [groovy](http://www.groovy-lang.org/) | [spock](http://spockframework.github.io/spock/docs/1.0/index.html) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=groovy/spock)](https://travis-ci.org/nspectator/katas?branch=groovy/spock) |
| [scala/spec2](https://github.com/nspectator/katas/tree/scala/specs2) | [scala](http://www.scala-lang.org/) | [specs2]( http://specs2.org) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=scala/specs2)](https://travis-ci.org/nspectator/katas?branch=scala/specs2) |
| [js/jasmine](https://github.com/nspectator/katas/tree/js/jasmine) | [javascript](http://www.w3schools.com/js/) | [jasmine](http://jasmine.github.io/) |  [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=js/jasmine)](https://travis-ci.org/nspectator/katas?branch=js/jasmine) |
| [js/mocha](https://github.com/nspectator/katas/tree/js/mocha) | [javascript](http://www.w3schools.com/js/) | [mochajs](https://mochajs.org/), [chaijs](http://chaijs.com/) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=js/mocha)](https://travis-ci.org/nspectator/katas?branch=js/mocha) |
| [python/behave](https://github.com/nspectator/katas/tree/python/behave) | [python](https://www.python.org/) | [behave](http://pythonhosted.org/behave/) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=python/behave)](https://travis-ci.org/nspectator/katas?branch=python/behave) |
| [cpp/igloo](https://github.com/nspectator/katas/tree/cpp/igloo) | [C++](http://www.cplusplus.com/) | [igloo](http://igloo-testing.org/) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=cpp/igloo)](https://travis-ci.org/nspectator/katas?branch=cpp/igloo) |
| [ruby/rspec](https://github.com/nspectator/katas/tree/ruby/rspec) | [ruby](https://www.ruby-lang.org) | [rspec](http://rspec.info/) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=ruby/rspec)](https://travis-ci.org/nspectator/katas?branch=ruby/rspec) |
| [elixir/exunit](https://github.com/nspectator/katas/tree/elixir/exunit) | [Elixir](http://elixir-lang.org) | [ExUnit](http://elixir-lang.org/docs/stable/ex_unit/ExUnit.html) | [![Build Status](https://api.travis-ci.org/nspectator/katas.svg?branch=elixir/exunit)](https://travis-ci.org/nspectator/katas?branch=elixir/exunit) |

#### Agreements

* Every branch should contain [How to](howto) section
* Each branch have a working (and test-covered) code which is the result of Kata practice.
That`s why it should be integrated with some continuous integraion server aka [Travis](https://travis-ci.org/nspectator/katas)
or [AppVeyor](https://ci.appveyor.com/project/jonny-novikov/katas)
* You can review code and add your comment on our [Upsource](http://review.nspectator.org) instance

## List of Katas

#### [Bear And Steady Gene Kata](list/BearAndSteadyGene)

Difficulty: Hard

-------------------

#### [String Sum Kata](list/StringSum)

-------------------

#### [String Calculator Kata](list/StringCalculator)

-------------------

#### [BinaryGap Kata](list/BinaryGap)

Difficulty: Medium

-------------------

#### [Bowling Game Kata](list/BowlingGame)

-------------------

#### [Circular primes](list/Circularprimes)

Difficulty: Easy

-------------------

#### [Equi Kata](list/Equi)

Difficulty: Medium

-------------------

#### [FizzBuzz Kata](list/FizzBuzz)

-------------------

#### [OddEven Kata](list/OddEven)

-------------------

#### [PrimeComposite Kata](list/PrimeFactor)

-------------------

#### [Natural Order String Sorting Kata](list/NaturalStringSorting)

-------------------

#### [Berlin Clock Kata](list/BerlinClock)

Difficulty: Easy

-------------------

### [Reverse Polish Notation Kata](list/ReversePolishNotation)

Difficulty: Medium

-------------------

### [Tennis Game Kata](list/TennisGame)

Difficulty: Easy

-------------------

### [Sudoku Kata](list/Sudoku)

Difficulty: Easy

-------------------

#### [Calc Stats Kata](list/CalcStats)

-------------------

#### [Diversion Kata](list/Diversion)

-------------------

#### [Game of Life Kata](list/GameOfLife)

-------------------

#### [Harry Potter Kata](list/HarryPotter)

-------------------

#### [LCD Digits Kata](list/LCD-Digits)

-------------------

#### [Leap Year Kata](list/LeapYear)

-------------------

#### [Mine Fields Kata](list/MineFields)

-------------------

#### [Poker Hands Kata](list/PockerHands)

-------------------

#### [Recently Used List Kata](list/RecentlyUsedList)

-------------------

#### [Reversi Kata](list/Reversi)

-------------------

#### [Yehtzee Game Kata](list/Yehtzee)

-------------------

#### [Word Wrap Kata](list/WordWrap)

-------------------

#### [Dictionary Replacer Kata](list/DictionaryReplacer)

-------------------

#### [Bank OCR Kata](list/BankOCR)

Difficulty: Medium

-------------------

#### [Labyrinth Kata](list/Labyrinth)

Difficulty: Medium

-------------------

#### [A Star Problem](list/AStar)

Difficulty: Hardcore

-------------------

### Katas from [Dave Thomas](https://pragdave.me/)

#### [Supermarket Pricing Kata](list/SupermarketPricing)

-------------------

## Contributing

* [master](https://github.com/nspectator/katas) branch contains <em>list</em> folder with Kata descriptions

* If you want to add new Kata with description then do following steps
    * Create branch with the name of Kata
    * Add folder with Kata name under list folder
    * Fill and review README.md - look at examples
    * Make PR to master

* Want to share your solution?
    * Fork repository
    * Checkout specific branch, e.g. [java/junit](https://github.com/nspectator/katas/tree/java/junit)
    * Create your branch *{kata-name}-{feature-name}*
    * Follow code guidance, add src for new kata or more tests for existing
    * Make PR to branch you have checkout (not master)

* Geek section
    * If you want to add new language support - create {lang}/{test-suite} branch and implement some Katas
    * Make PR to create this new branch in this repo to share with others

We shaped and benefited by hard work from our [contributors](https://github.com/nspectator/katas/contributors).

#### References

* TDD-Kata Practices: http://tddkatas.codeplex.com/
* More: http://codekata.pragprog.com/2007/01/code_kata_backg.html#more
