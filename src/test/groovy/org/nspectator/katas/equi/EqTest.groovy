package org.nspectator.katas.equi

import org.nspectator.katas.equi.Eq
import spock.lang.Specification

/**
 * Created by apple on 12.12.16.
 */
class EqTest extends Specification{

    //тест вычисления точек равновесия
    def "testSol"(){
        given:
            def eq = new Eq()
        expect:
            eq.solution(a as int[],a.size()).equals(n)
        where:
            a                      |       n
            [-1,3,-4,5,1,-6,2,1]   |       "1,3,7"
            [3,-4,5,1,-6,2,1]      |       "1"
            [-1,-4,5,1,-6,2,1]     |       "-1"
    }
}
