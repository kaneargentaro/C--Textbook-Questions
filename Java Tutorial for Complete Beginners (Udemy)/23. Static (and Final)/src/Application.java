class Thing{
	
	//final is java's version of constant
	public final static int LUCKY_NUMBER = 69;
	
	//this is an instance variable
	public String name;
	//static variables belong to the class and all objects in the class get this description. There is only one.
	public static String description;
	
	//count variable is shared between all objects of class Thing
	public static int count = 0;
	
	public int id;
	
	public Thing() {
		id = count;
		count++;
	}
	
	public void showName() {
		System.out.println("Object ID is: " + id + " and " + description + ": " + name);
		
	}
	
	public static void showInfo() {
		System.out.println(description);
	}
}


public class Application {

	public static void main(String[] args) {
		
		Thing.description = "I am a thing";
		Thing.showInfo();
		
		System.out.println("Before creating objects, count is: " + Thing.count);
		
		//make thing objects
		Thing thing1 = new Thing();
		Thing thing2 = new Thing();
		
		thing1.name ="Bob";
		thing2.name = "Sue";
		
		thing1.showName();
		thing2.showName();	
		
		System.out.println(Thing.LUCKY_NUMBER);
		
		System.out.println("After creating objects, count is: " + Thing.count);
	
	}

}
