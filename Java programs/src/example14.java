import java.util.Scanner;

public class example14 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter value for A: ");
        int a = scan.nextInt();
        System.out.println("Enter value for B: ");
        int b = scan.nextInt();
        System.out.println("The Value of A + B is: ");
        System.out.println(sum(a, b));
        scan.close();
    }
    public static int sum(int a, int b)  
    {  
        int c=a+b;  
        return c;  
    }  
}