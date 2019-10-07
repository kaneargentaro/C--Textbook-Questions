//car is a child class of machine.
//car is derived from machine
//car is inherited from machine
//machine is a parent class
public class Car extends Machine {
	
	//method overriding
	@Override
	public void start() {
		System.out.println("Car has started.");
	}
	@Override
	public void stop() {
		System.out.println("Car has stopped.");
	}
	
	public void wipeWindShield() {
		System.out.println("Wiping WindShield.");
	}
	
	public void showInfo() {
		System.out.println("Car name: " + name);
	}
	
	
}
