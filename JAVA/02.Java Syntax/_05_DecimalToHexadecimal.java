import java.util.Scanner;

public class _05_DecimalToHexadecimal {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter decimal number: ");
        int decimalNumber = Integer.parseInt(scanner.next());

        String hexString = Integer.toHexString(decimalNumber).toUpperCase();

        System.out.printf("Integer number %d is %s in Hexadecimal format.",decimalNumber, hexString);
    }
}