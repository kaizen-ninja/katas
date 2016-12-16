package org.nspectator.katas.lcddigits;

import java.util.*;

/**
 * Created by nkondrina on 16.12.2016.
 */
public class LCDDigits {

    List<Map<String,String>> value=new ArrayList<>();

    public void solution(String inputNumber, Long number)
    {
        for (Integer j=0; j<3; j++)
            System.out.println(Str(j,inputNumber, number) + " ");
    }

    public String Str(Integer j, String inputNumber, Long number)
    {
        String s="";

        if (j<0 || j>2 || number<0 || !number.toString().equals(inputNumber))
            return "";

        if (value.size()==0)
            CreateDictionary();

        for (Integer i = 0; i < inputNumber.length(); i++)
            s+=value.get(j).get(inputNumber.substring(i, i + 1)) + " ";

        return s;
    }

    private void CreateDictionary()
    {
        Map<String, String> map;

        map = new HashMap<>();
        map.put("0","._.");
        map.put("1","...");
        map.put("2","._.");
        map.put("3","._.");
        map.put("4","...");
        map.put("5","._.");
        map.put("6","._.");
        map.put("7","._.");
        map.put("8","._.");
        map.put("9","._.");
        value.add(map);

        map = new HashMap<>();
        map.put("0","|.|");
        map.put("1","..|");
        map.put("2","._|");
        map.put("3","._|");
        map.put("4","|_|");
        map.put("5","|_.");
        map.put("6","|_.");
        map.put("7","..|");
        map.put("8","|_|");
        map.put("9","|_|");
        value.add(map);

        map = new HashMap<>();
        map.put("0","|_|");
        map.put("1","..|");
        map.put("2","|_.");
        map.put("3","._|");
        map.put("4","..|");
        map.put("5","._|");
        map.put("6","|_|");
        map.put("7","..|");
        map.put("8","|_|");
        map.put("9","..|");
        value.add(map);
    }

    public void InputNumbersAndRunSolution()
    {
        Scanner sc = new Scanner(System.in);
        String s="";

        while(true)
        {
            try {
                s=sc.next();
                if (Long.parseLong(s)>=0)
                    solution(s, Long.parseLong(s));
                else
                    throw new Exception("Number is not positive!");
            }
            catch (Exception e)
            {
                if (s.equals("yes")) {
                    System.out.println("Exit...");
                    return;
                }
                else
                    System.out.println("Permission is not an integer! Enter yes for exit! " + e.getMessage());
            }
        }
    }

    public static void main(String[] args) {
        System.out.println("Enter integer number:");
        LCDDigits task = new LCDDigits();
        task.InputNumbersAndRunSolution();
    }
}
