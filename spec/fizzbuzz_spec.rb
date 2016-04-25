require 'fizzbuzz'

describe FizzBuzz do

  describe '.play' do

    DIV_BY_3 = 'Fizz'.freeze
    DIV_BY_5 = 'Buzz'.freeze
    DIV_BY_3_5 = 'FizzBuzz'.freeze

    it 'prints up to 15 correctly' do

      expect(FizzBuzz.play).to start_with([
        1, 2, DIV_BY_3, 4, DIV_BY_5,
        DIV_BY_3, 7, 8, DIV_BY_3, DIV_BY_5,
        11, DIV_BY_3, 13, 14, DIV_BY_3_5
      ].join(' '))

    end

    it 'prints 100 entries' do
      expect(FizzBuzz.play.split(' ').length).to eq 100
    end

    it 'prints the last 11 correctly' do

      expect(FizzBuzz.play).to end_with([
        DIV_BY_3_5, 91, 92, DIV_BY_3, 94,
        DIV_BY_5, DIV_BY_3, 97, 98, DIV_BY_3,
        DIV_BY_5
      ].join(' '))

    end

  end
  
end
