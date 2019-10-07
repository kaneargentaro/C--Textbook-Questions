class Machine {
	
	private String name;
	private int code;
	
	
	//constructor
	//initialization of instance variables
	//constructor overloading example
	public Machine(){
		this("Arnie", 6);
	}
	
	public Machine(String name) {
		this(name, 0);
		this.name = name;
	}
	
	public Machine(String name, int code) {
		this.name = name;
		this.code = code;
	}
}


public class Application {

	public static void main(String[] args) {
		
		//both of these create an object
		Machine machine1 = new Machine();
		//new Machine();
		
		Machine machine2 = new Machine("Johnny");
		
		Machine machine3 = new Machine("Jackson", 7);
		
	}

}
