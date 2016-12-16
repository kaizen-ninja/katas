package org.nspectator.katas.lcddigits

import spock.lang.Specification

/**
 * Created by nkondrina on 16.12.2016.
 */
class LCDDigitsSpec extends Specification{
    LCDDigits solution

    def setup(){
        solution = new LCDDigits()
    }

    def "trivial check"() {
        given:
            def solution = new LCDDigits()
        expect:
            solution != null
    }

    def "check solution"(){
        expect:
            answer==solution.Str(j,inputNumber,number)
        where:
            number   | inputNumber | j | answer
                910  |    "910"    | 0 | "._. ... ._. "
                910  |    "910"    | 1 | "|_| ..| |.| "
                910  |    "910"    | 2 | "..| ..| |_| "
          9876543210 |"9876543210" | 0 | "._. ._. ._. ._. ._. ... ._. ._. ... ._. "
          9876543210 |"9876543210" | 1 | "|_| |_| ..| |_. |_. |_| ._| ._| ..| |.| "
          9876543210 |"9876543210" | 2 | "..| |_| ..| |_| ._| ..| ._| |_. ..| |_| "
                  -1 |    "-1"     | 0 | ""
                  21 |    "12"     | 0 | ""
                  1  |    "g"      | 0 | ""
                  3  |    "3"      | 3 | ""
    }
}
