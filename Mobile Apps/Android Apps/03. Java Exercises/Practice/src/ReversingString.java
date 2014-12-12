
public class ReversingString {
	public static void main(String[] args) {
		String str = "abcd";
		StringBuilder builder = new StringBuilder();
		for (int i = str.length() - 1; i >= 0; i--) {
			builder.append(str.charAt(i));
		}
		
		System.out.println(builder);
	}
}
