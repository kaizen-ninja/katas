package org.nspectator.katas.labyrinth

import spock.lang.Specification

/**
 * Created by nkondrina on 11.12.2016.
 */
class LabyrinthSpec extends Specification{
    Labyrinth solution

    def setup(){
        solution = new Labyrinth()
    }

    def "trivial check"() {
        given:
            def solution = new Labyrinth()
        expect:
            solution != null
    }

    def "check solution"(){
        expect:
            answer==solution.solution(A)
        where:
            answer      | A
            true        | ["******", "_*___*", "*s_*_*", "****_*", "__e__*", "_***_*"]
            true        | ["s_","_e"]
            true        | ["s*","_e"]
            true        | ["s_","*e"]
            false       | ["s*","*e"]
            true        | ["es"]
    }

    def "check given array"()
    {
        expect:
            answer==solution.solution(A)
        where:
            answer       | A
            false        | ["**C***", "_*___*", "*s_*_*", "****_*", "__e__*", "_***_*"]
            false        | ["******", "_*___*", "*s_*_*", "****_*", "__e__*", "_***_*_"]
            false        | ["******", "_*___*", "**_*_*", "****_*", "__e__*", "_***_*"]
            false        | ["******", "_*___*", "*s_*_*", "****_*", "_____*", "_***_*"]
            false        | ["******", "_*___*", "*ss*_*", "****_*", "__e__*", "_***_*"]
            false        | ["******", "_*___*", "*s_*_*", "****_*", "_ee__*", "_***_*"]
            false        | []
    }

}
