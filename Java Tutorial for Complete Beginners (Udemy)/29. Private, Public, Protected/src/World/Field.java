package World;
public class Field {
	private Plant plant = new Plant();
	
	public Field() {
		//size is protected and field is in the same package
		System.out.println(plant.size);
	}
}
