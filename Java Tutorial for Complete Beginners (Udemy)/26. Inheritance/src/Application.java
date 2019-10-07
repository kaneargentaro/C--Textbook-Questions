
public class Application {

	public static void main(String[] args) {
		
		Machine machine1 = new Machine();
		
		machine1.start();
		machine1.stop();
		
		Car car1 = new Car();
		
		car1.start();
		car1.wipeWindShield();
		car1.showInfo();
		car1.stop();
		
	}

}
