import java.util.Scanner;

public class _04_TheSmallestOf3Numbers {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter array size: ");
        int arraySize = Integer.parseInt(scanner.next());
        double[] smallestNumberArray = new double[arraySize];

        for (int i = 0; i < smallestNumberArray.length; i++) {
            System.out.printf("Enter %d more numbers: ", arraySize - i);
            smallestNumberArray[i] = scanner.nextDouble();
        }

        double min = Double.MAX_VALUE;
        for (int i = 0; i < smallestNumberArray.length; i++) {
            if (smallestNumberArray[i] < min) {
                min = smallestNumberArray[i];
            }
        }

        System.out.printf("Smallest member of array is: %.2f", min);
    }
}
