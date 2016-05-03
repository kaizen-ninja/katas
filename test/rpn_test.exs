defmodule RPNTest do
  use ExUnit.Case
  doctest RPN

  test "addition works" do
    assert RPN.parse("1 1 +") == 2
  end

  test "subtraction works" do
    assert RPN.parse("1 1 -") == 0
  end

  test "unary minus works" do
    assert RPN.parse("1 -") == -1
  end

  test "multiplication works" do
    assert RPN.parse("2 2 *") == 4
  end

  test "division works" do
    assert RPN.parse("20 4 /") == 5
  end

  test "exponentiation works" do
    assert RPN.parse("2 3 ^") == 8
  end

  test "logarithms work" do
    assert RPN.parse("2.718282 ln") - 1 < 1.0e-5
  end

  test "invalid operators return errors" do
    assert_raise ArgumentError, fn -> RPN.parse(".") end
  end

  test "using an operator with insufficient numbers on the stack returns an error" do
    assert_raise ArgumentError, fn -> RPN.parse("1 *") end
  end

  test "some complex expression" do
    assert RPN.parse("5 2 + 7 * sqrt 3 +") == 10.0
  end
end
