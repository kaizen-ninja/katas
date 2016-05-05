defmodule LcdDigits do
  @digits %{
    ?1 => ["   ", "  |", "  |"],
    ?2 => [" _ ", " _|", "|_ "],
    ?3 => [" _ ", " _|", " _|"],
    ?4 => ["   ", "|_|", "  |"],
    ?5 => [" _ ", "|_ ", " _|"],
    ?6 => [" _ ", "|_ ", "|_|"],
    ?7 => [" _ ", "  |", "  |"],
    ?8 => [" _ ", "|_|", "|_|"],
    ?9 => [" _ ", "|_|", " _|"],
    ?0 => [" _ ", "| |", "|_|"]
  }

  def print(number) when is_integer(number) do
    number
    |> number_to_string
    |> IO.puts
  end

  def number_to_string(number) when is_integer(number) do
    number
    |> Integer.to_string
    |> String.to_char_list
    |> Enum.reduce(["", "", ""], fn(ch, [s1, s2, s3]) ->
      [ch1, ch2, ch3] = @digits[ch]
      [s1 <> ch1, s2 <> ch2, s3 <> ch3]
    end)
    |> Enum.join("\n")
  end
end
