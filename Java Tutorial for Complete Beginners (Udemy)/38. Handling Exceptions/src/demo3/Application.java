package demo3;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;

public class Application {

	public static void main(String[] args) {
		try {
			openFile();
			//this will not be executed if an exception is thrown
			System.out.println("continuing....");
		} catch (FileNotFoundException e) {
			//Message is too vague
			System.out.println("File not found");
			//e.printStackTrace();
		}

		System.out.println("Finished...");
	}
	
	public static void openFile() throws FileNotFoundException {
		File file = new File("test.txt");
		
		FileReader fr = new FileReader(file);		
	}

}
