import java.util.Scanner;

class Factorial2{
  static int factorial(int n){
    if (n == 0)
      return 1;
    else
      return(n * factorial(n-1));
  }
  public static void main(String args[]){
    Scanner sc = new Scanner(System.in);
    int fact=1;
    int number;
    System.out.println("Enter number: ");
    number = sc.nextInt();
    fact = factorial(number);
    System.out.println("Factorial of "+number+" is: "+fact);
    sc.close();
  }
}