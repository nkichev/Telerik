package MovieStore;

import java.util.Date;
	
public class Video {
	private String name;
	private double fee;
	private VideoStatus status;
	
	public Video(String name, double fee){
		this.setName(name);
		this.setFee(fee);
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public double getFee() {
		return fee;
	}
	public void setFee(double fee) {
		this.fee = fee;
	}

	public VideoStatus getStatus() {
		return status;
	}

	public void setStatus(VideoStatus status) {
		this.status = status;
	}
}
