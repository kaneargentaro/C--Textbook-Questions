import java.util.ArrayList;

class Machine {

	@Override
	public String toString() {
		return "I am a machine";
	}

	public void start() {
		System.out.println("Maching starting");
	}
}

class Camera extends Machine {
	@Override
	public String toString() {
		return "I am a Camera";
	}
	
	public void start() {
		System.out.println("Camera starting");
	}
	
	public void snap() {
		System.out.println("camera taking a photo");
	}
}



public class Application {

	public static void main(String[] args) {
		
		ArrayList<String> list = new ArrayList<>();
		
		list.add("one");
		list.add("two");
		
		showList(list);
		
		ArrayList<Machine> list1 = new ArrayList<>();
		
		list1.add(new Machine());
		list1.add(new Machine());
		
		showList1(list1);
		
		ArrayList<Camera> list2 = new ArrayList<>();
		
		list2.add(new Camera());
		list2.add(new Camera());
		
		showList1(list2);
	}
	
	public static void showList(ArrayList<String> list) {
		for(String value: list)
		{
			System.out.println(value);
		}
	}
	
	public static void showList1(ArrayList<? extends Machine> list) {
		for(Machine value: list)
		{
			System.out.println(value);
			value.start();
			//Class <?>whatclass = value.getClass();
			//if (value.getClass() == Camera.class)
			//	value.snap();
		}}
	public static void showList2(ArrayList<? super Camera> list) {
		for(Object value: list)
		{
			System.out.println(value);
			//value.start();
			//Class <?>whatclass = value.getClass();
			//if (value.getClass() == Camera.class)
			//	value.snap();
		}
		
	
	}

}
