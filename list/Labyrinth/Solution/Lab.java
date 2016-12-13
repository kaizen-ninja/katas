import java.util.ArrayList;
import java.util.List;
import java.util.Random;

/**
 * Created by apple on 13.11.16.
 */
public class Lab {
    public static int n=6;

    public static String s = "s";
    public static String e = "e";
    public static String p = "+";
    public static String t = "-";
    public static String w = "*";

    public static void main(String[] args) {
        String[][] lab = new String[n][n];
        lab = new String[][]{
                {s,w,w,w,w,w},
                {p,p,p,w,w,w},
                {w,w,p,p,p,p},
                {w,w,p,w,w,w},
                {w,w,p,w,w,w},
                {p,p,p,p,p,e}};

        String buf=solution(lab);
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++)
                System.out.print(lab[i][j]+" ");
            System.out.println();
        }
        System.out.println();
        System.out.println(buf);
    }

    public static String solution(String[][] lab){
        List<String> path = new ArrayList<String>();
        int sx=0,sy=0,ex=0,ey=0;
        for(int i=0;i<lab.length;i++){
            for(int j=0;j<lab[0].length;j++){
                if(lab[i][j].equals(s)){
                    sx=i;
                    sy=j;
                }
                if(lab[i][j].equals(e)){
                    ex=i;
                    ey=j;
                }
            }
        }
        String res="";
        if(canSolve(sx,sy,ex,ey,path,lab)){
            for (String str: path) {
                res+=str+" ";
            }
            return res.substring(0,res.length()-1);
        }
        return "NO SOLUTION";
    }

    public static boolean canSolve(int sx, int sy, int ex, int ey, List<String> path, String[][] lab){
        if((sx==ex && sy==ey-1) ||
                (sx==ex && sy==ey+1) ||
                (sx==ex-1 && sy==ey) ||
                (sx==ex+1 && sy==ey))
            return true;
        if(sx+1<lab.length && lab[sx+1][sy].equals(p)){
            lab[sx+1][sy]=t;
            path.add("D");
            if(canSolve(sx+1,sy,ex,ey,path, lab))
                return true;
            lab[sx+1][sy]=" ";
        }
        if(sx-1>=0 && lab[sx-1][sy].equals(p)){
            lab[sx-1][sy]=t;
            path.add("U");
            if(canSolve(sx-1,sy,ex,ey,path, lab))
                return true;
            lab[sx-1][sy]=" ";
        }
        if(sy+1<lab[0].length &&lab[sx][sy+1].equals(p)){
            lab[sx][sy+1]=t;
            path.add("R");
            if(canSolve(sx,sy+1,ex,ey,path, lab))
                return true;
            lab[sx][sy+1]=" ";
        }
        if(sy-1>=0 && lab[sx][sy-1].equals(p)){
            lab[sx][sy-1]=t;
            path.add("L");
            if(canSolve(sx,sy-1,ex,ey,path, lab))
                return true;
            lab[sx][sy-1]=" ";
        }
        return false;
    }
}
