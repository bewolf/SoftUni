import java.awt.geom.Path2D;
import java.util.Scanner;

public class _03_PointsInsideAFigure {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Path2D.Double poligon = new Path2D.Double();
        poligon.moveTo(12.5, 6);
        poligon.lineTo(22.5, 6);
        poligon.lineTo(22.5, 13.5);
        poligon.lineTo(20,13.5);
        poligon.lineTo(20,8.5);
        poligon.lineTo(17.5,8.5);
        poligon.lineTo(17.5,13.5);
        poligon.lineTo(12.5,13.5);
        poligon.lineTo(12.5,6);
        poligon.closePath();

        System.out.print("Enter X coord: ");
        double xCoord = Double.parseDouble(scanner.next());

        System.out.print("Enter Y coord: ");
        double yCoord = Double.parseDouble(scanner.next());

        if (poligon.contains(xCoord, yCoord)) {
            System.out.printf("%.2f X coord and %.2f Y.2 coord is Inside", xCoord, yCoord);
        } else {
            System.out.printf("%.2f X coord and %.2f Y coord is Outside", xCoord, yCoord);
        }
    }
}
