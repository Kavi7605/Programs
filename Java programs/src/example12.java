import java.util.Scanner;

public class example12 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Enter a Integer: ");
        int num = scanner.nextInt();
        
        System.out.print("Enter a Double: ");
        double d = scanner.nextDouble();
        
        System.out.print("Enter a Boolean: ");
        boolean b = scanner.nextBoolean();

        Integer obj1 = Integer.valueOf(num);
        Double obj2 = Double.valueOf(d);
        Boolean obj3 = Boolean.valueOf(b);
        
        if(obj1 instanceof Integer) {
            System.out.println("An object of Integer is created.");
        }
        else{
            System.out.println("An object of Integer is not created.");
        }
        if(obj2 instanceof Double) {
            System.out.println("An object of Double is created.");
        }
        else{
            System.out.println("An object of Double is not created.");
        }
        if(obj3 instanceof Boolean) {
            System.out.println("An object of Boolean is created");
        }
        else{
            System.out.println("An object of Boolean is not created.");
        } 
        
        System.out.println("Integer value: "+ obj1);
        System.out.println("Double value: "+ obj2);
        System.out.println("Boolean value: "+ obj3);

        scanner.close();
    }
}
