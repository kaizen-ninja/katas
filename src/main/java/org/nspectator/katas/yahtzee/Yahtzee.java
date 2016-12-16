package org.nspectator.katas.yahtzee;

/**
 ## Yehtzee Kata

 The game of yahtzee is a simple dice game. Each player rolls five
 six-sided dice. They can re-roll some or all of the dice up to three
 times (including the original roll).

 For example, suppose a players rolls

 3,4,5,5,2

 They hold the two fives and re-roll the other three dice (3,4,2)

 5,1,5,5,3

 They hold the three fives and re-roll the other two dice (1,3)

 5,6,5,5,2

 The player then places the roll in a category, such as ones, twos, fives,
 pair, two pairs etc (see below). If the roll is compatible with the category,
 the player gets a score for the roll according to the rules. If the roll is not
 compatible with the category, the player scores zero for the roll.

 For example, suppose a player scores 5,6,5,5,2 in the fives category they
 would score 15 (three fives). The score for that go is then added to their
 total and the category cannot be used again in the remaining goes for that game.
 A full game consists of one go for each category. Thus, for their last go in
 a game, a player must choose their only remaining category.

 Your task is to score a GIVEN roll in a GIVEN category.
 You do NOT have to program the random dice rolling.
 The game is NOT played by letting the computer choose the highest scoring
 category for a given roll.


 #### Yahzee Categories and Scoring Rules


 #####Chance:

 The player scores the sum of all dice, no matter what they read.
 For example,

 1,1,3,3,6 placed on "chance" scores 14 (1+1+3+3+6)
 4,5,5,6,1 placed on "chance" scores 21 (4+5+5+6+1)

 #####org.nspectator.katas.yahtzee.Yahtzee:

 If all dice have the same number, the player scores 50 points.
 For example,
 1,1,1,1,1 placed on "yahtzee" scores 50
 1,1,1,2,1 placed on "yahtzee" scores 0

 #####Ones, Twos, Threes, Fours, Fives, Sixes:

 The player scores the sum of the dice that reads one,
 two, three, four, five or six, respectively.
 For example,

 1,1,2,4,4 placed on "fours" scores 8 (4+4)
 2,3,2,5,1 placed on "twos" scores 4  (2+2)
 3,3,3,4,5 placed on "ones" scores 0

 #####Pair:

 The player scores the sum of the two highest matching dice.
 For example, when placed on "pair"

 3,3,3,4,4 scores 8 (4+4)
 1,1,6,2,6 scores 12 (6+6)
 3,3,3,4,1 scores 0
 3,3,3,3,1 scores 0

 #####Two pairs:

 If there are two pairs of dice with the same number, the
 player scores the sum of these dice.
 For example, when placed on "two pairs"

 1,1,2,3,3 scores 8 (1+1+3+3)
 1,1,2,3,4 scores 0
 1,1,2,2,2 scores 0

 #####Three of a kind:

 If there are three dice with the same number, the player
 scores the sum of these dice.

 For example, when placed on "three of a kind"

 3,3,3,4,5 scores 9 (3+3+3)
 3,3,4,5,6 scores 0
 3,3,3,3,1 scores 0

 #####Four of a kind:

 If there are four dice with the same number, the player
 scores the sum of these dice.

 For example, when placed on "four of a kind"

 2,2,2,2,5 scores 8 (2+2+2+2)
 2,2,2,5,5 scores 0
 2,2,2,2,2 scores 0

 #####Small straight:

 When placed on "small straight", if the dice read

 1,2,3,4,5, the player scores 15 (the sum of all the dice.

 #####Large straight:

 When placed on "large straight", if the dice read

 2,3,4,5,6, the player scores 20 (the sum of all the dice).

 #####Full house:

 If the dice are two of a kind and three of a kind, the
 player scores the sum of all the dice.
 For example, when placed on "full house"

 1,1,2,2,2 scores 8 (1+1+2+2+2)
 2,2,3,3,4 scores 0
 4,4,4,4,4 scores 0
 */
public class Yahtzee {
    public static void main(String[] args) {
        int[] arr = new int[]{1,2,3,4,5}; //example roll values
        int cat = 1; //chosen scoring category
        System.out.println(solution(arr,cat));
    }

