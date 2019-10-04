import java.io.*;

public class Application {

	public static void main(String[] args) {
		
		//infinite loop
		/*for(;;)
		{
			System.out.println("Hello");
		}*/
		
		//infinite loop
		for(int i = 0; i < 10; i++)
		{
			//System.out.println("The value of i is: " + i);
			
			//format specifier
			//%d is integer
			//print f does not print to new line
			//new line is either: blank sysout or \n
			System.out.printf("The value of i is: %d\n", i);
		}
	}

}
