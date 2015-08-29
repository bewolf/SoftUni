import java.util.Scanner;

public class _07_CountOfBitsOne {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter an integer number: ");
        int number = Integer.parseInt(scanner.next());
        String binaryNum = Integer.toBinaryString(number);
        int count =0;
        for (int i = 0; i < binaryNum.length(); i++){
            if (binaryNum.charAt(i) == '1'){
                count++;
            }
        }
        System.out.printf("There have %d '1' in this number.", count);
    }
}
