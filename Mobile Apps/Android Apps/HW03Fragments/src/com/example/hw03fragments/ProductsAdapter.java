package com.example.hw03fragments;

import java.util.List;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

public class ProductsAdapter extends ArrayAdapter<Product> {
	private Context context;
	private int layoutId;
	private List<Product> products;
	
	public ProductsAdapter(Context context, int resource, List<Product> objects) {
		super(context, resource, objects);
		this.context = context;
		this.layoutId = resource;
		this.products = objects;
	}

	@SuppressLint("ViewHolder") 
	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		
		LayoutInflater inflater = ((Activity) context).getLayoutInflater();
		View row = inflater.inflate(layoutId, parent, false);
		
		TextView tvName = (TextView) row.findViewById(R.id.product_name);		
		TextView tvCategory = (TextView) row
				.findViewById(R.id.product_category);
		
		tvName.setText(products.get(position).getName());
		tvCategory.setText(products.get(position).getCategory());

		return row;
	}

}
