
import java.util.Scanner;

public class NewClass {
    public static void main(String[] args) {
        
        
        Scanner scan = new Scanner(System.in);
        System.out.printf("Enter a string: ");
        String a = scan.next();
        System.out.println("String you entered is: "+ a);
        
        String tmpf="";
        for(int i=a.length()-1;i>=0;i--){
            tmpf=tmpf+a.charAt(i);
        }
        System.out.println("Reverse String with FOR loop:"+ tmpf);
        
        String tmpw="";
        int j=a.length()-1;
        while(j>=0){
            tmpw=tmpw+a.charAt(j);
            j--;
        }
        System.out.println("Reverse String with WHILE loop:"+ tmpw);
        scan.close();
    }
}
