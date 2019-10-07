package World;
public class Oak extends Plant{

	public Oak() {
		
		//wont work because its private
		//type = "tree";
		//works because size is protected and oak is a sub class
		this.size = "large";
	}
}
