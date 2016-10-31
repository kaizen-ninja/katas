package com.technologyconversations.learning.kata.solutions.tennisgame;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by WhatNick on 10/31/2016.
 */

class PlayerTennis {
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

    public PlayerTennis(String name) {
        this.name = name;
    }

    public String getScoresResult(){
        return scoresResult.get(score);
    }
}
