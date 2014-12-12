//
//  ViewController.h
//  TipDemo
//
//  Created by Kris Kichev on 10/28/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface ViewController : UIViewController

@property (weak, nonatomic) IBOutlet UITextField *billAmount;

@property (weak, nonatomic) IBOutlet UISegmentedControl *tipPercentage;

@property (weak, nonatomic) IBOutlet UITextField *tipAmount;

@property (weak, nonatomic) IBOutlet UITextField *totalAmount;

- (IBAction)tipPercentageChange:(UISegmentedControl *)sender;

-(void)displayTotalAmount:(float)amount;

@end

