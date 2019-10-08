
public class Application {

	public static void main(String[] args) {
		Plant plant = new Plant();
		Tree tree = new Tree();
		//plant 2 is a reference of tree
		Plant plant2 = tree;
		//plant2 will use the method from tree
		plant2.grow();
		
		tree.shedLeaves();
		tree.grow();
		//error
		//plant2.shedLeaves();
		//this is because when trying to call a method, what actually matters is 
		//the type of the variable not the object
		//doShed(plant2);
		
		//null reference
		Plant plant3;
		
		doGrow(tree);
		doGrow(plant2);
		
	}
	
	//polymorphism, whenever a parent class is expected, you can use a child class
	public static void doGrow(Plant plant) {
		plant.grow();
	}
	
	public static void doShed(Tree tree) {
		tree.shedLeaves();
	}

}
