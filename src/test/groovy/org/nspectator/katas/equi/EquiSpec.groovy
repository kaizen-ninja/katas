package org.nspectator.katas.equi

import spock.lang.Specification

/**
 * Created by nkondrina on 11.12.2016.
 */
class EquiSpec extends Specification{

    Equi solution

    def setup(){
        solution = new Equi()
    }

    def "trivial check"() {
        given:
            def solution = new Equi()
        expect:
            solution != null
    }

    def "check length array"(){
        expect:
            answer==solution.solution(A, N)
        where:
            answer | A          | N
            -2     | [30,100]   | 8
            -2     | []         | -1
    }

    def "check solution"() {
        expect:
            equilibriumindex.contains(solution.solution(A, N))
        where:
            equilibriumindex | N | A
            [-1]             | 2 | [30, 100]
            [1, 3, 7]        | 8 | [-1, 3, -4, 5, 1, -6, 2, 1]
            [0,1]            | 2 | [0,0]
            [0]              | 1 | [200]
    }

    def "check null array"(){
        expect:
            answer==solution.solution(A, N)
        where:
            answer | A          | N
            -1     | []         | 0
    }
}
