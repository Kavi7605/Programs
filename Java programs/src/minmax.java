import java.util.Arrays;

class minmax {
 
    static int getMin(int arr[], int n) {
        return Arrays.stream(arr).min().getAsInt();
    }
 
    static int getMax(int arr[], int n) {
        return Arrays.stream(arr).max().getAsInt();
    }
 
    public static void main(String[] args) {
        int arr[] = {12, 1234, 45, 67, 1};
        int n = arr.length;
        System.out.println("Minimum element of array: " + getMin(arr, n));
        System.out.println("Maximum element of array: " + getMax(arr, n));  
    }
}