import java.util.Scanner;

public class _02_GenerateThreeLetterWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter three characters: ");
        String inputCharacters = scanner.next();
        char[] inputCharsArray = inputCharacters.toLowerCase().trim().toCharArray();

        for (int i = 0; i < inputCharsArray.length; i++) {
            for (int j = 0; j < inputCharsArray.length; j++) {
                for (int k = 0; k < inputCharsArray.length; k++) {
                    System.out.printf("%c%c%c ", inputCharsArray[i],inputCharsArray[j], inputCharsArray[k]);
                }
            }
        }
    }
}
