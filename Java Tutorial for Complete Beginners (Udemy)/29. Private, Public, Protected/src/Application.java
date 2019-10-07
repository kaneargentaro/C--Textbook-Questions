import World.Plant;

public class Application {

	public static void main(String[] args) {
		Plant plant1 = new Plant();
		
		System.out.println(plant1.name);
		System.out.println(plant1.ID);
		
		//cant because its protected and in a different package
		System.out.println(plant1.size);

	}

}
