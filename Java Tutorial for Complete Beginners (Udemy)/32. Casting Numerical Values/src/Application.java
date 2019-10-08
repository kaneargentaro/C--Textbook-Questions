
public class Application {

	public static void main(String[] args) {

		byte byteValue = 12;
		short shortValue = 16;
		int intValue = 888;
		long longValue = 12312;
		
		float floatValue = 8845.8f;
		double doubleValue = 1838.123;
		
		//casting - converting one variable type to another
		intValue = (int)longValue;
		
		System.out.println(longValue);
		System.out.println(intValue);
		
		doubleValue = intValue;
		System.out.println(doubleValue);
		
		
		//just chops off the end of the float point
		intValue = (int)floatValue;
		System.out.println(intValue);
		
		//value too big for byte
		//value kinda loops around and goes back to the minimum value
		byteValue = (byte)129;
		System.out.println(byteValue);
		
		
	}

}
