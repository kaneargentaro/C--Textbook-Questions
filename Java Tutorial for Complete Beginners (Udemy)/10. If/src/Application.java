
public class Application {

	public static void main(String[] args) {

		if (4 == 4) {
			System.out.println("This is correct");
		}
		
		if (5 != 5) {
			System.out.println("This is False");
		}
		
		int myInt = 5;
		
		if(myInt < 10) {
			System.out.println("This is correct");
		}
		else {
			System.out.println("This is False");
		}
		
		int loop = 0;
		
		while(true) {
			System.out.println("Looping: " + loop);
			
			if(loop==5)
			{
				break;
			}
			
			loop++;
			
			System.out.println("Running");
		}
		
	}

}
