
public class Application {

	public static void main(String[] args) {
		
		//ways to initialize
		//1st way
		int[] example1 = new int[5]; 
		example1[0] = 1;
		//2nd way
		int[] example2;
		example2 = new int[5];
		example2[0] = 1;
		//3rd way
		int[] example3 = {1, 2, 3};
		
		//call values
		System.out.println(example1[0]);
		System.out.println(example2[0]);
		System.out.println(example3[0]);
		
		//new line
		System.out.println();
		
		//show array values using for loop
		for(int i=0; i < example3.length; i++)
		{
			System.out.println(example3[i]);
		}
		
		//new line
		System.out.println();
		
		//This is the same as the foreach loop in c#
		for (int a : example3)
		{
			System.out.println(a);
		}
		

	}

}
