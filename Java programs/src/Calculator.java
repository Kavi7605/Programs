import java.util.Scanner;

public class Calculator {
    public static void main(String[] args) {
        asmd ob1 = new asmd();
        Scanner sc = new Scanner(System.in);
        Boolean flag = true;
        while(flag == true){
            System.out.println("Different Operations: \n1. Addition \n2. Substraction \n3. Multiplication \n4. Division \n5.Exit");    
            System.out.print("Enter your choice: ");
            String choice = sc.nextLine();
            switch (choice) {
                case "1":
                    ob1.add();
                    break;
                case "2":
                    ob1.sub();
                    break;
                case "3":
                    ob1.mul();
                    break;
                case "4":
                    ob1.div();
                    break;
                case "5":
                    System.out.println("You exited the Calculator.");
                    flag = false;
                    break;
                default:
                    System.out.println("ERROR: Invalid Choice.");
                    System.out.println();
                    break;
            }
        }
        sc.close();
    }
}
