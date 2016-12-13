import java.util.Arrays;
import java.util.Random;

/**
 * Created by apple on 11.12.16.
 */
public class Mines {
    public static int n = 3;
    public static int m = 4;
    public static int k = m/2;
    public static String[][] mfield = new String[n][m];

    public static String f = " ";
    public static String t = "*";

    public static void main(String[] args) {
        int[][] tipField = genField(mfield);
        String[][] mineField = solution(tipField);
        for(int i=0;i<n;i++) {
            for (int j = 0; j < m; j++) {
                System.out.print(mineField[i][j]+" ");
            }
            System.out.println();
        }
    }

    public static int[][] genField(String[][] field) {
        int[][] intF = new int[n][m];
        for(int i=0; i<n;i++){
            for(int j=0;j<m;j++){
                field[i][j]=f;
            }
        }
        Random rnd = new Random();
        int u, i;
        while(k>0){
            u = rnd.nextInt(n);
            i = rnd.nextInt(m);
            field[u][i]=t;
            intF[u][i]=-1;
            k--;
        }
        return intF;
    }

    public static String[][] solution(int[][] field) {
        String[][] res = new String[field.length][field[0].length];
        for(int i=0; i<n;i++){
            for(int j=0;j<m;j++){
                if(field[i][j]==-1){
                    if(i+1<n && j+1<m && field[i+1][j+1]!=-1)
                        field[i+1][j+1]++;
                    if(i-1>=0 && j-1>=0 && field[i-1][j-1]!=-1)
                        field[i-1][j-1]++;
                    if(i+1<n && field[i+1][j]!=-1)
                        field[i+1][j]++;
                    if(j+1<m && field[i][j+1]!=-1)
                        field[i][j+1]++;
                    if(i-1>=0 && field[i-1][j]!=-1)
                        field[i-1][j]++;
                    if(j-1>=0 && field[i][j-1]!=-1)
                        field[i][j-1]++;
                    if(i-1>=0 && j+1<m && field[i-1][j+1]!=-1)
                        field[i-1][j+1]++;
                    if(i+1<n && j-1>=0 && field[i+1][j-1]!=-1)
                        field[i+1][j-1]++;
                }
            }
        }
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(field[i][j]!=-1)
                    res[i][j]=""+field[i][j];
                else
                    res[i][j]="*";
            }
        }
        return res;
    }
}
