
import java.util.Scanner;


public class PostiveNegative {
    public static void main(String[] args) {
        double a;
        System.out.print("Enter a number: ");
        Scanner scan = new Scanner(System.in);
        a = scan.nextDouble();
        if(a>=0){
            System.out.println("The number you entered is a positive number.");
        }
        else{
            System.out.println("The number you entered is a negatve number.");
        }
        scan.close();
    }
}