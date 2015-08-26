import java.util.Arrays;
import java.util.Scanner;

public class Problem_08_SortArrayOfStrings {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int arraySize = scanner.nextInt();
        String[] inputArray = new String[arraySize];

            for (int i = 0; i < inputArray.length; i++) {
                inputArray[i] = scanner.next();
            }
            Arrays.sort(inputArray);

            for (int j = 0; j < inputArray.length; j++) {
                System.out.println(inputArray[j]);
            }
    }
}
