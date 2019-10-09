
public class Application {

	public static void main(String[] args) {

		Camera cam1 = new Camera();
		cam1.setId(5);
		
		Car car1 = new Car();
		car1.setId(6);
		
		//create an abstract class because you wouldnt need to create a machine, but machine is
		//base class of camera and car
		//Machine machine1 = new Machine();
		
		cam1.run();
		car1.run();
	}

}
