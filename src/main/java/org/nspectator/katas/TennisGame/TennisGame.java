package r_gordeev;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by WhatNick on 10/31/2016.
 */

class Player {
    private String name;
    private int score;
    public static final List<String> scoresResult
            = new ArrayList<String>();
    static {
        scoresResult.add("love");
        scoresResult.add("fifteen");
        scoresResult.add("thirty");
        scoresResult.add("forty");
    }

    public int getScore() {
        return score;
    }

    public String getName() {
        return name;
    }

    public void incrementScores() {
         this.score++;
    }

    public Player(String name) {
        this.name = name;
    }

    public String getScoresResult(){
        return scoresResult.get(score);
    }
}

class Game {
    private Player player1;
    private Player player2;

    public Game(Player player1, Player player2) {
        this.player1 = player1;
        this.player2 = player2;
    }

    public String getResult() {
        /*
         * if scores of player1 and player2 more or equal than 3
         */
        if (player1.getScore() >= 3
                && player2.getScore() >= 3) {

            /*
             * if scores of player2 more than scores of player2 by 2 or more
             * points:
             * check and return the winner
             */
            if (Math.abs(player2.getScore()
                    - player1.getScore()) >= 2) {
                return getWinner().getName() + " won";
           /*
            * if scores of player1 equals scores of player2:
            * return "deuce"
            */
            } else if (player1.getScore() == player2.getScore()) {
                return "deuce";
            /*
             * else:
             * return "advantage" and the winner name
             */
            } else {
                return "advantage " + getWinner().getName();
            }

        /*
         * return scores of players
         */
        } else {
            return player1.getScoresResult() + ", "
                    + player2.getScoresResult();
        }
    }

    public Player getWinner() {
        if (player1.getScore() > player2.getScore()) {
            return player1;
        } else {
            return player2;
        }
    }

    public Player getPlayerFirst() {
        return player1;
    }

    public Player getPlayerSecond() {
        return player2;
    }
}

