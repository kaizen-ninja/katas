package org.nspectator.katas.circularprimes;

import org.junit.Before;
import org.junit.Test;

import static junit.framework.Assert.assertEquals;

public class TestCircularPrimes {
    CircularPrimes cP1;
    CircularPrimes cP2;
    CircularPrimes cP3;
    CircularPrimes cP4;
    CircularPrimes cP5;
    CircularPrimes cP6;

    @Before
    public void untilIsStarting() {
        cP1 = new CircularPrimes(10);
        cP2 = new CircularPrimes(100);
        cP3 = new CircularPrimes(1000);
        cP4 = new CircularPrimes(10000);
        cP5 = new CircularPrimes(100000);
        cP6 = new CircularPrimes(1000000);
    }

    @Test
    public void testWithTen() {
        cP1.Numbers();
        assertEquals(4,cP1.TestNumb());
    }

    @Test
    public void testWithHundred() {
        cP2.Numbers();
        assertEquals(13,cP2.TestNumb());
    }

    @Test
    public void testWithThousand() {
        cP3.Numbers();
        assertEquals(25,cP3.TestNumb());
    }

    @Test
    public void testWithTenThousands() {
        cP4.Numbers();
        assertEquals(33,cP4.TestNumb());
    }

    @Test
    public void testWithHundredOfThousands() {
        cP5.Numbers();
        assertEquals(43,cP5.TestNumb());
    }

    @Test
    public void testWithMillion() {
        cP6.Numbers();
        assertEquals(55,cP6.TestNumb());
    }
}
