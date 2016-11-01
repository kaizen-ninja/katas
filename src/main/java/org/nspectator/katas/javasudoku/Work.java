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

        for (int i = 0, i1 = 1, j1 = 1; i <9 ; i++, j1+=3)
        {
            int[] mas = new int[9];

            if (i == 3) {i1+= 3; j1 = 1;}
            else if (i ==6)  {i1+= 3; j1 = 1;}

            mas[0]  = arr[i1-1][j1-1];
            mas[1]  = arr[i1-1][j1];
            mas[2]  = arr[i1-1][j1+1];
            mas[3]  = arr[i1][j1-1];
            mas[4]  = arr[i1][j1];
            mas[5]  = arr[i1][j1+1];
            mas[6]  = arr[i1+1][j1-1];
            mas[7]  = arr[i1+1][j1];
            mas[8]  = arr[i1+1][j1+1];
            ArrayList<Integer> list2 = new ArrayList<>();
            ArrayList<Integer> list = new ArrayList<Integer>();

            for (int j = 0; j <9 ; j++) {
                if(list.contains(arr[i][j])) return false ;
                else list.add(arr[i][j]);
                if(list.contains(0)) return false;

                if(list2.contains(mas[j])) return false;
                else list2.add(mas[j]);
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

