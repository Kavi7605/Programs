public class ItFibonacci {
    private static int operationCount = 0;

    public static void fibonacciIterative(int n) {
        int a = 0, b = 1;
        operationCount++;
        System.out.print("Fibonacci Sequence (Iterative): " + a + " " + b);
        for (int i = 2; i < n; i++) {
            operationCount++;  
            operationCount++;  
            int next = a + b;
            operationCount++;  
            System.out.print(" " + next);
            a = b;
            b = next;
            operationCount++;  
        }
        System.out.println();
    }

    public static void main(String[] args) {
        int terms = 10; 
        operationCount = 0;  // 
        fibonacciIterative(terms);
        System.out.println("Number of Primitive Operations: " + operationCount);
    }
}
