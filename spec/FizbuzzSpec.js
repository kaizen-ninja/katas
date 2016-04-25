/* global describe, it, beforeEach, afterEach */
/* eslint import/no-unresolved: 0, no-console: 0, prefer-arrow-callback: 0 */

var FizzBuzz = require("../src/FizzBuzz");
var chai = require("chai");
var sinonChai = require("sinon-chai");
var sinon = require("sinon");

chai.use(sinonChai);
var expect = chai.expect;

describe("FizzBuzz kata and variants", function() {
  describe("With basic FizzBuzz kata and function fizbuzzTo(limit)", function() {
    it("should show [1, 2] when fizzbuzzing to 2", function() {
      var result = FizzBuzz.fizbuzzTo(2);
      expect(result).to.eql([1, 2]);
    });

    it("should show [1, 2, Fizz] when fizzbuzzing to 3", function() {
      var result = FizzBuzz.fizbuzzTo(3);
      expect(result).to.eql([1, 2, "Fizz"]);
    });

    it("should show [1, 2, Fizz, 4, Buzz] when fizzbuzzing to 5", function() {
      var result = FizzBuzz.fizbuzzTo(5);
      expect(result).to.eql([1, 2, "Fizz", 4, "Buzz"]);
    });

    /* eslint max-len: 0 */
    it("should show [1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, Whizz] when fizzbuzzing to 14", function() {
      var result = FizzBuzz.fizbuzzTo(14);
      expect(result).to.eql(
        [1, 2, "Fizz", 4, "Buzz", "Fizz", "Whizz", 8, "Fizz", "Buzz", 11, "Fizz", 13, "Whizz"]
      );
    });

    /* It"s borong writting all the result list so I watch only the value that has something special
     */
    it("should end with FizzBuzz when fizzbuzzing to 15", function() {
      var result = FizzBuzz.fizbuzzTo(15);
      expect(result[14]).to.eql("FizzBuzz");
    });

    it("should end with FizzBuzz when fizzbuzzing to 30", function() {
      var result = FizzBuzz.fizbuzzTo(30);
      expect(result[29]).to.eql("FizzBuzz");
    });
  });


  describe("With variant 7 = \"Whizz\" and function fizbuzzTo(limit)", function() {
    it("should return [1, 2, Fizz, 4, Buzz, Fizz, Whizz] when fizzbuzzing to 2", function() {
      var result = FizzBuzz.fizbuzzTo(7);
      expect(result).to.eql([1, 2, "Fizz", 4, "Buzz", "Fizz", "Whizz"]);
    });

    it("should end with FizzWhizz when fizzbuzzing to 21", function() {
      var result = FizzBuzz.fizbuzzTo(21);
      expect(result[20]).to.eql("FizzWhizz");
    });
  });

  describe("With console-output variant and hand-made monkey patch", function() {
    var numberList = [];
    function fakelog(param) {
      numberList.push(param);
    }
    beforeEach(function() {
      this.original = console.log;
      console.log = fakelog;
    });

    afterEach(function() {
      console.log = this.original;
    });

    it("should send [1, 2, Fizz, 4, Buzz] to console when fizzbuzzing to 5", function() {
      FizzBuzz.fizzbuzz_toconsole();
      expect(numberList).to.eql([1, 2, "Fizz", 4, "Buzz"]);
    });
  });

  describe("With console-output variant and spying the console with jasmine", function() {
    beforeEach(function() {
      sinon.spy(console, "log");
    });

    afterEach(function() {
      console.log.restore();
    });

    it("should send [1, 2, Fizz, 4, Buzz] to console when fizzbuzzing to 5", function() {
      FizzBuzz.fizzbuzz_toconsole();
      expect(console.log).to.be.called;
      expect(console.log.args).to.eql([
        [1],
        [2],
        ["Fizz"],
        [4],
        ["Buzz"]
      ]);
    });
  });
});
