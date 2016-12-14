package org.nspectator.katas.yahtzee

import org.nspectator.katas.yahtzee.Yahtzee
import spock.lang.Specification

/**
 * Created by apple on 12.12.16.
 */

class YahtzeeTest extends Specification{

    //тест вычисления категории Chance
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

    //тест вычисления категории Yahtzee
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

    //тест вычисления категории Ones
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

    //тест вычисления категории Twos
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

    //тест вычисления категории Threes
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

    //тест вычисления категории Fours
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

    //тест вычисления категории Fives
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

    //тест вычисления категории Sixes
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

    //тест вычисления категории Pair
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

    //тест вычисления категории Two Pair
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

    //тест вычисления категории Three of a kind
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

    //тест вычисления категории Four of a kind
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

    //тест вычисления категории Small Straight
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

    //тест вычисления категории Large Straight
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

    //тест вычисления категории Full House
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
