public class Palindrome {
    public static void main(String args[]) 
    {
        int temp, r, sum=0;
        int n=45544;
        
        temp=n;
        while(n>0)
        {
            r=n%10; // taking remainder
            sum=(sum*10)+r; //reverse
            n=n/10;
        }
        
        if(temp==sum)
            System.out.println("The number is Palindrome");
        else
            System.out.println("The number is not Palindrome");
    }
}