import java.io.FileNotFoundException;
import java.io.IOException;
import java.text.ParseException;

public class Application {

	public static void main(String[] args) {
		
		Test test = new Test();
		
		/*
		try {
			test.run();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ParseException e) {
			System.out.println("Error couldnt parse");
			e.printStackTrace();
		}*/
		
		/*
		try {
			test.run();
			//catch IOException OR ParseException
		} catch (IOException | ParseException e) {
			System.out.println("Error");
			//e.printStackTrace();
		} */
		
		//polymorphism, Exception is a parent class of individual exception classes
		try {
			test.run();
		} catch (Exception e) {
			System.out.println("Error");
			//e.printStackTrace();
		} 
		
		//Filenotfoundexception is a subclass of IOException so filenotfoundexception has to be first
		//in the catch block so it is run
		//makes it unreachable
		try {
			test.input();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
