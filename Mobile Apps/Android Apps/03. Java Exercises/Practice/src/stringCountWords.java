import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.atomic.AtomicInteger;

public class stringCountWords {
	public static void main(String[] args) throws IOException {
		FileReader reader = new FileReader("file.txt");
		BufferedReader br = new BufferedReader(reader);
		StringBuilder sb = new StringBuilder();
		String line = br.readLine();

		while (line != null) {
			sb.append(line);
			sb.append(System.lineSeparator());
			line = br.readLine();
		}

		String fullText = sb.toString().toLowerCase().trim();
		String[] words = fullText.split(" ");

		Map<String, AtomicInteger> map = new HashMap<String, AtomicInteger>();
		for (String word : words) {
			AtomicInteger initialCount = new AtomicInteger(1);
			if(!map.containsKey(word)){
				map.put(word, initialCount);
			}
			else {
				map.get(word).getAndIncrement();
			}
		}

		for (Map.Entry<String, AtomicInteger> entry : map.entrySet()) {
			System.out.println(entry.getKey() + " = " + entry.getValue());
		}
	}
}
