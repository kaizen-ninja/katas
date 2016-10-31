package Main;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by v-kru on 31.10.2016.
 */
public class BerlinClock {
    public String[] convertToBerlinTime(String time) {
        List<Integer> parts = new ArrayList<Integer>();
        for (String part : time.split(":")) {
            parts.add(Integer.parseInt(part));
        }
        return new String[] {
                getSeconds(parts.get(2)),
                getTopHours(parts.get(0)),
                getBottomHours(parts.get(0)),
                getTopMinutes(parts.get(1)),
                getBottomMinutes(parts.get(1))
        };
    }

    public String getSeconds(int number) {
        if (number % 2 == 0) return "Y";
        else return "O";
    }

    public String getTopHours(int number) {
        return getOnOff(4, getTopNumberOfOnSigns(number));
    }

    public String getBottomHours(int number) {
        return getOnOff(4, number % 5);
    }

    public String getTopMinutes(int number) {
        return getOnOff(11, getTopNumberOfOnSigns(number), "Y").replaceAll("YYY", "YYR");
    }

    public String getBottomMinutes(int number) {
        return getOnOff(4, number % 5, "Y");
    }

    public String getOnOff(int lamps, int onSigns) {
        return getOnOff(lamps, onSigns, "R");
    }
    public String getOnOff(int lamps, int onSigns, String onSign) {
        String out = "";
        for (int i = 0; i < onSigns; i++) {
            out += onSign;
        }
        for (int i = 0; i < (lamps - onSigns); i++) {
            out += "O";
        }
        return out;
    }

    public int getTopNumberOfOnSigns(int number) {
        return (number - (number % 5)) / 5;
    }
}
