package org.nspectator.katas.javasudoku;
import java.util.ArrayList;
import java.util.Arrays;

/**
 * Created by art-c on 31.10.2016.
 */
public class Work {

    static public boolean validSolution(Integer[][] arr)
    {
            if (arr.length != 9) return false;
            for (int i = 0; i <9; i++)
                if (arr[i].length != 9) return false;

        for (int i = 0; i < arr.length; i++)
        {
            ArrayList<Integer> list = new ArrayList<Integer>();
            for (int j = 0; j <9 ; j++) {
                if(list.contains(arr[i][j])) return false ;
                else list.add(arr[i][j]);
                if(list.contains(0)) return false;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            ArrayList<Integer> list = new ArrayList<Integer>();
            for (int j = 0; j <9 ; j++) {
                if(list.contains(arr[j][i])) return false ;
                else list.add(arr[j][i]);
            }
        }
        return true;
    }
}

