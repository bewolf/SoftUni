import java.util.Scanner;

public class _01_SymmetricNumbersInRange {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter start number: ");
        int startNumber = scanner.nextInt();
        System.out.print("Enter end number: ");
        int endNumber = scanner.nextInt();

        if (startNumber < 0 || startNumber > endNumber || endNumber > 999){
            System.out.println("Incorect input. Input must be in range 0 < Start Number < End Number < 999");
        }

        for (int i = startNumber; i <= endNumber; i++) {
            String stringNumber = Integer.toString(i);
            StringBuilder reversedNumber = new StringBuilder(stringNumber).reverse();

            if (stringNumber.equals(reversedNumber.toString())) {
                System.out.printf("%s ", stringNumber);
            }
        }
    }
}
