import java.util.Scanner;

class kuchbhi{
    public static int hmm(int a ,int b, char op){
        if(op == '+'){
            return a + b;
        }else if(op=='-'){
            return a - b;
        }else if(op == '*'){
            return a * b;
        }
        else if(op=='/'){
            return a / b;
        }
        return Integer.MIN_VALUE;
    }
    public static void main(String[] s){
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter value for A: ");
        int a = sc.nextInt();
        System.out.print("Enter value for B: ");
        int b = sc.nextInt();  
        System.out.print("Enter your required operator(+,-,*,/): ");
        char op = sc.next().charAt(0);
        if(hmm(a, b, op) == -2147483648){
            System.out.print("Invalid operator.");
        }
        else{
            System.out.println(hmm(a,b,op));
        }
        sc.close();
    }
}