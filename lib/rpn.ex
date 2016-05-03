defmodule RPN do
  @moduledoc """
  In reverse Polish notation the operators follow their operands;
  for instance, to add 3 and 4, one would write "3 4 +" rather than "3 + 4".
  If there are multiple operations, the operator is given immediately after its second operand;
  so the expression written "3 - 4 + 5" in conventional notation would be written "3 4 - 5 +" in RPN: 4 is first subtracted from 3, then 5 added to it.
  An advantage of RPN is that it obviates the need for parentheses that are required by infix.
  While "3 - 4 * 5" can also be written "3 - (4 * 5)", that means something quite different from "(3 - 4) * 5".
  In postfix, the former could be written "3 4 5 * -", which unambiguously means "3 (4 5 *) -" which reduces to "3 20 -";
  the latter could be written "3 4 - 5 *" (or 5 3 4 - *, if keeping similar formatting), which unambiguously means "(3 4 -) 5 *".
  Taken from http://en.wikipedia.org/wiki/Reverse_Polish_notation.
  """
  @binary_ops ~w(+ - / * ^)
  @unary_ops ~w(+ - sqrt ln)
  @ops @binary_ops ++ @unary_ops

  @doc """
  Parses string with reverse Polish notation and calculate a result

  ## Examples

        iex> RPN.parse "5 3 4 - *"
        -5.0

  """
  def parse(str) do
    str |> String.split(" ") |> Enum.reduce([], &convert_rpn(&1, &2)) |> hd
  end

  defp convert_rpn(op, [a, b | tail]) when op in @binary_ops do
    case op do
      "+" -> [b+a | tail]
      "-" -> [b-a | tail]
      "*" -> [b*a | tail]
      "/" -> [b/a | tail]
      "^" -> [:math.pow(b, a) | tail]
    end
  end

  defp convert_rpn(op, [a | tail]) when op in @unary_ops do
    case op do
      "+"    -> [a | tail]
      "-"    -> [-a | tail]
      "sqrt" -> [:math.sqrt(a) | tail]
      "ln"   -> [:math.log(a) | tail]
    end
  end

  defp convert_rpn(op, _) when op in @ops do
    raise ArgumentError, message: "insufficient arguments count for #{op}"
  end

  defp convert_rpn(num_str, acc) do
    number = case Float.parse(num_str) do
      {num, _} -> num
      :error -> raise ArgumentError, message: "#{num_str} is not a number"
    end
    [number | acc]
  end
end
