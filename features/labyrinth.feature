Feature: Checking1

Scenario: New Scenario

  Given Create an instance of Labyrinth n:"6" array: "****** _*___* *s_*_* ****_* ___e_* _*****"
  Then S-Position = "21", E-Position = "43"
  Then Element x= "2", y= "1" == "s"
  Then Path from s to e: "S,R,U,R,R,D,D,D,L,E"
