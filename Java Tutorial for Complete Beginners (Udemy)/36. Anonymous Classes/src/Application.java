class Machine{
	
	public void start() {
		System.out.println("starting machine...");
	}
}

interface Plant {
	public void grow();
}
public class Application {

	public static void main(String[] args) {
		Machine machine1 = new Machine() {
			//override methods here
			//anonymous class
			//good for one time use
			@Override
			public void start() {
				System.out.println("Camera snapping...");
			}
		};
		
		Plant plant1 = new Plant() {
			public void grow() {
				System.out.println("Plant growing...");
			}
		};
		
		machine1.start();
		plant1.grow();
	}

}
