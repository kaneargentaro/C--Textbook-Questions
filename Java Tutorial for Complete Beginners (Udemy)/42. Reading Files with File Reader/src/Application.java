import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class Application {

	public static void main(String[] args) {

		File file = new File("text.txt");
		BufferedReader br= null;
		
		try {
			FileReader fr = new FileReader(file);
			br = new BufferedReader(fr);
			
			String line;
			while((line = br.readLine()) != null) {
				System.out.println(line);
			}
		} catch (FileNotFoundException e) {
			System.out.println("File not found: " + file.toString());
		} catch (IOException e) {
			System.out.println("Unable to read file: " + file.toString());
		}
		finally {
			try {
			br.close();
		} catch (IOException e) {
			System.out.println("Failed to close br");
		} catch (NullPointerException ex)
		{
			System.out.println("nullpointerexception");
		}
		}
		
		
	}

}
