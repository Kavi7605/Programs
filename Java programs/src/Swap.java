public class Swap {
    public static void main(String args[]) {
        int a=2, b=4, tmp;
        System.out.println("Before SWAP:"+ a + ", "+ b);
        tmp=a;
        a=b;
        b=tmp;
        System.out.println("After SWAP:"+ a + ", "+ b);
    }
}