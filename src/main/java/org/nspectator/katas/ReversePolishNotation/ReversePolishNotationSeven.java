package org.nspectator.katas.ReversePolishNotation;

import java.util.HashMap;
import java.util.Map;
import java.util.Stack;

public class ReversePolishNotationSeven {

    public static Double calc(String input) {
        Stack<Double> numbers = new Stack<>();
        for (String number : input.split(" ")) {
            Sign sign = Sign.find(number);
            if (sign != null) {
                calcSign(numbers, sign);
            } else {
                numbers.push(Double.parseDouble(number));
            }
        }
        return numbers.pop();
    }

    protected static Stack<Double> calcSign(Stack<Double> numbers, Sign sign) {
        numbers.push(sign.apply(numbers.pop(), numbers.pop()));
        return numbers;
    }

    public enum Sign {

        ADD("+") {
            public double apply(double num1, double num2) {
                return num2 + num1;
            }
        },
        REMOVE("-") {
            public double apply(double num1, double num2) {
                return num2 - num1;
            }
        },
        MULTIPLY("*") {
            public double apply(double num1, double num2) {
                return num2 * num1;
            }
        },
        DIVIDE("/") {
            public double apply(double num1, double num2) {
                return num2 / num1;
            }
        };

        private final String operatorText;

        Sign(String operatorText) {
            this.operatorText = operatorText;
        }

        public abstract double apply(double x1, double x2);

        private static final Map<String, Sign> map;

        static {
            map = new HashMap<>();
            for (Sign sign : Sign.values()) {
                map.put(sign.operatorText, sign);
            }
        }

        public static Sign find(String sign) {
            return map.get(sign);
        }

    }

}
