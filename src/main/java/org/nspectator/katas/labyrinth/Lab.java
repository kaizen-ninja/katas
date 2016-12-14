package org.nspectator.katas.labyrinth;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

/**
 ## Labyrinth Kata

 ### Problem Description

 The goal is to write a function that returns a bool value indicating whether it is possible to find the exit or
 not. If it was possible to find the exit, print the path followed.

 Given labyrinth is a multidimensional char array contains `s` in some cell indicating start point and `e` in some cell indicating the destination point.
 Border is a cell marked as `*` and there is no way to go through it directly.

 ### Suggested Test Cases

 *  *  *  *  *  *
 _  *  _  _  _  *
 *  s  _  *  _  *
 *  *  *  *  _  *
 _  _  e  _  _  *
 _  *  *  *  _  *

 Output

 Path found: R U R R D D D D L
 */
public class Lab {

    public static String s = "s"; //символ для обозначения входа
    public static String e = "e"; //символ для обозначения выхода
    public static String p = "+"; //символ для обозначения пути
    public static String t = "-"; //символ для обозначения верного пути
    public static String w = "*"; ////символ для обозначения стены

    public static void main(String[] args) {
        String[][] lab = new String[][]{
                {s,w,w,w,w,w},
                {p,p,p,w,w,w},
                {w,w,p,p,p,p},
                {w,w,p,w,w,w},
                {w,w,p,w,w,w},
                {p,p,p,p,p,e}}; //лабиринт

        String buf=solution(lab); //вычисляем последователость
        for (int i = 0; i < lab.length; i++) {
            for (int j = 0; j < lab[0].length; j++)
                System.out.print(lab[i][j]+" ");
            System.out.println();
        }
        System.out.println();
        System.out.println(buf);
    }

    public static String solution(String[][] lab){
        List<String> path = new ArrayList<String>(); //последовательность шагов
        int sx=0,sy=0,ex=0,ey=0; //координаты входа и выхода
        for(int i=0;i<lab.length;i++){
            for(int j=0;j<lab[0].length;j++){
                if(lab[i][j].equals(s)){ //если нашли вход, сохраняем координаты
                    sx=i;
                    sy=j;
                }
                if(lab[i][j].equals(e)){ //если нашли выход, сохраняем координаты
                    ex=i;
                    ey=j;
                }
            }
        }
        String res=""; //для хранения последовательности шагов в строковом формате
        if(canSolve(sx,sy,ex,ey,path,lab)){ //если найден путь
            for (String str: path) {
                res+=str+" ";
            }
            return res.substring(0,res.length()-1);
        }
        return "NO SOLUTION"; //если не найден путь
    }

    public static boolean canSolve(int sx, int sy, int ex, int ey, List<String> path, String[][] lab){
        if((sx==ex && sy==ey-1) ||
                (sx==ex && sy==ey+1) ||
                (sx==ex-1 && sy==ey) ||
                (sx==ex+1 && sy==ey))
            return true; //если выход находится рядом со входом, то путь уже найден
        if(sx+1<lab.length && lab[sx+1][sy].equals(p)){
            lab[sx+1][sy]=t;
            path.add("D"); //двигаемся вниз
            if(canSolve(sx+1,sy,ex,ey,path, lab))
                return true;
            lab[sx+1][sy]=" ";
        }
        if(sx-1>=0 && lab[sx-1][sy].equals(p)){
            lab[sx-1][sy]=t;
            path.add("U"); //двигаемся вверх
            if(canSolve(sx-1,sy,ex,ey,path, lab))
                return true;
            lab[sx-1][sy]=" ";
        }
        if(sy+1<lab[0].length &&lab[sx][sy+1].equals(p)){
            lab[sx][sy+1]=t;
            path.add("R"); //двигаемся вправо
            if(canSolve(sx,sy+1,ex,ey,path, lab))
                return true;
            lab[sx][sy+1]=" ";
        }
        if(sy-1>=0 && lab[sx][sy-1].equals(p)){
            lab[sx][sy-1]=t;
            path.add("L"); //двигаемся влево
            if(canSolve(sx,sy-1,ex,ey,path, lab))
                return true;
            lab[sx][sy-1]=" ";
        }
        return false;
    }
}
