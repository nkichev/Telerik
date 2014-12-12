//
//  ViewController.m
//  TipDemo
//
//  Created by Kris Kichev on 10/28/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    [self displayTheKeyboard];
    
}

-(void)displayTheKeyboard{
    [self.billAmount becomeFirstResponder];
}

-(void)dismissTheKeyboard{
    [self.billAmount resignFirstResponder];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)tipPercentageChange:(UISegmentedControl *)sender {
    [self updateDisplayedTip];
    [self updateDisplayedTotal];
    [self dismissTheKeyboard];
}

-(NSString *)formatCurrency:(float)amount{
    NSNumberFormatter *nf = [[NSNumberFormatter alloc] init];
    nf.numberStyle = NSNumberFormatterCurrencyStyle;
    NSNumber *number = [NSNumber numberWithInt:amount];
    return [nf stringFromNumber:number];
}

-(void)displayTotalAmount:(float)amount{
    
    self.billAmount.text = [self formatCurrency:amount];
}

-(void)displayTipAmount:(float)amount{
    
    self.tipAmount.text = [self formatCurrency:amount];
}

-(float)calculaterTipPercentageForSegment:(int)segment{
    NSString *tipText = [self.tipPercentage titleForSegmentAtIndex:segment];
    return [tipText floatValue] / 100.0;
}

-(float)getBillAmount{
    return [self.billAmount.text floatValue];
}

-(float)calculateTipAmount:(float)amount percent:(float)percent{
    return amount * percent;
}

-(void)updateDisplayedTip{
    float amount = [self getBillAmount];
    int segment = self.tipPercentage.selectedSegmentIndex;
    float percent = [self calculaterTipPercentageForSegment:segment];
    float tip = [self calculateTipAmount:amount percent:percent];
    self.tipAmount.text = [self formatCurrency:tip];
}

-(void)updateDisplayedTotal{
    float amount = [self getBillAmount];
    int segment = self.tipPercentage.selectedSegmentIndex;
    float percent = [self calculaterTipPercentageForSegment:segment];
    float tip = [self calculateTipAmount:amount percent:percent];
    self.totalAmount.text = [self formatCurrency:tip+amount];
}

@end
