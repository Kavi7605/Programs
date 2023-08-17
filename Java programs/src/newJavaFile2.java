
import java.util.Scanner;

public class newJavaFile2 {
    public static void main(String args[]) {
        int h, f;
        Scanner scan = new Scanner(System.in);
        h = scan.nextInt();
        f=(int) (h/30.48);
        System.out.println(f);
        scan.close();
    }
}
