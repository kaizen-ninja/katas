Feature: Checking1
#Укажем имя сценария (в одной фиче может быть несколько)
Scenario: New Scenario
#И используем наши шаги.
  Given Create an instance of Equi array: "0,1,2,4,-6,9"
  Then Element "3" Is Equilibrium. It`s "True"
  Then Element "2" Is Equilibrium. It`s "False"
  Then All Equilibrium Indexes is: "3"
