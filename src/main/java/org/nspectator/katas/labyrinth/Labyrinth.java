package org.nspectator.katas.labyrinth;

import com.sun.org.apache.xpath.internal.operations.Bool;

import java.awt.*;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by nkondrina on 11.12.2016.
 */

public class Labyrinth {
    List<String> lab;
    Integer rows, columns;
    Point e,s;
    List<Point> endputh=new ArrayList<>();

    public Boolean solution(List<String> labyrinth)
    {
        lab=labyrinth;
        List<Point> puth = new ArrayList<>();

        if (!Check())
            return false;
        else
            return Searchputh(puth, s);
    }

    private Boolean Searchputh(List<Point> puth1, Point t)
    {
        List<Point> puth2;
        //Point t= puth1.get(puth1.size()-1);
        Point z;

        if (t.x==e.x && t.y==e.y) {
            puth1.add(t);
            System.out.print("S ");
            for(Integer i=1; i<puth1.size(); i++)
            {
                if (puth1.get(i-1).x<puth1.get(i).x)
                    System.out.print("D ");
                else if (puth1.get(i-1).x>puth1.get(i).x)
                    System.out.print("U ");
                else if (puth1.get(i-1).y<puth1.get(i).y)
                    System.out.print("R ");
                else
                    System.out.print("L ");
            }
            System.out.println();
            return true;
        }
        else
        {
            puth2 = new ArrayList<>();
            puth2.addAll(puth1);
            puth2.add(t);
            z=new Point(t.x, t.y+1);
            if (z.y<columns && lab.get(z.x).charAt(z.y)!='*' && !puth2.contains(z) && Searchputh(puth2,z))
                    return true;

            z=new Point(t.x, t.y-1);
            if (z.y>=0 && lab.get(z.x).charAt(z.y)!='*' && !puth2.contains(z) && Searchputh(puth2,z))
                    return true;

            z=new Point(t.x+1, t.y);
            if (z.x<rows && lab.get(z.x).charAt(z.y)!='*' && !puth2.contains(z) && Searchputh(puth2,z))
                    return true;

            z=new Point(t.x-1, t.y);
            if (z.x>=0 && lab.get(z.x).charAt(z.y)!='*' && !puth2.contains(z) && Searchputh(puth2,z))
                    return true;

            return false;
        }
    }

   /* private Boolean Searchputh(List<Point> puth1)
    {
        List<Point> puth2;
        Point t= puth1.get(puth1.size()-1);
        Point z;

        if (t==e) {
            endputh = puth1;
            return true;
        }
        else
        {
            z=new Point(t.X, t.Y+1);
            if (z.Y<columns && lab.get(z.X).charAt(z.Y)!="*" && !puth1.contains(z)) {
                puth2 = new ArrayList<>();
                puth2.addAll(puth1);
                puth2.add(z);
                if (Searchputh(puth2))
                    return true;
                else
                {
                    z=new Point(t.X, t.Y-1);
                    if (z.Y>=0 && lab.get(z.X).charAt(z.Y)!="*" && !puth1.contains(z)) {
                        puth2 = new ArrayList<>();
                        puth2.addAll(puth1);
                        puth2.add(z);
                        if (Searchputh(puth2))
                            return true;
                        else
                        {
                            z=new Point(t.X+1, t.Y);
                            if (z.X<rows && lab.get(z.X).charAt(z.Y)!="*" && !puth1.contains(z)) {
                                puth2 = new ArrayList<>();
                                puth2.addAll(puth1);
                                puth2.add(z);
                                if (Searchputh(puth2))
                                    return true;
                                else
                                {
                                    z=new Point(t.X-1, t.Y);
                                    if (z.X>=0 && lab.get(z.X).charAt(z.Y)!="*" && !puth1.contains(z)) {
                                        puth2 = new ArrayList<>();
                                        puth2.addAll(puth1);
                                        puth2.add(z);
                                        if (Searchputh(puth2))
                                            return true;
                                        else
                                            return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        //puth2.add(s);

        return false;
    }
*/
    private Boolean Check()
    {
        Integer counts=0, counte=0;

        if (lab==null)
            return false;

        rows = lab.size();
        if (rows==0)
            return false;

        columns = lab.get(0).length();

        if (columns==0)
            return false;


        for(Integer i=0; i<rows;i++) {
            if (columns != lab.get(i).length())
                return false;

            for(Integer j=0; j<columns;j++) {
                char ch=lab.get(i).charAt(j);
                if (ch == 's') {
                    s = new Point(i, j);
                    counts++;
                }
                else {
                    if (ch == 'e') {
                        e = new Point(i, j);
                        counte++;
                    } else {
                        if (ch != '*' && ch != '_')
                            return false;
                    }
                }
            }
        }

        if (counte!=1 || counts!=1)
            return false;

        return true;
    }

    public static void main(String[] args) {
        Labyrinth solution = new Labyrinth();
        List<String> list=new ArrayList<>();
        list.add("******");
        list.add("_*___*");
        list.add("*s_*_*");
        list.add("****_*");
        list.add("__e__*");
        list.add("_***_*");
        Boolean f=solution.solution(list);
    }
}
