package RandomGiftsSuggestions;

import java.util.ArrayList;
import java.util.List;

public class Person {
	private String name;
	private List<Gift> gifts;
	
	public Person (String name) {
		this.setName(name);
		this.gifts = new ArrayList<Gift>();
	}
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public List<Gift> getGifts() {
		return gifts;
	}

	public void setGifts(List<Gift> gifts) {
		this.gifts = gifts;
	}

	
	
}
