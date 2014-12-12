package RandomGiftsSuggestions;

import java.util.HashMap;
import java.util.Map;
import java.util.Random;
import java.util.concurrent.atomic.AtomicInteger;

public class Demo {
	public static void main(String[] args) {
		Random rnd = new Random();
		
		Person pesho = new Person("Pesho");
		Person gosho = new Person("Gosho");
		
		String giftsStr = "hat watch boots icecream car house lollipop bike dog car boat villa";
		String[] gifts = giftsStr.split(" ");
		Map<String, Boolean> map = new HashMap<String, Boolean>();
		
		for (String gift : gifts) {
			map.put(gift, true);
		}
		
		for (int i = 0; i < 3; i++) {
			int n = rnd.nextInt(gifts.length) + 0;
			Boolean isAvailable = map.get(gifts[n]);
			if (isAvailable) {
				pesho.getGifts().add(new Gift(gifts[n]));
				map.put(gifts[n], false);
			}
			else {
				n = rnd.nextInt(gifts.length) + 0;
				pesho.getGifts().add(new Gift(gifts[n]));
				map.put(gifts[n], false);
			}
			
			n = rnd.nextInt(gifts.length) + 0;
			isAvailable = map.get(gifts[n]);
			if (isAvailable) {
				gosho.getGifts().add(new Gift(gifts[n]));
				map.put(gifts[n], false);
			}
			else {
				n = rnd.nextInt(gifts.length) + 0;
				gosho.getGifts().add(new Gift(gifts[n]));
				map.put(gifts[n], false);
			}
		}
		
		System.out.println("Gosho's gifts: ");
		for (Gift gift : gosho.getGifts()) {
			
			System.out.print(gift.getName() + " ");
		}
		System.out.println("");
		System.out.println("Pesho's gifts: ");
		for (Gift gift : pesho.getGifts()) {
			
			System.out.print(gift.getName() + " ");
		}
		
	}
}
