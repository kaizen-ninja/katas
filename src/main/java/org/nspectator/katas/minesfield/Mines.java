package org.nspectator.katas.minesfield;

import java.util.Arrays;
import java.util.Random;

/**
 ## Mine Fields Kata

 A field of N x M squares is represented by N lines of
 exactly M characters each. The character '*' represents
 a mine and the character '.' represents no-mine.

 Example input (a 4 x 3 mine-field of 12 squares, 2 of
 which are mines)

 4 3
 *...
 ..*.
 ....

 Your task is to write a program to accept this input and
 produce as output a hint-field of identical dimensions
 where each square is a * for a mine or the number of
 adjacent mine-squares if the square does not contain a mine.

 Example output (for the above input)

 *211
 12*1
 0111
 */
public class Mines {

    public static String f = " "; //нет мины
    public static String t = "*"; //есть мина

    public static void main(String[] args) {
        int n = 3; //количество строк
        int m = 4; //количество столбцов
        int k = m/2; //количество мин
        String[][] mfield = new String[n][m]; //минное поле
        int[][] tipField = genField(mfield, k); //генерируем поле, для вычисления подсказок
        String[][] mineField = solution(tipField); //финальное поле с подсказками и минами
        for(int i=0;i<n;i++) {
            for (int j = 0; j < m; j++) {
                System.out.print(mineField[i][j]+" ");
            }
            System.out.println();
        }
    }

    //генерация поля для вычисления подсказок
    public static int[][] genField(String[][] field, int k) {
        int n=field.length;
        int m=field[0].length;
        int[][] intF = new int[n][m];
        //создаем пустое поле
        for(int i=0; i<n;i++){
            for(int j=0;j<m;j++){
                field[i][j]=f;
            }
        }
        Random rnd = new Random();
        int u, i;
        //раскидваем мины
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
        int n=field.length;
        int m=field[0].length;
        String[][] res = new String[field.length][field[0].length];
        //если на точке находится мина, ставим +1 вокруг неё
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
        //помечаем результативное минное поле подсказками и минами
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
