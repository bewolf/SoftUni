import java.util.Scanner;

public class _01_RectangleArea {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double firstSide = scanner.nextDouble();
        double secondSide = scanner.nextDouble();

        double rectangleArea = firstSide * secondSide;
        System.out.printf("Rectangle are is: %f", rectangleArea);
    }
}
