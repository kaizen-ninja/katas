package org.nspectator.katas.javasudoku;

import org.junit.Assert;
import org.junit.Test;

import static junit.framework.TestCase.assertEquals;

/**
 * Created by art-c on 31.10.2016.
 */
public class WorkTest {
    @Test
    public void TestTrue()  {

        Integer[][] m = new Integer[][] {
                { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                { 3, 4, 5, 2, 8, 6, 1, 7, 9 } };
       boolean result = Work.validSolution(m);
        assertEquals(result,true);

    }

    @Test
    public void TestZero() {
        Integer[][] m = new Integer[][] { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                { 7, 1, 3, 9, 0, 4, 8, 5, 6 },
                { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                { 3, 4, 5, 2, 8, 6, 1, 7, 9 } };
        boolean result = Work.validSolution(m);
        assertEquals(result,false);
    }

@Test
    public void TestDoubleZero() {
        Integer[][] m = new Integer[][] { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                { 7, 1, 3, 9, 0, 0, 8, 5, 6 },
                { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                { 3, 4, 5, 2, 8, 6, 1, 7, 9 } };
        boolean result = Work.validSolution(m);
    assertEquals(result,false);
    }


    @Test
    public void TestZeroAndRepetition() {
        Integer[][] m = new Integer[][] {{5, 3, 4, 6, 7, 8, 9, 1, 2},
                {6, 7, 2, 1, 9, 0, 3, 4, 8},
        {1, 0, 0, 3, 4, 2, 5, 6, 0},
        {8, 5, 9, 7, 6, 1, 0, 2, 0},
         {4, 2, 6, 8, 5, 3, 7, 9, 1},
         {7, 1, 3, 9, 2, 4, 8, 5, 6},
          {9, 0, 1, 5, 3, 7, 2, 1, 4},
          {2, 8, 7, 4, 1, 9, 6, 3, 5},
          {3, 0, 0, 4, 8, 1, 1, 7, 9}};
        boolean result = Work.validSolution(m);
        assertEquals(result,false);
    }


    @Test
    public void TestCubeAndRepetition() {
        Integer[][] m = new Integer[][] { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                { 9, 7, 2, 1, 6, 5, 3, 4, 8 },
                { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                { 6, 6, 1, 5, 3, 4, 2, 8, 4 },
                { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                { 3, 4, 5, 2, 8, 6, 1, 7, 9 } };
        boolean result = Work.validSolution(m);
        assertEquals(result,false);
    }

    @Test
    public void TestCube(){
        Integer[][] m = new Integer[][] {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 2, 3, 4, 5, 6, 7, 8, 9, 1 },
                { 3, 4, 5, 6, 7, 8, 9, 1, 2 },
                { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
                { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
                { 6, 7, 8, 9, 1, 2, 3, 4, 5 },
                { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
                { 8, 9, 1, 2, 3, 4, 5, 6, 7 },
                { 9, 1, 2, 3, 4, 5, 6, 7, 8 } };
        boolean result = Work.validSolution(m);
        assertEquals(result,false);
    }






}