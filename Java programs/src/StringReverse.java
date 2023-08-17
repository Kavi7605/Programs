
import java.util.Scanner;

public class StringReverse {
    public static void main(String[] args) {
        char str[] = new char[20];
        Scanner scan = new Scanner(System.in);
        System.out.print("Enter a string:");
        str=scan.next().toCharArray();
        for(int i=0;i<str.length/2;i++){
            char tmp;
            tmp=str[i];
            str[i]=str[str.length-1-i];
            str[str.length-1-i]=tmp;
        }
   
        System.out.print("Reverse:");
        for(int j=0;j<str.length;j++){
            System.out.print(str[j]);
        }
        System.out.println("");
        scan.close();
    }
}
