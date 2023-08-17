import java.util.Scanner;
import java.util.Random;

public class RPS {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Random rand = new Random();
        int a =0;
        while (a!=10){
            int comp = rand.nextInt(3);
            String cm;
            if (comp == 0) {
                cm = "r";
            } 
            else if (comp == 1) {
                cm = "p";
            }
            else {
                cm = "s";
            }

            System.out.print("Enter your character R for Rock , P for Paper , S for Scissors : ");
            String play  = input.next();
            play = play.toLowerCase();

            System.out.println("player is "+play+" computer is "+cm);

            if((play.equals("r") && cm.equals("s") )|| (play.equals("s") && cm.equals("p")) || (play.equals("p") && cm.equals("r"))){
                System.out.println("Player wins ");
            } else if ((play.equals("r") && cm.equals("p")) || (play.equals("s") && cm.equals("r") )||( play.equals("p") && cm.equals("s"))) {
                System.out.println("Computer wins ");
            }
            else {
                System.out.println("Ties");
            }
            a = a+1;
        }
    }
}