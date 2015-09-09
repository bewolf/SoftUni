import java.io.*;
import java.nio.file.Files;
import java.nio.file.Paths;

public class _08_SumNumbersFromATextFile {
    public static void main(String[] args) throws IOException {
        try {
            String inputString = new String(Files.readAllBytes(Paths.get("src/input.txt")));
            String patern = "\r\n";
            String[] numbers = inputString.split(patern);
            int sum = 0;
            for (int i = 0; i < numbers.length; i++) {
                sum += Integer.parseInt(numbers[i]);
            }
            System.out.printf("The sum of numbers in file is %d", sum);
        } catch (IOException ioEx){
            System.out.println("Error");
        }
    }
}
