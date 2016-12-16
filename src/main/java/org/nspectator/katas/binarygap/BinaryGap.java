package org.nspectator.katas.binarygap;

/**
 * Created by nkondrina on 11.12.2016.
 */
public class BinaryGap {
    public Integer solution(Integer N)
    {
        String str= Integer.toBinaryString(N);
        Integer len=str.length()-1;
        Integer maxLength=0, length,j=0, k;

        if (N<1)
            return -2;

        while (len>=0 && str.charAt(len)=='0')
            len--;

        while (j<=len) {
            while (j <= len && str.charAt(j) == '1')
                j++;

            length = 0;
            while (j <= len && str.charAt(j) == '0') {
                length++;
                j++;
            }

            if (length>maxLength)
                maxLength=length;
        }

        return  maxLength;
    }

    public static void main(String[] args) {
        BinaryGap solution1 = new BinaryGap();

        Integer it = solution1.solution(Integer.parseInt("110001101000011", 2));
    }
}
