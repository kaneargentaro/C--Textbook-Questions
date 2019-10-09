
public class Application {

	public static void main(String[] args) {
		
		Robot robot = new Robot(6);
		robot.start();
		
		//Robot.Brain brain = robot.new Brain();
		//brain.think();

		Robot.Battery battery = new Robot.Battery();
		battery.charge();
		
	}

}
