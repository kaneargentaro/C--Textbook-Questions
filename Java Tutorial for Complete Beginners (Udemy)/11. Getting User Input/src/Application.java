import java.util.Scanner;

public class Application {

	public static void main(String[] args) {
		
		//Create scanner object
		Scanner input = new Scanner(System.in);
		
		//output prompt
		System.out.println("Enter a line of text: ");
		
		//wait for user to enter input
		String line = input.nextLine();
		
		//output entered data
		System.out.println("You entered: " + line);
		
		
		//output prompt
		System.out.println("Enter an integer ");
		
		//wait for user to enter an int
		int value = input.nextInt();
		
		//output entered data
		System.out.println("You entered: " + value);
	}

}
