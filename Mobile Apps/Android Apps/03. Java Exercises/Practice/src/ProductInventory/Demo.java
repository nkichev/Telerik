package ProductInventory;

public class Demo {

	public static void main(String[] args) {
		Inventory inventory = new Inventory();
		Product firstProduct = new Product(1, 4.5, 5);
		Product secondProduct = new Product(2, 5, 1);
		Product thirdProduct = new Product(3, 3, 3);
		
		inventory.AddProduct(firstProduct);
		inventory.AddProduct(secondProduct);
		inventory.AddProduct(thirdProduct);
		
		System.out.println(inventory.GetInventoryValue());
	}

}
