public class ReFactorial {
    private static int operationCount = 0;

    public static int factorialRecursive(int n) {
        operationCount++;  
        if (n == 0 || n == 1) {
            operationCount++;  
            return 1;
        }
        return n * factorialRecursive(n - 1);
    }

    public static void main(String[] args) {
        int num = 5; 
        operationCount = 0;  
        int result = factorialRecursive(num);
        System.out.println("Factorial (Recursive) of " + num + " is: " + result);
        System.out.println("Number of Primitive Operations: " + operationCount);
    }    
}
