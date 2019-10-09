
public class Car extends Machine{

	@Override
	public void start() {
		System.out.println("Starting Car....");	
	}

	@Override
	public void doStuff() {
		System.out.println("Doing stuff...");
		
	}

	@Override
	public void shutdown() {
		System.out.println("Shutting Down....");
		
	}

}
