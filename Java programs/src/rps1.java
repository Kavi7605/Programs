import java.util.Scanner;
import java.util.Random;

public class rps1 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Random rand = new Random();
        Boolean flag = true;
        while(flag){  
            int number = rand.nextInt(3);

            char computer;

            if (number == 0){
                computer = 'r';
            }
            else if (number == 1){
                computer = 's';
            }
            else{
                computer = 'p';
            }
            
            System.out.print("Enter R for Rock, S for Scissor, P for Paper or E to Exit: ");
            char choice = sc.next().charAt(0);
            choice = Character.toLowerCase(choice);

            if (computer == choice){
                System.out.println("Computer: "+ computer);
                System.out.println("Player: "+ choice);
                System.out.println("Tie \n");
            }
            else if (computer == 's' && choice == 'r'){
                System.out.println("Computer: "+ computer);
                System.out.println("Player: "+ choice);
                System.out.println("Player Wins \n");
            }
            else if(computer == 'r' && choice == 'p'){
                System.out.println("Computer: "+ computer);
                System.out.println("Player: "+ choice);
                System.out.println("Player Wins \n");
            }
            else if(computer == 'p' && choice == 's'){
                System.out.println("Computer: "+ computer);
                System.out.println("Player: "+ choice);
                System.out.println("Player Wins \n");
            }
            else if(computer == 'r' && choice == 's'){
                System.out.println("Computer: "+ computer);
                System.out.println("Player: "+ choice);
                System.out.println("Computer Wins \n");
            }
            else if(computer == 'p' && choice == 'r'){
                System.out.println("Computer: "+ computer);
                System.out.println("Player: "+ choice);
                System.out.println("Computer Wins \n");
            }
            else if(computer == 's' && choice == 'p'){
                System.out.println("Computer: "+ computer);
                System.out.println("Player: "+ choice);
                System.out.println("Computer Wins \n");
            }
            else if(choice == 'e'){
                flag=false; 
            }
            else{
                System.out.println("ERROR: Invalid input. \nTry again... \n");
            }     
        }
        sc.close();
    }
}
