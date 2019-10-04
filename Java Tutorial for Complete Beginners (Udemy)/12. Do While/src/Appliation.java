import java.util.Scanner;
public class Appliation {

	public static void main(String[] args) {

		//create scanner object
		Scanner scanner = new Scanner(System.in);
		
		/*
		//ask user for input
		 
		System.out.println("Enter a number: ");
		//accept int val as input
		int value = scanner.nextInt();
		
		//if input does not equal 5 then keep looping
		while (value != 5) {
			System.out.println("Enter a number: ");
			value = scanner.nextInt();
		}
		*/
		int value;
		
		do {
			System.out.println("Enter a number: ");
			value = scanner.nextInt();
		}
		while(value != 5);
		
		System.out.println("Got 5!");
	}

}
