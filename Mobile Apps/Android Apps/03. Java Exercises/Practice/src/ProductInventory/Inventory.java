package ProductInventory;

import java.util.ArrayList;
import java.util.List;

public class Inventory {
	private List<Product> products;
	private double inventoryValue = 0.0;
	
	public Inventory(){
		this.products = new ArrayList<Product>();
	}

	public List<Product> getProducts() {
		return products;
	}

	public void setProducts(List<Product> products) {
		this.products = products;
	}
	
	public void AddProduct(Product product) {
		this.getProducts().add(product);
	}
	
	public double getInventoryValue() {
		return this.inventoryValue;
	}

	public void setInventoryValue(double inventoryValue) {
		this.inventoryValue = inventoryValue;
	}
	
	public double GetInventoryValue(){
		double value = this.getInventoryValue();
		for (Product product : products) {
			for (int i = 0; i < product.getQuantity(); i++) {
				value = value + product.getPrice();
			}
		}
		
		return value;
	}

}
