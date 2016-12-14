package org.nspectator.katas.circularprimes

import spock.lang.Specification

/**
 * @author rgordeev
 */
class CircularPrimesSpec extends Specification {

    CircularPrimes solution

    def setup() {
        solution = new CircularPrimes()
    }

    def "check number for prime"() {
        expect: solution.isPrime.apply(n) == f
        where:
        n       |   f
        20      |   false
        1       |   false
        2       |   true
        3       |   true
        4       |   false
        5       |   true
        6       |   false
        7       |   true
        8       |   false
        0       |   false
        9       |   false
        100     |   false
        101     |   true
        1000    |   false
        1001    |   false
        11      |   true
		104677	|	true
		104681	|	true
		104683	|	true
		104693	|	true
		104701	|	true
		104707	|	true
		104711	|	true
		104717	|	true
		104723	|	true
		104729	|	true
		1024031	|	true
		1024061	|	true
		1024073	|	true
		1024087	|	true
		1024091	|	true
		1024099	|	true
		1024103	|	true
		1024151	|	true
	}

    def "check number to array mapper"() {
        expect:
            solution.numberToArray(n) == arr
        where:
        n       |   arr
        1       |   [1]
        2       |   [2]
        9       |   [9]
        0       |   [0]
        10      |   [0, 1]
        15      |   [5, 1]
        123     |   [3, 2, 1]
        154     |   [4, 5, 1]
        1456731 |   [1, 3, 7, 6, 5, 4, 1]
    }

    def "check rotate algorithm"() {
        expect:
            solution.rotate(n, a) == b
        where:
        n       |       a                  |       b
        3       |   [1, 2, 3, 4]           |   [2, 3, 4, 1]
        4       |   [1, 2, 3, 4]           |   [1, 2, 3, 4]
        2       |   [1, 2, 3, 4]           |   [3, 4, 1, 2]
    }

    def "check reverse work well"() {
        expect:
            solution.reverse(a) == b
        where:
        a                       |   b
        [1]                     |   [1]
        []                      |   []
        [1,2]                   |   [2, 1]
        [1,2,3,4]               |   [4,3,2,1]
        [4,3,2]                 |   [2,3,4]
    }

    def "check array to int conversion"() {
        expect:
            solution.arrayToInt(a) == n
        where:
        a                           |   n
        [1,2,3,4]                   |   1234
        [1]                         |   1
        [1,2]                       |   12
        [1,4,2,1,0]                 |   14210
    }

    def "check rotations generation"() {
        expect:
            solution.rotations(n) == rotations
        where:
        n       |   rotations
        1       |   [1]
        0       |   [0]
        12      |   [12, 21]
        11      |   [11, 11]
        123     |   [123, 312, 231]
        567     |   [567, 756, 675]
    }

    def "check solution"() {
        expect:
            solution.solution(n) == m
        where:
        m       |   n
        0       |   1
        4       |   10
        13      |   100
        25      |   1000
        33      |   10000
        43      |   100000
        55      |   1000000
    }
}
