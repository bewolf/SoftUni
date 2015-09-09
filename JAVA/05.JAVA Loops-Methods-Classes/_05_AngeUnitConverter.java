import java.util.ArrayList;
import java.util.Scanner;

public class _05_AngeUnitConverter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter number n for query: ");
        int n = Integer.parseInt(scanner.nextLine());
        ArrayList<String> units = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            System.out.print("Enter number + rad/deg: ");
            String nextLine = scanner.nextLine();
            String[] input = nextLine.split(" ");
            double number = Double.parseDouble(input[0]);
            if (number == 0){
                //units.add(i, ); //TODO
                continue;
            } else if (input[1].equals("deg")){
                number = Math.toRadians(Double.parseDouble(input[0]));
                units.add(i, number + " rad");
            } else  {
                number = Math.toDegrees(Double.parseDouble(input[0]));
                units.add(i, number + " deg");
            }
        }
        for (String unit : units) {
            System.out.println(unit);
        }
    }
}
