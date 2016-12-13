import java.util.ArrayList;
import java.util.List;

/**
 * Created by apple on 27.11.16.
 */
public class Eq {
    public static void main(String[] args) {
        int[] a = new int[]{-1,3,-4,5,1,-6,2,1};
        System.out.println(solution(a, a.length));
    }

    public static String solution(int[] A, int N) {
        String equi = "";

        int low = 0;
        int up = 0;
        for(int i : A)
        up += i;
        for (int i = 0; i < N; i++)
        {
            up -= A[i];
            if (up == low)
            {
                equi+=i+",";
            }
            low += A[i];
        }
        if(equi.length()<2)
            return  "-1";
        return equi.substring(0,equi.length()-1);
    }
}
