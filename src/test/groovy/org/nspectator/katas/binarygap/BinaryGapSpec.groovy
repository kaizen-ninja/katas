package org.nspectator.katas.binarygap

import spock.lang.Specification

/**
 * Created by nkondrina on 11.12.2016.
 */
class BinaryGapSpec extends  Specification{
    BinaryGap solution

    def setup(){
        solution = new BinaryGap()
    }

    def "trivial check"() {
        given:
            def solution = new BinaryGap()
        expect:
            solution != null
    }

    def "check solution"(){
        expect:
            maxlength==solution.solution(N)
        where:
            maxlength        | N
            0                | 2147483647
            1                | 20
            2                | 9
            4                | 529
            5                | 1041
    }

    def "N - positive number"(){
        expect:
            answer==solution.solution(N)
        where:
            answer | N
            -2     | 0
            -2     | -1
    }
}
