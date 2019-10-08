class Machine{
	public void start() {
		System.out.println("Machine started.");
	}
}

class Camera extends Machine{
	
	public void start() {
		System.out.println("Camera started.");
	}
	
	public void snap() {
		System.out.println("Photo taken.");
	}
}


public class Application {

	public static void main(String[] args) {

		Machine machine1 = new Machine();
		Camera camera1 = new Camera();
		
		machine1.start();
		camera1.start();
		camera1.snap();
		System.out.println();
		
		//Upcasting 
			//polymorphism
			//Machine machine2 = new Camera();
		Machine machine2 = camera1;
		//uses camera start method
		machine2.start();
		//cannot call camera method of snap because variable type is machine
		
		System.out.println();
		
		//Downcasting
		Machine machine3 = new Camera();
		//machine3.snap();
		Camera camera2 = (Camera)machine3;
		camera2.snap();
		camera2.start();
		machine3.start();
		//machine2.snap();
		
		
	}

}
