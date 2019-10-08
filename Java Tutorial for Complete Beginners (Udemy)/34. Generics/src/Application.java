import java.util.ArrayList;
import java.util.HashMap;

class animal{
	
}

public class Application {

	public static void main(String[] args) {
		//generics are a class that can work with other objects
		//you specify what type of objects it can work with upon creation
		
		//manages an array internally - dont need to know how big or arrange
		
		
		/////////////////before java 5/////////////
		ArrayList  list = new ArrayList();
		
		list.add("apple");
		list.add("banana");
		list.add("orange");
		
		String fruit = (String)list.get(1);
		System.out.println(fruit);
		
		
		//////////////////modern style//////////////
		ArrayList<String> strings = new ArrayList<String>();
		
		strings.add("Cat");
		strings.add("dog");
		strings.add("wolf");
		
		String animal = strings.get(1);
		System.out.println(animal);
		
		
		////////////////////there can be more then one type argument////////////////////
		HashMap<Integer, String> map = new HashMap<Integer, String>();
		
		
		/////////////////java 7 style////////////////////
		ArrayList<animal> someList = new ArrayList<>();
		
	}

}
