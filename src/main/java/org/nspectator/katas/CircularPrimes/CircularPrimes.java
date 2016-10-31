package org.nspectator.katas.circularprimes;

import java.util.ArrayList;
import java.util.List;

class CircularPrimes {
    List<Integer> list
            = new ArrayList<Integer>();
    int count = 0;
    boolean flag = true;
    int n;

    CircularPrimes(int n) {
        this.n = n;
    }

    public void Numbers() {
        for (int i = 2; i <= n; i++) {
            if (isSimple(i)) {
                list.add(i);
            }
        }
    }

    private boolean isSimple(double x) {
        double sqrtX = Math.sqrt(x);
        for (int i = 2; i <= sqrtX; i++)
            if (x % i == 0) return false;
        return true;
    }

    private int Shift(int number) {
        String num = number + "";
        char[] chars = num.toCharArray();
        num = "";
        char save;
        save = chars[0];

        for(int i = 1; i < chars.length; i++) {
            chars[i - 1] = chars[i];
            num += chars[i - 1];
        }
        num += save;
        number = Integer.parseInt(num);
        chars = null;
        return number;
    }

    private void NumberCheck(int number, int stop) {
        int count = 0;
        String num = number + "";
        char[] chars = num.toCharArray();
        int numer;

        for (int i = 0; i < chars.length; i++ ) {
            numer = Integer.parseInt(chars[i]+"");
            if (chars.length > 2
                    && numer % 2 == 0)
            count++;
        }

        if (count == 0) {
            number = Shift(number);
            if (number == stop)
                flag = true;
            else if (isSimple(number))
                NumberCheck(number, stop);
            else
                flag = false;
        }
        else flag = false;
    }

    public int TestNumb() {
        for(int i = 0; i < list.size(); i++) {
            NumberCheck(list.get(i), list.get(i));
            if (flag) {
                count++;
            }
            flag = true;
        }
        return count;
    }
}
