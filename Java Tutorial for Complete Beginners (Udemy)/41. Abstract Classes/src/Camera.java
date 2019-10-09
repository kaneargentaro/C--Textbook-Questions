
public class Camera extends Machine{

	@Override
	public void start() {
		System.out.println("Starting Camera....");
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
