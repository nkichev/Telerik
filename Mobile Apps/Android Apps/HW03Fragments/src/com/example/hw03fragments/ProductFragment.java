package com.example.hw03fragments;

import android.annotation.SuppressLint;
import android.app.Fragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

@SuppressLint("NewApi")
public class ProductFragment extends Fragment {

	@SuppressLint("NewApi")
	Product product;
	
	@SuppressLint("NewApi")
	public ProductFragment(Product product) {
		super();
		this.product = product;
	}
	
	public ProductFragment() {
		super();
	}

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		
		View v = inflater.inflate(R.layout.products_details, container, false);
		initializeComponents(v);
		return v;
	}
	
	public void initializeComponents(View v) {
		if (product == null) {
			product = new Product("Coca-Cola", "Softdrink", 1.8);
		}
		
		TextView name = (TextView) v.findViewById(R.id.product_details_name);
		TextView category = (TextView) v
				.findViewById(R.id.product_details_category);
		TextView price = (TextView) v.findViewById(R.id.product_details_price);

		name.setText("Name: " + product.getName());
		category.setText("Category: " + product.getCategory());
		price.setText("Price: " + product.getPrice());
	}
}
