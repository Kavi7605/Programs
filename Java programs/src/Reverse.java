public class Reverse {
    public static void main(String args[]) 
    {
        int n=1234, r=0, a;
        System.out.println("Number:"+ n);
        while(n!=0){
            a=n%10;
            r=r*10+a;
            n=n/10;
        }
        System.out.println("Reverse of the given number is "+ r);
    }
}
