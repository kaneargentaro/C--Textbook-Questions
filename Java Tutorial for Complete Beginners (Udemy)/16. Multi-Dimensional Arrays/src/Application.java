
public class Application {

	public static void main(String[] args) {

		//create a multi dimensional array which is like this:
		// X X X
		// X X X
		int[][] array = {{1,3,5},{2,4,6}};
		
		//declaring an empty multidimensional array
		//two rows, three column
		String[][] text = new String[2][3];
		
		//create a multi dimensional array which is like this:
		// X X X
		// X X 
		// X X X X X
		int[][] jaggeredarray = {{1,3,5},{2,4}, {10, 15, 20, 15, 30}};
		
		//Output
		//row 0, column 1
		System.out.println(array[0][1]);
		
		//nested for loop to show whole dimensional array
		for (int i = 0; i < array.length; i++)
		{
			System.out.print("[ ");
			for (int k = 0; k < array[i].length; k++)
			{
				System.out.print(array[i][k] + " ");
			}
			System.out.print("]");
			System.out.println();
		}
		
		//foreach loop to loop through multidimensional arrays
		for(int[] a:array)
		{
			System.out.print("[ ");
			for(int val:a) {
				System.out.print(val + " ");
			}
			System.out.print("]");
			System.out.println();
		}
		
		//creating an array with only rows specified, and columns not.
		String[][] words = new String[2][];
		//Assigning a row a specific number of columns
		words[0] = new String[3];
	}

}
