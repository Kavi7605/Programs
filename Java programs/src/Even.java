
public class Even {
    public static void main(String args[]) {
        int n=10, i=1;
        System.out.println("List of even number from 1 to "+n +":");
        for(i=1;i<=n;i++){
            if(i%2==0)
                System.out.printf("%d ", i);
        }
    }
}