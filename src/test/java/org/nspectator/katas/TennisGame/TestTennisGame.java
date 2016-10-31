package org.nspectator.katas.tennisgame;

import org.junit.Before;
import org.junit.Test;

import java.util.stream.IntStream;

import static org.hamcrest.CoreMatchers.is;
import static org.hamcrest.CoreMatchers.not;
import static org.hamcrest.MatcherAssert.assertThat;

public class TestTennisGame  {
    PlayerTennis kyle;
    PlayerTennis maria;
    GameTennis newGame;

    @Before
    public void untilIsStarting() {
        kyle = new PlayerTennis("Kyle");
        maria = new PlayerTennis("Maria");
        newGame = new GameTennis(kyle, maria);
    }
    private void befGameMethod() {
        kyle = new PlayerTennis("Victor");
        maria = new PlayerTennis("Sarah");
        newGame = new GameTennis(kyle, maria);
    }

    @Test
    public void loveScores() {
        assertThat(newGame.getPlayerFirst().getScoresResult(),is("love"));
        assertThat(newGame.getPlayerSecond().getScoresResult(),is("love"));
    }

    @Test
    public void fifteenScores() {
        maria.incrementScores();
        assertThat(newGame.getPlayerFirst().getScoresResult(),is("love"));
        assertThat(newGame.getPlayerSecond().getScoresResult(),is("fifteen"));
    }

    @Test
    public void thirtyScores() {
        kyle.incrementScores();
        kyle.incrementScores();
        maria.incrementScores();
        assertThat(newGame.getPlayerFirst().getScoresResult(),is("thirty"));
        assertThat(newGame.getPlayerSecond().getScoresResult(),is("fifteen"));
    }

    @Test
    public void fortyScores() {
        IntStream.rangeClosed(1, 3).forEach((Integer) -> {
            kyle.incrementScores();
        });
        assertThat(newGame.getPlayerFirst().getScoresResult(),is("forty"));
        assertThat(newGame.getPlayerSecond().getScoresResult(),is("love"));
    }

    @Test
    public void advantage() {
        IntStream.rangeClosed(1, 3).forEach((Integer) -> {
            kyle.incrementScores();
        });
        IntStream.rangeClosed(1, 4).forEach((Integer) -> {
            maria.incrementScores();
        });
        assertThat(newGame.getResult(),is("advantage Maria"));
    }

    @Test
    public void deuce() {
        IntStream.rangeClosed(1, 3).forEach((Integer) -> {
            kyle.incrementScores();
        });
        IntStream.rangeClosed(1, 3).forEach((Integer) -> {
            maria.incrementScores();
        });
        assertThat(newGame.getResult(),is("deuce"));
        kyle.incrementScores();
        assertThat(newGame.getResult(),is(not("deuce")));
        maria.incrementScores();
        assertThat(newGame.getResult(),is("deuce"));
    }

    @Test
    public void won() {
        IntStream.rangeClosed(1, 4).forEach((Integer) -> {
            kyle.incrementScores();
        });
        IntStream.rangeClosed(1, 3).forEach((Integer) -> {
            maria.incrementScores();
        });
        assertThat(newGame.getResult(),is(not("Kyle won")));
        assertThat(newGame.getResult(),is(not("Maria won")));
        kyle.incrementScores();
        assertThat(newGame.getResult(),is("Kyle won"));
    }
}