package ProductInventory;

public class Product {
	private int id;
	private double price;
	private int quantity;
	
	public Product(int id, double price, int quantity) {
		this.setId(id);
		this.setPrice(price);
		this.setQuantity(quantity);
	}
	
	public double getPrice() {
		return price;
	}
	public void setPrice(double price) {
		this.price = price;
	}
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	
	public int getQuantity() {
		return quantity;
	}
	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}
}
