import java.util.Scanner;

class upprlower{
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("1. UpperCase \n 2. LowerCase \n 3.Exit \n Choose your operation: ");
        int n;
        n = scan.nextInt();
        scan.nextLine();
        boolean flag = true;
        while (flag){
            switch(n){
                case 1:
                    System.out.println("Please Enter Lowercase String: ");
                    String str = scan.nextLine();
                    String str2 = str.toUpperCase();
                    System.out.println("\nThe Uppercase String  =  " + str2);
                    break;
                case 2:
                    System.out.println("\nPlease Enter Upper Case:  ");
                    String str3 = scan.nextLine();
                    String str4 = str3.toLowerCase();
                    System.out.println("\nThe Lowercase String  =  " + str4);
                    break;
                case 3:
                    System.out.println("You just exited the program.");
                    flag = false;
                    break;
                default:
                    System.out.println("\nInvalid Input");
                    break;
            }
        }
        scan.close();
    }
}