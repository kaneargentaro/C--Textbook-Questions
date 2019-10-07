
public class Application {

	public static void main(String[] args) {
		
		
		//this way is inefficient
		//create empty string
		String info = "";
		//add the empty string each time
		info += "My name is Bob.";
		info += " ";
		info += "I am a builder.";
		
		System.out.println(info);
		
		//more efficient - memory efficient since it doesnt create a new string every time
		//create an empty string with object name sb using StringBuilder class
		StringBuilder sb = new StringBuilder("");
		//add to the string
		sb.append("My name is Sue.");
		sb.append(" ");
		sb.append("I am a lion tamer.");
		
		System.out.println(sb.toString());
		
		StringBuilder s = new StringBuilder();
		s.append("My name is Roger")
		.append(" ")
		.append("I am a sky diver.");
		
		System.out.println(s.toString());
		
		//##Formatting##//
		System.out.print("Here is some text.\tThat was a tab\nThat was a newline.");
		System.out.println(" More text.");
		//print format (printf)
		//format int with %d
		//%5d makes it 5 spaces wide- right aligned
		//%-5d makes it 5 spaces wide- left aligned
		System.out.printf("Total cost %5d; quantity is %-5d.\n", 5, 512);
		
		//formatting integer and string. making integars line up
		for(int i=0; i<20; i++)
		{
			System.out.printf("%-2d: %s\n", i, "some text here");
		}
		
		//formatting floating value
		System.out.printf("Total value: %50.2f\n", 5.68874548);
		
	}

}
