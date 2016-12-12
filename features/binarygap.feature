Feature: Checking1
#Укажем имя сценария (в одной фиче может быть несколько)
Scenario: New Scenario
#И используем наши шаги.
  Given Create an instance of BinaryGap n: "1041"
  Then "126" to binary : "1111110"
  Then Max Gap of this number :: "5"
