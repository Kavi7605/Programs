import java.util.Scanner;
public class swapme {
    public static void main(String args[]) {
        Scanner scan = new Scanner(System.in);
        int tmp;
        int a,b;
        System.out.println("Enter first number : ");
        a = scan.nextInt();
        System.out.println("Enter second number : ");
        b = scan.nextInt();
        System.out.println("Before SWAP:"+ a + ", "+ b);
        tmp=a;
        a=b;
        b=tmp;
        System.out.println("After SWAP:"+ a + ", "+ b);
        scan.close();
    }
}