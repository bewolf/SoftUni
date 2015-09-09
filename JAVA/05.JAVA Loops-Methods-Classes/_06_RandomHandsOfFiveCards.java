import java.util.Locale;
import java.util.Random;
import java.util.Scanner;

public class _06_RandomHandsOfFiveCards {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter number of hands: ");
        int numberOfHands = scanner.nextInt();
        String[] suits = new String[]{"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
        String[] faces = new String[]{"\u2660","\u2665","\u2666","\u2663"};
        Random random = new Random();
        //haven't time for correct locale to show suits correct
        for (int i = 0; i < numberOfHands; i++) {
            for (int j = 0; j < 5; j++) {
                String suit = suits[random.nextInt(13)];
                String face = faces[random.nextInt(4)];
                System.out.printf("%s%s ",face,suit);
            }
            System.out.println();
        }
    }
}
