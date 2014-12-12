package Horoscope;

import java.lang.reflect.Field;
import java.nio.charset.Charset;
import java.util.Scanner;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;

public class GetHoroscope {

	public static void main(String[] args) throws Exception {
		System.out.println("Enter your zodiac sign: ");

		Scanner scanner = new Scanner(System.in);
		String zodiacSign = scanner.nextLine();
		scanner.close();

		String url = "http://zodia.bg/sign/" + zodiacSign;
		
		Document html = Jsoup.connect(url).get();
		String text = html.select("span.short-text").text();
		System.out.println(text);
	}
}
