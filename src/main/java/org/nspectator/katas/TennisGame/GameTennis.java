package org.nspectator.katas.tennisgame;

class GameTennis {
    private PlayerTennis player1;
    private PlayerTennis player2;

    public GameTennis(PlayerTennis player1, PlayerTennis player2) {
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

    public PlayerTennis getWinner() {
        if (player1.getScore() > player2.getScore()) {
            return player1;
        } else {
            return player2;
        }
    }

    public PlayerTennis getPlayerFirst() {
        return player1;
    }

    public PlayerTennis getPlayerSecond() {
        return player2;
    }
}
