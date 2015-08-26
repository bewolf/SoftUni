import java.util.Scanner;

public class Problem_06_SumTwoNumbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int firstNumber = scanner.nextInt();
        int secondNumber = scanner.nextInt();

        int sum = firstNumber+secondNumber;

        System.out.println(sum);
    }
}
