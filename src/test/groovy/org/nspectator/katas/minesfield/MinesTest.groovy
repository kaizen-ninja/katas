package org.nspectator.katas.minesfield

import org.nspectator.katas.minesfield.Mines
import spock.lang.Specification

/**
 * Created by apple on 12.12.16.
 */
class MinesTest extends Specification{

    //minefield test
    def "testMines"(){
        given:
            def mines = new Mines()
        expect:
            java.util.Arrays.deepEquals(mines.solution(a as int[][]),n as String[][])
        where:
            a                                               |   n
            [[0,0,0,-1],[0,0,0,0],[-1,0,0,0]]               |   [["0","0","1","*"],["1","1","1","1"],["*","1","0","0"]]
            [[0,0,0,0],[0,-1,-1,0],[0,0,0,0]]               |   [["1","2","2","1"],["1","*","*","1"],["1","2","2","1"]]
            [[0,0,0,0],[0,0,0,0],[0,0,0,0]]                 |   [["0","0","0","0"],["0","0","0","0"],["0","0","0","0"]]
            [[-1,-1,-1,-1],[-1,-1,-1,-1],[-1,-1,-1,-1]]     |   [["*","*","*","*"],["*","*","*","*"],["*","*","*","*"]]
    }
}
