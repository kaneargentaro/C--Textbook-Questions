class Plant{
	//private makes it so you encapsulate the inner working of
	//the class so no one can use private data outside it
	private String name;
	//constant class variable
	public final static int ID = 7;
	
	public String getData() { 
		String data = "return some stuff lol " + calculateGrowthForecast();
		return data;
	}
	
	//make it private so no one can use it
	private int calculateGrowthForecast() {
		return 9;
	}
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	
	
	
	
}


public class Application {

	public static void main(String[] args) {

		Plant plant1 = new Plant();
		
		plant1.setName("Johnny");
		
		System.out.println(plant1.getName());
		System.out.println(plant1.getData());
	}

}
