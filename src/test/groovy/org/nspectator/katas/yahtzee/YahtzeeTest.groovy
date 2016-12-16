package org.nspectator.katas.yahtzee

import org.nspectator.katas.yahtzee.Yahtzee
import spock.lang.Specification

/**
 * Created by apple on 12.12.16.
 */

class YahtzeeTest extends Specification{

    //test for Chance category
    def "testChance"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],1)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       15
            [1,2,2,3,4]    |       12
            [2,2,2,2,2]    |       10
    }

    //test for Yahtzee category
    def "testYahtzee"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],2)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       0
            [2,2,2,2,2]    |       50
            [3,3,3,3,1]    |       0
    }

    //test for Ones category
    def "testOnes"() {
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],3)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       1
            [1,2,2,1,4]    |       2
            [4,3,2,3,5]    |       0
    }

    //test for Twos category
    def "testTwos"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],4)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       2
            [1,2,2,3,4]    |       4
            [1,3,4,3,5]    |       0
    }

    //test for Threes category
    def "testThrees"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],5)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       3
            [1,2,3,3,4]    |       6
            [1,2,2,4,5]    |       0
    }

    //test for Fours category
    def "testFours"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],6)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       4
            [4,2,2,3,4]    |       8
            [1,3,2,3,5]    |       0
    }

    //test for Fives category
    def "testFives"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],7)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       5
            [1,5,2,3,5]    |       10
            [1,2,2,3,4]    |       0
    }

    //test Sixes category
    def "testSixes"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
        yahtzee.solution(a as int[],8)==n
        where:
            a              |       n
            [1,2,2,6,4]    |       6
            [1,6,2,6,5]    |       12
            [1,2,3,4,5]    |       0
    }

    //test for Pair category
    def "testPair"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],9)==n
        where:
            a              |       n
            [1,2,2,3,4]    |       4
            [1,3,5,3,5]    |       10
            [1,2,3,4,5]    |       0
    }

    //test for Two Pair category
    def "testTwoPair"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],10)==n
        where:
            a              |       n
            [1,2,2,4,4]    |       12
            [1,3,2,3,5]    |       0
            [1,2,3,4,5]    |       0
    }

    //test for Three of a kind category
    def "testThreeOfKind"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],11)==n
        where:
            a              |       n
            [1,3,3,3,5]    |       9
            [1,2,3,4,5]    |       0
            [1,2,2,3,4]    |       0
    }

    //test for Four of a kind category
    def "testFourKind"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],12)==n
        where:
            a              |       n
            [1,4,4,4,4]    |       16
            [1,2,3,4,5]    |       0
            [1,2,2,3,4]    |       0
    }

    //test for Small Straight category
    def "testSStraight"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],13)==n
        where:
            a              |       n
            [1,2,2,3,4]    |       0
            [5,4,3,2,1]    |       0
            [1,2,3,4,5]    |       15
    }

    //test for Large Straight category
    def "testLStraight"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],14)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       0
            [1,3,2,3,5]    |       0
            [2,3,4,5,6]    |       20
    }

    //test for Full House category
    def "testFullHouse"(){
        given:
            def yahtzee = new Yahtzee()
        expect:
            yahtzee.solution(a as int[],15)==n
        where:
            a              |       n
            [1,2,3,4,5]    |       0
            [4,4,4,4,5]    |       0
            [1,2,2,1,1]    |       7
    }
}
