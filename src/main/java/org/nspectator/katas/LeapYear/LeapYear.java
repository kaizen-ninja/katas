package org.nspectator.katas.LeapYear;

public class LeapYear {

	public boolean isLeap(int year) {
		boolean result = isMultipleOf4(year) && 
				isNotMiltipleOf100_or_isMiltipleOf100And400(year);
		return result;
	}

	private boolean isNotMiltipleOf100_or_isMiltipleOf100And400(int year) {
		return (isNotMiltipleOf100(year) || (isMiltipleOf100And400(year)) );
	}

	private boolean isMiltipleOf100And400(int year) {
		return isMultipleOf(year, 100) && isMultipleOf(year, 400);
	}

	private boolean isNotMiltipleOf100(int year) {
		return !isMultipleOf(year, 100);
	}

	private boolean isMultipleOf4(int i) {
		return isMultipleOf(i, 4);
	}
	
	private boolean isMultipleOf(int num, int base) {
		return ((num % base) == 0);
	}

}
