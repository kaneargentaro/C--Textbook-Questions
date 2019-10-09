
public class Application {

	public static void main(String[] args) {
		
		///////////////checked exception because you HAVE to handle it///////////////////
		/*try {
			Thread.sleep(111);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}*/
		
		////////////Runtime exception - not checked or forced to handle////////////
		/*int value = 7;
		//throws an exception 
		value = value/0;*/
		
		//Null Pointer exception
		/*String text = null;
		System.out.println(text.length());*/
		
		//Array out of bounds exception
		String[] texts = {"one", "two", "three"};
		try {
		System.out.println(texts[3]);
		} catch (RuntimeException e) {
			System.out.println(e.toString());
			//e.printStackTrace();
		}
		
		
	}

}
