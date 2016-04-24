package org.nspectator.katas.LeapYear;

import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.is;

import org.junit.Before;
import org.junit.Test;

public class LeapYearTest {

	private LeapYear leapYear;

	@Before
	public void setUp() throws Exception {
		leapYear = new LeapYear();
	}

	@Test
	public void when1996_thenIsLeap() {
		boolean isLeap = isLeap(1996);
		assertThat(isLeap, is(true));
	}

	@Test
	public void when2001_thenIsNotLeap() {
		boolean isLeap = this.isLeap(2001);
		assertThat(isLeap, is(false));
	}

	@Test
	public void when1900_thenIsNotLeap() {
		assertThat(this.isLeap(1900), is(false));
	}

	@Test
	public void when2000_thenIsLeap() {
		assertThat(isLeap(2000), is(true));
	}

	private boolean isLeap(int year) {
		return leapYear.isLeap(year);
	}
}
