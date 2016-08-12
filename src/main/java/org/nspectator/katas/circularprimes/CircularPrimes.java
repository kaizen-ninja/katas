package org.nspectator.katas.circularprimes;

import java.util.*;
import java.util.function.Function;
import java.util.stream.IntStream;

import static org.nspectator.katas.utils.StreamUtils.zipWithIndex;
/**
 * @author rgordeev
 *
 *
 * A number is called a circular prime if it is prime and all of its rotations are primes.
 *
 * For example, the number 197 has two rotations: 971, and 719.  Both of them are prime.
 * Another example: 1193 is a circular prime, since 1931, 9311 and 3119 all are also prime.
 *
 * There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
 *
 * How many circular primes are there below N?
 *
 * 1 <= N <= 1000000
 *
 * Do not solve the task using a built-in function that can accomplish the whole task on its own.
 *
 * Test Cases
 *
 * There are 0 circular primes below 1.
 * There are 4 circular primes below 10.
 * There are 13 circular primes below 100.
 * There are 25 circular primes below 1000.
 * There are 33 circular primes below 10000.
 * There are 43 circular primes below 100000.
 * There are 55 circular primes below 1000000.
 *
 */
public class CircularPrimes {

    public long solution(int n) {
        return IntStream.rangeClosed(0, n)
                .boxed()
                .filter(isPrime::apply)
                .map(this::rotations)
                .filter(rotations -> rotations.stream().allMatch(isPrime::apply))
                .count();
    }

    protected Function<Integer, Boolean> isPrime = (Integer m) -> {
        if (m <= 1) return false;
        for (int i = 2; i <= m / 2; i++)
            if (m % i == 0) return false;
        return true;
    };

    protected List<Integer> rotations(int n) {
        List<Integer> num = reverse(numberToArray(n));
        List<Integer> result = new ArrayList<>(num.size());
        for (int i = 0; i < num.size(); i++) {
            List<Integer> rotation = rotate(i, num);
            result.add(arrayToInt(rotation));
        }
        return result;
    }

    protected Integer arrayToInt(List<Integer> a) {
        List<Integer> reverse = reverse(a);

        Map.Entry<Integer, Integer> initial = new AbstractMap.SimpleEntry<>(0, 0);

        return zipWithIndex(reverse.stream()).reduce(initial, (x, y) -> {
            Map.Entry<Integer, Integer> result = new AbstractMap.SimpleEntry<>(0, 0);
            result.setValue(x.getValue() + y.getValue() * new Long(Math.round(Math.pow(10, y.getKey()))).intValue());
            return result;
        }).getValue();
    }

    protected List<Integer> rotate(Integer n, List<Integer> a) {
        int m = a.size();
        n = n % m;

        Integer[] result = new Integer[m];
        for (int i = 0; i < m; i++)
            result[i] = a.get((i + m - n) % m);
        return Arrays.asList(result);
    }

    protected List<Integer> numberToArray(Integer n) {

        Integer m = Math.abs(n);

        List<Integer> parts = new ArrayList<>();

        if (m == 0) parts.add(n);

        while (m > 0) {
            parts.add(m % 10);
            m = m / 10;
        }

        return parts;
    }

    protected List<Integer> reverse(List<Integer> a) {
        List<Integer> copy = new ArrayList<>(a);
        Collections.reverse(copy);
        return copy;
    }
}
