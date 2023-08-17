
import java.util.Scanner;

public class Vowel {
    public static void main(String[] args) {
        char alp;
        System.out.print("Enter alphabet: ");    
        Scanner scan = new Scanner(System.in);
        alp = scan.next().charAt(0);
        
        switch(alp)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                System.out.println(alp +" is a vowel.");
                break;
            default:
                System.out.println(alp +" is a consonant.");
        }
    }
}
