import java.util.Scanner;

public class asmd{
    Scanner sc = new Scanner(System.in);
    public void add(){    
        System.out.print("Enter value for A: ");
        int a = sc.nextInt();
        System.out.print("Enter value for B: ");
        int b = sc.nextInt();  
        int c = a + b;
        System.out.println("Answer: " + c);
        sc.close();
    }public void sub(){    
        System.out.print("Enter value for A: ");
        int a = sc.nextInt();
        System.out.print("Enter value for B: ");
        int b = sc.nextInt();  
        int c = a - b;
        System.out.println("Answer: " + c);
        sc.close();
    }
    public void mul(){    
        System.out.print("Enter value for A: ");
        int a = sc.nextInt();
        System.out.print("Enter value for B: ");
        int b = sc.nextInt();  
        int c = a * b;
        System.out.println("Answer: " + c);
        sc.close();
    }
    public void div(){    
        System.out.print("Enter value for A: ");
        int a = sc.nextInt();
        System.out.print("Enter value for B: ");
        int b = sc.nextInt();  
        int c = a / b;
        System.out.println("Answer: " + c);
        sc.close();
    }
}
