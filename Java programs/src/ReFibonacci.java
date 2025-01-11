public class ReFibonacci {
    private static int operationCount = 0;

    public static int fibonacciRecursive(int n) {
        operationCount++;  
        if (n == 0) {
            operationCount++;  
            return 0;
        }
        if (n == 1) {
            operationCount++;  
            return 1;
        }
        return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
    }

    public static void main(String[] args) {
        int terms = 10; 
        operationCount = 0;
        System.out.print("Fibonacci Sequence (Recursive): ");
        for (int i = 0; i < terms; i++) {
            operationCount++;  
            operationCount++;  
            System.out.print(fibonacciRecursive(i) + " ");
        }
        System.out.println();
        System.out.println("Number of Primitive Operations: " + operationCount);
    }
}
