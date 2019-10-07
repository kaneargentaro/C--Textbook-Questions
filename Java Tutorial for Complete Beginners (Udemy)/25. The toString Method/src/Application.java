class Frog{
	
	private String name;
	private int id;
	
	public Frog(String name, int id) {
		this.id = id;
		this.name = name;
	}
	
	public String toString() {
		return String.format("%4d: %s", id, name);
		
		//StringBuilder sb = new StringBuilder();
		//sb.append(id).append(": ").append(name);
		//return sb.toString();
		
		//return id + ": " + name;
		
	}
}

public class Application {

	public static void main(String[] args) {
		
		Frog frog1 = new Frog("Freddie", 7);
		Frog frog2 = new Frog("Rodgie", 5);
		
		System.out.println(frog1);
		System.out.println(frog2);
		
		
	}

}
