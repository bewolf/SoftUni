import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.temporal.ChronoUnit;
import java.util.Date;
import java.util.Scanner;

public class _07_DaysBetweenTwoDates {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String formatDateString = "dd-MM-yyyy";
        DateFormat formatDate = new SimpleDateFormat(formatDateString);

        System.out.printf("Enter date and time in the format %s\r\n", formatDateString);
        System.out.println("For example, it is now " + formatDate.format(new Date()));
        try {
            Date firstDate = formatDate.parse(scanner.nextLine());
            Date secondDate = formatDate.parse(scanner.nextLine());

            int daysBetween =(int)( (secondDate.getTime() - firstDate.getTime()) / (1000 * 60 * 60 * 24)); //works only for timezone where you havent daylight saving time!
            System.out.printf("Difference is %d days", daysBetween);
        } catch (ParseException e) {
            System.out.printf("Sorry, that's not valid date. Try again with format %s",formatDateString);
        }
    }
}