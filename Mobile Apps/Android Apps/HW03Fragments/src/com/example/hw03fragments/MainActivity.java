package com.example.hw03fragments;

import java.util.ArrayList;
import android.annotation.SuppressLint;
import android.annotation.TargetApi;
import android.app.Activity;
import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.content.Context;
import android.os.Build;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ListView;

@SuppressLint("NewApi")
public class MainActivity extends Activity implements OnClickListener{

	ProductsAdapter adapter;
	Context context = this;
	ArrayList<Product> data;
	
	@SuppressLint("NewApi")
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		data = new ArrayList<Product>();
		data.add(new Product("Coca-Cola", "SoftDrink", 1.8));
		data.add(new Product("Tuborg", "Beer", 2.3));
		data.add(new Product("Cheese", "Food", 6.5));

		ListView listview = (ListView) findViewById(R.id.listView1);
		adapter = new ProductsAdapter(this, R.layout.product_brief, data);
		listview.setAdapter(adapter);
		
		listview.setOnItemClickListener(new OnItemClickListener() {
			@TargetApi(Build.VERSION_CODES.HONEYCOMB)
			@SuppressLint("NewApi")
			@Override
			public void onItemClick(AdapterView<?> parent, View view,
					int position, long id) {
				
				 Product product = data.get(position);
				 Fragment fr = new ProductFragment(product);
				
				 FragmentManager fm = getFragmentManager();
				 FragmentTransaction fragmentTransaction = fm.beginTransaction();
				 fragmentTransaction.replace(R.id.fragment1, fr);
				 fragmentTransaction.commit();
			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// Handle action bar item clicks here. The action bar will
		// automatically handle clicks on the Home/Up button, so long
		// as you specify a parent activity in AndroidManifest.xml.
		int id = item.getItemId();
		if (id == R.id.action_settings) {
			return true;
		}
		return super.onOptionsItemSelected(item);
	}

	@Override
	public void onClick(View v) {
		// TODO Auto-generated method stub
		
	}

}
