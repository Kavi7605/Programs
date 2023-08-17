public class Armstrong {
    public static void main(String args[]) 
    {
        int a=153, tmp, r=0, b;
        tmp=a;
        while(tmp!=0)
        {
            b=tmp%10;
            System.out.printf("%d^3 ", b);
            r=r+b*b*b;
            tmp=tmp/10;
            if(tmp!=0)
                System.out.printf("+ ");
        }
        if(a==r)
            System.out.printf("= %d\n%d is an armstrong number.", r, a);
        else
            System.out.printf("= %d\n%d is not an armstrong number.", r, a);
    }
}
