class Person
{
	//classes can contain
	//1. data
	//2. Subroutine(methods)
	
	//Instance variables
	String name;
	int age;
	
}

public class Application {

	public static void main(String[] args) {

		Person person1 = new Person();
		person1.age = 25;
		person1.name = "John";
		
		//Person person2 = new Person("Jack", 25);
		System.out.println(person1.age);
		
	}

}
