public class ItFactorial {
    private static int operationCount = 0;

    public static int factorialIterative(int n) {
        int result = 1;
        operationCount++;  
        for (int i = 1; i <= n; i++) {
            operationCount++;   
            operationCount++;  
            result *= i;
            operationCount++;  
            operationCount++;  
        }
        return result;
    }

    public static void main(String[] args) {
        int num = 5; 
        operationCount = 0;  
        int result = factorialIterative(num);
        System.out.println("Factorial (Iterative) of " + num + " is: " + result);
        System.out.println("Number of Primitive Operations: " + operationCount);
    }    
}
