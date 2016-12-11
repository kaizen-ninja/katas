Feature: Checking1

Scenario: New Scenario

  Given Create an instance of BASGKata Gene: "AAAAAACC", Length: "8"
  Then Cortege of repetitions letters from "AATATACA" is "5,1,0,2"
  Then Cortege of excesses letters from "5,1,0,2" is "3,0,0,0"
  Then Cortege "4,5,6,7" contains cortege "4,4,4,4"... Is "True"
  Then Minimal substring length of this gene = "4"

