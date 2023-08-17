
import java.util.Scanner;

public class Height {
    public static void main(String args[]) {
        
        float h, f;
        
        Scanner scan = new Scanner(System.in);
        System.out.print("Enter Height of a person in Centimetre: ");
        h = scan.nextFloat();
        
        f=(float) (h/30.48);
        System.out.println("Height of the person in Feet: "+ f);
        scan.close();
    }
}