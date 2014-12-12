package com.example.hw02imagespopup;

import android.app.Activity;
import android.os.Bundle;
import android.support.v7.widget.PopupMenu;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ImageView;

public class MainActivity extends Activity implements OnClickListener{

	ImageView image1;
	ImageView image2;
	ImageView image3;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		image1 = (ImageView) findViewById(R.id.imageView1);
		image2 = (ImageView) findViewById(R.id.imageView2);
		image3 = (ImageView) findViewById(R.id.imageView3);
		
		image1.setOnClickListener(this);
		image2.setOnClickListener(this);
		image3.setOnClickListener(this);
		
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
		return super.onOptionsItemSelected(item);
	}

	@Override
	public void onClick(View view) {
		PopupMenu popup = new PopupMenu(MainActivity.this, view);
		if (view.getId() == R.id.imageView1) {
			popup.inflate(R.menu.custom_menu1);
			popup.show();
		} else if (view.getId() == R.id.imageView2) {
			popup.inflate(R.menu.custom_menu2);
			popup.show();
		} else if (view.getId() == R.id.imageView3) {
			popup.inflate(R.menu.custom_menu3);
			popup.show();
		}
	}
}
