import java.util.Scanner;

public class Factorial {
    public static void main(String args[]) {
        Scanner sc = new Scanner(System.in);
        int n, f=1, i;
        n = sc.nextInt();
        for(i=1;i<=n;i++){
            f=f*i;
        }
        System.out.println("Factorial of "+ n+" is "+ f);
        sc.close();
    }
}