package org.nspectator.katas.labyrinth

import org.nspectator.katas.labyrinth.Lab
import spock.lang.Specification

/**
 * Created by apple on 12.12.16.
 */
class LabTest extends Specification{

    //labyrinth path test
    def "testLab"(){
        given:
            def lab = new Lab()
        expect:
            lab.solution(a as String[][]).equals(n)
        where:
            a                                                                                                                                                                     |        n
            [["*","*","*","*","*","*"],["+","*","+","+","+","*"],["*","s","+","*","+","*"],["*","*","*","*","+","*"],["+","+","e","+","+","*"],["+","*","*","*","+","*"]]         |       "R U R R D D D D L"
            [["s","*","*","*","*","*"],["+","+","+","*","*","*"],["*","*","+","+","+","+"],["*","*","+","*","*","*"],["*","*","+","*","*","*"],["+","+","+","+","+","e"]]         |       "D R R D D D D R R"
    }
}
