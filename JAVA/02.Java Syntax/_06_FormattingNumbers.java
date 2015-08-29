import java.util.Scanner;

public class _06_FormattingNumbers {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter first Integer number: ");
        int firstIntNumber = Integer.parseInt(scanner.next());

        System.out.print("Enter first Floating point number: ");
        double firstFloatingPointNumber = Double.parseDouble(scanner.next());

        System.out.print("Enter second Floating point number: ");
        double secondFloatingPointNumber = Double.parseDouble(scanner.next());

        System.out.printf("|%-10s|%010d|%10.2f|%-10.3f|",
                Integer.toHexString(firstIntNumber).toUpperCase(),
                Integer.parseInt(Integer.toBinaryString(firstIntNumber)),
                firstFloatingPointNumber,
                secondFloatingPointNumber);
    }
}
