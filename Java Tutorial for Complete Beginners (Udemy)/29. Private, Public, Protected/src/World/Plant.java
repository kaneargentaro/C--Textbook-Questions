package World;

public class Plant {
	//bad practice
	public String name;
	
	//acceptable practice
	public final static int ID = 15;
	
	//can only access within this class
	private String type;
	
	
	protected String size;
	
	int height;
	
	public Plant() {
		name = "Freddy";
		type = "plant";
		size = "large";
		height = 8;
	}
	
}