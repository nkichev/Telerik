package com.example.hw03fragments;

public class Product {
	private String name;
	private String Category;
	private double price;

	public Product(String name, String category, double price) {
		this.setName(name);
		this.setCategory(category);
		this.setPrice(price);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getCategory() {
		return Category;
	}

	public void setCategory(String category) {
		Category = category;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}
}
