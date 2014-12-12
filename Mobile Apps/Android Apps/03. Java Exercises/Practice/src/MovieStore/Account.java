package MovieStore;


public class Account {
	private String name;
	private Video video;
	
	public Account(String name) {
		this.setName(name);
	}
	
	public Video getVideo() {
		return video;
	}
	public void setVideo(Video video) {
		this.video = video;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public void takeVideo(Video video){
		this.setVideo(video);
	}
}
