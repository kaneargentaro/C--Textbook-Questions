class Person {
	// classes can contain
	// 1. data
	// 2. Subroutine(methods)

	// Instance variables
	String name;
	int age;

	void speak() {
		System.out.println("Hello my name is " + name + " and I am " + age + " years old");
	}
	
	void sayHello() {
		System.out.println("Hello there!");
	}
}

public class Application {

	public static void main(String[] args) {

		Person person1 = new Person();
		person1.age = 25;
		person1.name = "John";

		// Person person2 = new Person("Jack", 25);
		System.out.println(person1.age);
		person1.speak();
		person1.sayHello();

	}

}