    public static int solution(int[] arr, int cat){
        int score=0; //score
        int c1=0,c2=0,c3=0,c4=0,c5=0,c6=0; //number of 1,2,3,4,5,6
        for(int i=0;i<arr.length;i++){
            if(arr[i]==1)
                c1++;
            if(arr[i]==2)
                c2++;
            if(arr[i]==3)
                c3++;
            if(arr[i]==4)
                c4++;
            if(arr[i]==5)
                c5++;
            if(arr[i]==6)
                c6++;
        }
        //evaluating the score based on chosen category
        switch (cat){
            case 1: //chance
                score=(1*c1)+(2*c2)+(3*c3)+(4*c4)+(5*c5)+(6*c6);
                break;
            case 2: //yahtzee
                if(c1==5 || c2==5 || c3==5 || c4==5 || c5==5 || c6==5)
                    score=50;
                break;
            case 3: //ones
                score=1*c1;
                break;
            case 4: //twos
                score=2*c2;
                break;
            case 5: //threes
                score=3*c3;
                break;
            case 6: //fours
                score=4*c4;
                break;
            case 7: //fives
                score=5*c5;
                break;
            case 8: //sixes
                score=6*c6;
                break;
            case 9: //pair
                if(c6==2)
                    score=12;
                else if(c5==2)
                    score=10;
                else if(c4==2)
                    score=8;
                else if(c3==2)
                    score=6;
                else if(c2==2)
                    score=4;
                else if(c1==2)
                    score=2;
                break;
            case 10: //two pair
                if(c6==2 && (c5==2 || c4==2 || c3==2 || c2==2 || c1==2))
                    score = 12+(c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c5==2 && (c6==2 || c4==2 || c3==2 || c2==2 || c1==2))
                    score = 10+(c6==2 ? 12 : c4==2 ? 8 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c4==2 && (c6==2 || c5==2 || c3==2 || c2==2 || c1==2))
                    score = 8+(c6==2 ? 12 : c5==2 ? 10 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c3==2 && (c6==2 || c5==2 || c4==2 || c2==2 || c1==2))
                    score = 6+(c6==2 ? 12 : c5==10 ? 8 : c4==2 ? 8 : c2==2 ? 4 : 2);
                else if(c2==2 && (c6==2 || c5==2 || c4==2 || c3==2 || c1==2))
                    score = 4+(c6==2 ? 12 : c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : 2);
                else if(c1==2 && (c6==2 || c5==2 || c4==2 || c3==2 || c2==2))
                    score = 2+(c6==2 ? 12 : c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : 4);
                break;
            case 11: //three of a kind
                if(c6==3)
                    score=18;
                else if(c5==3)
                    score=15;
                else if(c4==3)
                    score=12;
                else if(c3==3)
                    score=9;
                else if(c2==3)
                    score=6;
                else if(c1==3)
                    score=3;
                break;
            case 12: //four of a kind
                if(c6==4)
                    score=24;
                else if(c5==4)
                    score=20;
                else if(c4==4)
                    score=16;
                else if(c3==4)
                    score=12;
                else if(c2==4)
                    score=8;
                else if(c1==4)
                    score=4;
                break;
            case 13: //small straight
                if(arr[0]==1 && arr[1]==2 && arr[2]==3 && arr[3]==4 && arr[4]==5)
                    score=15;
                break;
            case 14: //large straight
                if(arr[0]==2 && arr[1]==3 && arr[2]==4 && arr[3]==5 && arr[4]==6)
                    score=20;
                break;
            case 15: //full house
                if(c6==3 && (c5==2 || c4==2 || c3==2 || c2==2 || c1==2))
                    score=18+(c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c5==3 && (c6==2 || c4==2 || c3==2 || c2==2 || c1==2))
                    score=15+(c6==2 ? 12 : c4==2 ? 8 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c4==3 && (c6==2 || c5==2 || c3==2 || c2==2 || c1==2))
                    score=12+(c6==2 ? 12 : c5==2 ? 10 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c3==3 && (c6==2 || c5==2 || c4==2 || c2==2 || c1==2))
                    score=9+(c6==2 ? 12 : c5==10 ? 8 : c4==2 ? 8 : c2==2 ? 4 : 2);
                else if(c2==3 && (c6==2 || c5==2 || c4==2 || c3==2 || c1==2))
                    score=6+(c6==2 ? 12 : c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : 2);
                else if(c1==3 && (c6==2 || c5==2 || c4==2 || c3==2 || c2==2))
                    score=3+(c6==2 ? 12 : c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : 4);
                break;
        }
        return score;
    }
}
