
public class Application {

	public static void main(String[] args) {

		//initialize array of string
		String[] words = {"Hello", "to", "you"};
		
		//foreach loop to display array
		for(String a:words)
		{
			System.out.print(a + " ");
		}
		System.out.println();
		
		//creating and allocating enough memory for the int variable
		int value = 123;
		
		//creating an object of class String, and memory has not been allocated. Instead, a reference has been created.
		//null special type that means nothing
		String text = null;
	}

}
