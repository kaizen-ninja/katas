package org.nspectator.katas.circularprimes;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.IntStream;

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
                .filter(it -> isPrime(it))
                .map(it -> rotations(it))
                .filter(it -> it.stream().allMatch(rotation -> isPrime(rotation)))
                .count();
    }

    protected boolean isPrime(int n) {
        if (n <= 1) return false;
        for (int i = 2; i <= n / 2; i++)
            if (n % i == 0) return false;
        return true;
    }

    protected List<Integer> rotations(int n) {
        Integer[] num = reverse(numberToArray(n));
        List<Integer> result = new ArrayList<>(num.length);
        for (int i = 0; i < num.length; i++) {
            Integer[] rotation = rotate(i, num);
            result.add(arrayToInt(rotation));
        }
        return result;
    }

    protected Integer arrayToInt(Integer[] a) {
        Integer[] reverse = reverse(a);
        Integer result = 0;
        for (int i = 0; i < reverse.length; i++)
            result += reverse[i] * new Long(Math.round(Math.pow(10, i))).intValue();
        return result;
    }

    protected Integer[] rotate(Integer n, Integer[] a) {
        int m = a.length;
        n = n % m;

        Integer[] result = new Integer[m];
        for (int i = 0; i < m; i++)
            result[i] = a[(i + m - n) % m];
        return result;
    }

    protected Integer[] numberToArray(int n) {

        if (n < 0) throw new IllegalArgumentException("number should be positive");

        if (n <= 9) return new Integer[]{n};

        List<Integer> parts = new ArrayList<>();
        while (n > 0) {
            parts.add(n % 10);
            n = n / 10;
        }

        return parts.toArray(new Integer[0]);
    }

    protected Integer[] reverse(Integer[] a) {
        if (a == null || a.length == 0) return a;

        int m = a.length;
        Integer[] result = new Integer[m];
        for (int i = 0; i < m; i++)
            result[i] = a[m - i - 1];
        return result;
    }
}
