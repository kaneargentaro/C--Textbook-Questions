
//abstract keyword makes the class abstract and you cant create a machine object
public abstract class Machine {
	private int id;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}
	
	//abstract method to force all child classes to implement it,
	//but machine wont implement it
	public abstract void start();
	public abstract void doStuff();
	public abstract void shutdown();
	
	public void run() {
		start();
		doStuff();
		shutdown();
	}
}
