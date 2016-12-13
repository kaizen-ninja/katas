/**
 * Created by apple on 11.12.16.
 */
public class Yahtzee {
    public static void main(String[] args) {
        int[] arr = new int[]{1,2,3,4,5};
        int cat = 1;
        System.out.println(solution(arr,cat));
    }

    public static int solution(int[] arr, int cat){
        int score=0;
        int c1=0,c2=0,c3=0,c4=0,c5=0,c6=0;
        for(int i=0;i<arr.length;i++){
            if(arr[i]==1)
                c1++;
            if(arr[i]==2)
                c2++;
            if(arr[i]==3)
                c3++;
            if(arr[i]==4)
                c4++;
            if(arr[i]==5)
                c5++;
            if(arr[i]==6)
                c6++;
        }
        switch (cat){
            case 1:
                score=(1*c1)+(2*c2)+(3*c3)+(4*c4)+(5*c5)+(6*c6);
                break;
            case 2:
                if(c1==5 || c2==5 || c3==5 || c4==5 || c5==5 || c6==5)
                    score=50;
                break;
            case 3:
                score=1*c1;
                break;
            case 4:
                score=2*c2;
                break;
            case 5:
                score=3*c3;
                break;
            case 6:
                score=4*c4;
                break;
            case 7:
                score=5*c5;
                break;
            case 8:
                score=6*c6;
                break;
            case 9:
                if(c6==2)
                    score=12;
                else if(c5==2)
                    score=10;
                else if(c4==2)
                    score=8;
                else if(c3==2)
                    score=6;
                else if(c2==2)
                    score=4;
                else if(c1==2)
                    score=2;
                break;
            case 10:
                if(c6==2 && (c5==2 || c4==2 || c3==2 || c2==2 || c1==2))
                    score = 12+(c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c5==2 && (c6==2 || c4==2 || c3==2 || c2==2 || c1==2))
                    score = 10+(c6==2 ? 12 : c4==2 ? 8 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c4==2 && (c6==2 || c5==2 || c3==2 || c2==2 || c1==2))
                    score = 8+(c6==2 ? 12 : c5==2 ? 10 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c3==2 && (c6==2 || c5==2 || c4==2 || c2==2 || c1==2))
                    score = 6+(c6==2 ? 12 : c5==10 ? 8 : c4==2 ? 8 : c2==2 ? 4 : 2);
                else if(c2==2 && (c6==2 || c5==2 || c4==2 || c3==2 || c1==2))
                    score = 4+(c6==2 ? 12 : c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : 2);
                else if(c1==2 && (c6==2 || c5==2 || c4==2 || c3==2 || c2==2))
                    score = 2+(c6==2 ? 12 : c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : 4);
                break;
            case 11:
                if(c6==3)
                    score=18;
                else if(c5==3)
                    score=15;
                else if(c4==3)
                    score=12;
                else if(c3==3)
                    score=9;
                else if(c2==3)
                    score=6;
                else if(c1==3)
                    score=3;
                break;
            case 12:
                if(c6==4)
                    score=24;
                else if(c5==4)
                    score=20;
                else if(c4==4)
                    score=16;
                else if(c3==4)
                    score=12;
                else if(c2==4)
                    score=8;
                else if(c1==4)
                    score=4;
                break;
            case 13:
                if(arr[0]==1 && arr[1]==2 && arr[2]==3 && arr[3]==4 && arr[4]==5)
                    score=15;
                break;
            case 14:
                if(arr[0]==2 && arr[1]==3 && arr[2]==4 && arr[3]==5 && arr[4]==6)
                    score=20;
                break;
            case 15:
                if(c6==3 && (c5==2 || c4==2 || c3==2 || c2==2 || c1==2))
                    score=18+(c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c5==3 && (c6==2 || c4==2 || c3==2 || c2==2 || c1==2))
                    score=15+(c6==2 ? 12 : c4==2 ? 8 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c4==3 && (c6==2 || c5==2 || c3==2 || c2==2 || c1==2))
                    score=12+(c6==2 ? 12 : c5==2 ? 10 : c3==2 ? 6 : c2==2 ? 4 : 2);
                else if(c3==3 && (c6==2 || c5==2 || c4==2 || c2==2 || c1==2))
                    score=9+(c6==2 ? 12 : c5==10 ? 8 : c4==2 ? 8 : c2==2 ? 4 : 2);
                else if(c2==3 && (c6==2 || c5==2 || c4==2 || c3==2 || c1==2))
                    score=6+(c6==2 ? 12 : c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : 2);
                else if(c1==3 && (c6==2 || c5==2 || c4==2 || c3==2 || c2==2))
                    score=3+(c6==2 ? 12 : c5==2 ? 10 : c4==2 ? 8 : c3==2 ? 6 : 4);
                break;
        }
        return score;
    }
}
