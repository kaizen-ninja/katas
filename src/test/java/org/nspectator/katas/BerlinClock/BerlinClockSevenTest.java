package org.nspectator.katas.BerlinClock;
import org.junit.Assert;
import org.junit.Test;

import static org.hamcrest.CoreMatchers.equalTo;
import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.core.Is.*;

public class BerlinClockSevenTest {

    private BerlinClockSeven berlinClock = new BerlinClockSeven();

    // Yellow lamp should blink on/off every two seconds
    @Test
    public void testYellowLampShouldBlinkOnOffEveryTwoSeconds() {
        assertThat("Y", is(equalTo(berlinClock.getSeconds(0))));
        assertThat("O", is(equalTo(berlinClock.getSeconds(1))));
        assertThat("O", is(equalTo(berlinClock.getSeconds(59))));
    }

    // Top hours should have 4 lamps
    @Test
    public void testTopHoursShouldHave4Lamps() {
        assertThat(4, is(equalTo(berlinClock.getTopHours(7).length())));
    }

    // Top hours should light a red lamp for every 5 hours
    @Test
    public void testTopHoursShouldLightRedLampForEvery5Hours() {
        assertThat("OOOO", is(equalTo(berlinClock.getTopHours(0))));
        assertThat("RROO", is(equalTo(berlinClock.getTopHours(13))));
        assertThat("RRRR", is(equalTo(berlinClock.getTopHours(23))));
        assertThat("RRRR", is(equalTo(berlinClock.getTopHours(24))));
    }

    // Bottom hours should have 4 lamps
    @Test
    public void testBottomHoursShouldHave4Lamps() {
        assertThat(4, is(equalTo(berlinClock.getBottomHours(5).length())));
    }

    // Bottom hours should light a red lamp for every hour left from top hours
    @Test
    public void testBottomHoursShouldLightRedLampForEveryHourLeftFromTopHours() {
        assertThat("OOOO", is(equalTo(berlinClock.getBottomHours(0))));
        assertThat("RRRO", is(equalTo(berlinClock.getBottomHours(13))));
        assertThat("RRRO", is(equalTo(berlinClock.getBottomHours(23))));
        assertThat("RRRR", is(equalTo(berlinClock.getBottomHours(24))));
    }

    // Top minutes should have 11 lamps
    @Test
    public void testTopMinutesShouldHave11Lamps() {
        assertThat(11, is(equalTo(berlinClock.getTopMinutes(34).length())));
    }

    // Top minutes should have 3rd, 6th and 9th lamps in red to indicate first quarter, half and last quarter
    @Test
    public void testTopMinutesShouldHave3rd6thAnd9thLampsInRedToIndicateFirstQuarterHalfAndLastQuarter() {
        String minutes32 = berlinClock.getTopMinutes(32);
        assertThat("R", is(equalTo(minutes32.substring(2, 3))));
        assertThat("R", is(equalTo(minutes32.substring(5, 6))));
        assertThat("O", is(equalTo(minutes32.substring(8, 9))));
    }

    // Top minutes should light a yellow lamp for every 5 minutes unless it's first quarter, half or last quarter
    @Test
    public void testTopMinutesShouldLightYellowLampForEvery5MinutesUnlessItIsFirstQuarterHalfOrLastQuarter() {
        assertThat("OOOOOOOOOOO", is(equalTo(berlinClock.getTopMinutes(0))));
        assertThat("YYROOOOOOOO", is(equalTo(berlinClock.getTopMinutes(17))));
        assertThat("YYRYYRYYRYY", is(equalTo(berlinClock.getTopMinutes(59))));
    }

    // Bottom minutes should have 4 lamps
    @Test
    public void testBottomMinutesShouldHave4Lamps() {
        assertThat(4, is(equalTo(berlinClock.getBottomMinutes(0).length())));
    }

    // Bottom minutes should light a yellow lamp for every minute left from top minutes
    @Test
    public void testBottomMinutesShouldLightYellowLampForEveryMinuteLeftFromTopMinutes() {
        assertThat("OOOO", is(equalTo(berlinClock.getBottomMinutes(0))));
        assertThat("YYOO", is(equalTo(berlinClock.getBottomMinutes(17))));
        assertThat("YYYY", is(equalTo(berlinClock.getBottomMinutes(59))));
    }

    // Berlin Clock should result in array with 5 elements
    @Test
    public void testBerlinClockShouldResultInArrayWith5Elements() {
        assertThat(5, is(equalTo(berlinClock.convertToBerlinTime("13:17:01").length)));
    }

    // Berlin Clock it should "result in correct seconds, hours and minutes" in {
    @Test
    public void testBerlinClockShouldResultInCorrectSecondsHoursAndMinutes() {
        String[] berlinTime = berlinClock.convertToBerlinTime("16:37:16");
        String[] expected = new String[]{"Y", "RRRO", "ROOO", "YYRYYRYOOOO", "YYOO"};
        assertThat(expected.length, is(equalTo(berlinTime.length)));
        for (int index = 0; index < expected.length; index++) {
            assertThat(expected[index], is(equalTo(berlinTime[index])));
        }
    }
}
