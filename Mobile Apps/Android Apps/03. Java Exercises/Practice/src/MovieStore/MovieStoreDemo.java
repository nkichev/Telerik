package MovieStore;

import java.util.ArrayList;
import java.util.List;

public class MovieStoreDemo {

	public static void main(String[] args) {
		Video firstVideo = new Video("Bad Boys", 5);
		Video secondVideo = new Video("Bad Boys 2", 6.5);
		Video thirdVideo = new Video("Mission Impossible", 4);
		
		Account pesho = new Account("Pesho");
		pesho.takeVideo(firstVideo);
		pesho.getVideo().setStatus(VideoStatus.DueToReturn);
		
		Account gosho = new Account("Gosho");
		gosho.takeVideo(secondVideo);
		gosho.getVideo().setStatus(VideoStatus.OverDue);
		
		Account ivan = new Account("Ivan");
		ivan.takeVideo(thirdVideo);
		ivan.getVideo().setStatus(VideoStatus.OverDue);
		
		List<Account> accounts = new ArrayList<Account>();
		accounts.add(pesho);
		accounts.add(gosho);
		accounts.add(ivan);
		
		List<Account> AccountsOverdue = getAccountsOverdue(accounts);
		System.out.println("Accounts which are overdue for contact: ");
		for (Account account : AccountsOverdue) {
			System.out.println(account.getName());
		}

	}
	
	private static List<Account> getAccountsOverdue(List<Account> accounts){
		List<Account> accountsOverdue = new ArrayList<Account>();
		for (Account account : accounts) {
			if (account.getVideo().getStatus().toString() == "OverDue") {
				accountsOverdue.add(account);
			}
		}
		
		return accountsOverdue;
	}
}
