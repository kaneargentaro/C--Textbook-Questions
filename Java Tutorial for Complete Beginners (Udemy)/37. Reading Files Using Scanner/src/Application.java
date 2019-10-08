import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Application {

	public static void main(String[] args) throws FileNotFoundException {
		//String fileName = "D:\\Programming Projects\\Practice-Code\\Java Tutorial for Complete Beginners (Udemy)\\37. Reading Files Using Scanner\\example.txt";
		String fileName = "example.txt";

		File textFile = new File(fileName);
		
		
		Scanner in = new Scanner(textFile);
		
		int value = in.nextInt();
		System.out.println("Read value: " + value);
		in.nextLine();
		
		int count = 2;
		while(in.hasNextLine()) {
			String line = in.nextLine();
			System.out.println(count + ": " + line);
			count++;
		}
		
		//close the file to solve resource leak
		in.close();
	}

}
