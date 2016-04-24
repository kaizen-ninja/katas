describe("FizzBuzz kata and variants", function() {

    describe("With basic FizzBuzz kata and function fizbuzzTo(limit)", function() {

        it("should show [1, 2] when fizzbuzzing to 2", function() {
            result = fizbuzzTo(2);
            expect(result).toEqual([1, 2]);

        });

        it("should show [1, 2, Fizz] when fizzbuzzing to 3", function() {
            result = fizbuzzTo(3);
            expect(result).toEqual([1, 2, "Fizz"]);

        });

        it("should show [1, 2, Fizz, 4, Buzz] when fizzbuzzing to 5", function() {
            result = fizbuzzTo(5);
            expect(result).toEqual([1, 2, "Fizz", 4, "Buzz"]);

        });

        it("should show [1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, Whizz] when fizzbuzzing to 14", function() {
            result = fizbuzzTo(14);
            expect(result).toEqual([1, 2, "Fizz", 4, "Buzz", "Fizz", "Whizz", 8, "Fizz", "Buzz", 11, "Fizz", 13, "Whizz"]);

        });

        /* It's borong writting all the result list so I watch only the value that has something special
         */
        it("should end with FizzBuzz when fizzbuzzing to 15", function() {
            result = fizbuzzTo(15);
            expect(result[14]).toEqual("FizzBuzz");

        });

        it("should end with FizzBuzz when fizzbuzzing to 30", function() {
            result = fizbuzzTo(30);
            expect(result[29]).toEqual("FizzBuzz");

        });

    });


    describe("With variant 7 = 'Whizz' and function fizbuzzTo(limit)", function() {

        it("should return [1, 2, Fizz, 4, Buzz, Fizz, Whizz] when fizzbuzzing to 2", function() {
            result = fizbuzzTo(7);
            expect(result).toEqual([1, 2, "Fizz", 4, "Buzz", "Fizz", "Whizz"]);

        });

        it("should end with FizzWhizz when fizzbuzzing to 21", function() {
            result = fizbuzzTo(21);
            expect(result[20]).toEqual("FizzWhizz");

        });

    });

    describe("With console-output variant and hand-made monkey patch", function() {
        var number_list = [];

        function fakelog(param) {
            number_list.push(param);
        }

        beforeEach(function() {
            this.original = console.log;
            console.log = fakelog;
        });

        afterEach(function() {
            console.log = this.original

        });

        it("should send [1, 2, Fizz, 4, Buzz] to console when fizzbuzzing to 5", function() {
            fizzbuzz_toconsole();
            expect(number_list).toEqual([1, 2, 'Fizz', 4, 'Buzz']);

        });
    });

    describe("With console-output variant and spying the console with jasmine", function() {

        beforeEach(function() {
            spyOn(console, 'log');
        });

        it("should send [1, 2, Fizz, 4, Buzz] to console when fizzbuzzing to 5", function() {
            fizzbuzz_toconsole();
            expect(console.log).toHaveBeenCalled();
            expect(console.log.calls.allArgs()).toEqual([
                [1],
                [2],
                ['Fizz'],
                [4],
                ['Buzz']
            ]);

        });
    });

}); // kata