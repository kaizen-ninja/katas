defmodule LcdDigitsTest do
  use ExUnit.Case
  doctest LcdDigits

  @lcd_1234567890 """
    _  _     _  _  _  _  _  _ 
  | _| _||_||_ |_   ||_||_|| |
  ||_  _|  | _||_|  ||_| _||_|
""" |> String.strip(?\n)

  test "LcdDigits.number_to_string works" do
    assert LcdDigits.number_to_string(1234567890) == @lcd_1234567890
  end
end
