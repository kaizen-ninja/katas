package org.nspectator.katas.equi;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by nkondrina on 11.12.2016.
 */
public class Equi {
    public List<Integer> M;
    public Integer count;

    public Integer solution(List<Integer> A, Integer N){
        //A[0] + A[1] + ... + A[P−1] = A[P+1] + ... + A[N−2] + A[N−1].
        // The function should return `−1` if no equilibrium index exists.

        M=A;
        count=N;

       if (N!=A.size())
           return -2;


        //for (Integer P=0; P<=N-1; P++)
        for (Integer P=N-1; P>=0; P--)
        {
            if (Sum(0, P-1) == Sum(P+1,N-1))
                return P;
        }

        return -1;
    }

    private Integer Sum(int k, int l)
    {
        Integer s=0;

        if (k<=l) {
            for (Integer i = k; i <= l; i++)
                if (i >= 0 && i <= count - 1)
                    s += M.get(i);
        }

        return s;
    }

    public static void main(String[] args) {
        Equi solution1 = new Equi();
        List<Integer> li = new ArrayList<Integer>();
        li.add(0);
        li.add(100);
      /* li.add(-4);
        li.add(5);
        li.add(1);
        li.add(-6);
        li.add(2);
        li.add(1);*/

        Integer it = solution1.solution(li, li.size());
    }
}
