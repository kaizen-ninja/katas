package org.nspectator.katas.BerlinClock;

import org.junit.Assert;
import org.junit.Test;

import static org.hamcrest.CoreMatchers.equalTo;
import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.core.Is.*;
public class BerlinClockTest {

    BerlinClock berlinClock = new BerlinClock();

    // Yellow lamp should blink on/off every two seconds
    @Test
    public void testYellowLampShouldBlinkOnOffEveryTwoSeconds() {
        Assert.assertEquals("Y", berlinClock.getSeconds(0));
        Assert.assertEquals("O", berlinClock.getSeconds(1));
        Assert.assertEquals("O", berlinClock.getSeconds(59));
    }

    // Top hours should have 4 lamps
    @Test
    public void testTopHoursShouldHave4Lamps() {
        Assert.assertEquals(4, berlinClock.getTopHours(7).length());
    }

    // Top hours should light a red lamp for every 5 hours
    @Test
    public void testTopHoursShouldLightRedLampForEvery5Hours() {
        Assert.assertEquals("OOOO", berlinClock.getTopHours(0));
        Assert.assertEquals("RROO", berlinClock.getTopHours(10));
        Assert.assertEquals("RRRR", berlinClock.getTopHours(22));
        Assert.assertEquals("RRRO", berlinClock.getTopHours(18));
    }

    // Bottom hours should have 4 lamps
    @Test
    public void testBottomHoursShouldHave4Lamps() {
        Assert.assertEquals(4, berlinClock.getBottomHours(5).length());
    }

    // Bottom hours should light a red lamp for every hour left from top hours
    @Test
    public void testBottomHoursShouldLightRedLampForEveryHourLeftFromTopHours() {
        Assert.assertEquals("OOOO", berlinClock.getBottomHours(0));
        Assert.assertEquals("RRRO", berlinClock.getBottomHours(03));
        Assert.assertEquals("RROO", berlinClock.getBottomHours(22));
        Assert.assertEquals("RRRR", berlinClock.getBottomHours(24));
        Assert.assertEquals("ROOO", berlinClock.getBottomHours(11));
    }

    // Top minutes should have 11 lamps
    @Test
    public void testTopMinutesShouldHave11Lamps() {
        Assert.assertEquals(11, berlinClock.getTopMinutes(34).length());
    }

    // Top minutes should have 3rd, 6th and 9th lamps in red to indicate first quarter, half and last quarter
    @Test
    public void testTopMinutesShouldHave3rd6thAnd9thLampsInRedToIndicateFirstQuarterHalfAndLastQuarter() {
        String minutes32 = berlinClock.getTopMinutes(32);
        Assert.assertEquals("R", minutes32.substring(2, 3));
        Assert.assertEquals("R", minutes32.substring(5, 6));
        Assert.assertEquals("O", minutes32.substring(8, 9));
    }

    // Top minutes should light a yellow lamp for every 5 minutes unless it's first quarter, half or last quarter
    @Test
    public void testTopMinutesShouldLightYellowLampForEvery5MinutesUnlessItIsFirstQuarterHalfOrLastQuarter() {
        Assert.assertEquals("OOOOOOOOOOO", berlinClock.getTopMinutes(0));
        Assert.assertEquals("YYROOOOOOOO", berlinClock.getTopMinutes(17));
        Assert.assertEquals("YYRYYOOOOOO", berlinClock.getTopMinutes(27));
        Assert.assertEquals("YYRYYRYYRYY", berlinClock.getTopMinutes(56));
    }

    // Bottom minutes should have 4 lamps
    @Test
    public void testBottomMinutesShouldHave4Lamps() {
        Assert.assertEquals(4, berlinClock.getBottomMinutes(0).length());
    }

    // Bottom minutes should light a yellow lamp for every minute left from top minutes
    @Test
    public void testBottomMinutesShouldLightYellowLampForEveryMinuteLeftFromTopMinutes() {
        Assert.assertEquals("OOOO", berlinClock.getBottomMinutes(0));
        Assert.assertEquals("YYOO", berlinClock.getBottomMinutes(17));
        Assert.assertEquals("YYYY", berlinClock.getBottomMinutes(59));
    }

    // Berlin Clock should result in array with 5 elements
    @Test
    public void testBerlinClockShouldResultInArrayWith5Elements()  {
        Assert.assertEquals(5, berlinClock.convertToBerlinTime("13:17:01").length);
    }

    // Berlin Clock it should "result in correct seconds, hours and minutes" in {
    @Test
    public void testBerlinClockShouldResultInCorrectSecondsHoursAndMinutes() {
        String[] berlinTime = berlinClock.convertToBerlinTime("16:37:16");
        String[] expected = new String[] {"Y", "RRRO", "ROOO", "YYRYYRYOOOO", "YYOO"};
        Assert.assertEquals(expected.length, berlinTime.length);
        for (int index = 0; index < expected.length; index++) {
            Assert.assertEquals(expected[index], berlinTime[index]);
        }
    }

}
