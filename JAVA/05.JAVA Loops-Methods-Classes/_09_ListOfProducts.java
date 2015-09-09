import java.awt.geom.Path2D;
import java.io.*;
import java.util.*;

public class _09_ListOfProducts {
    public static void main(String[] args) throws FileNotFoundException {

        try (BufferedReader fileReader = new BufferedReader(new FileReader("src/next input.txt"))) {
            ArrayList<String> priceAndProduct = new ArrayList<>();
            FileWriter writer = new FileWriter("src/output.txt");

            while (true) {
                String line = fileReader.readLine();
                if (line == null) {
                    break;
                }
                String[] productAndPrice = line.split(" ");
                priceAndProduct.add(productAndPrice[1] + " " + productAndPrice[0]);
            }
            Collections.sort(priceAndProduct);

            for (String products : priceAndProduct) {
                writer.write(products);
            }
            writer.close();

            //didn't write to file... haven't time to fix it :S
            for (String price : priceAndProduct) {
                System.out.println(price);
            }

        } catch (IOException ioex) {
            System.out.println("Error");
        }

    }
}
