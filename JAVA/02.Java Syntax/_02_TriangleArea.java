import java.util.Scanner;

public class _02_TriangleArea {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter Ax: ");
        double aX = scanner.nextDouble();

        System.out.print("Enter Ay: ");
        double aY = scanner.nextDouble();

        System.out.print("Enter Bx: ");
        double bX = scanner.nextDouble();

        System.out.print("Enter By: ");
        double bY = scanner.nextDouble();

        System.out.print("Enter Cx ");
        double cX = scanner.nextDouble();

        System.out.print("Enter Cy: ");
        double cY = scanner.nextDouble();
        double area = Math.abs((aX*(bY-cY)+ bX*(cY-aY)+ cX*(aY-bY))/2);

        if (area != 0.0) {
            System.out.printf("Triangle area is: %.2f", area);
        }
        else {
            System.out.println("There is no such triangle!");
            System.out.println("0");
        }
    }
}
