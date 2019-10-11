
public class Application {

	//public static final int DOG = 0;
	//public static final int CAT = 1;
	//public static final int MOUSE = 2;
	
	public static void main(String[] args) {
		
		//variable represents a member of a fixed set; colours, shapes, animal, suits in playing cards, etc.
		
		//int animal = CAT;
		Animal animal = Animal.CAT;
		
		switch(animal) {
		case CAT:
			System.out.println("Cat");
			break;
		case DOG:
			System.out.println("Dog");
			break;
		case MOUSE:
			break;
		default:
			break;
		
		}
		
		System.out.println(Animal.DOG);
		System.out.println("Enum name as a string: " + Animal.DOG.name());
		System.out.println(Animal.DOG.getClass());
		System.out.println(Animal.DOG instanceof Animal);
		System.out.println(Animal.MOUSE.getName());
		Animal animal2 = Animal.valueOf("CAT");
		System.out.println(animal2);
		System.out.println(animal);

	}

}
