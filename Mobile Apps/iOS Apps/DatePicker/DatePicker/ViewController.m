//
//  ViewController.m
//  DatePicker
//
//  Created by Kris Kichev on 10/27/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()

@property (weak, nonatomic) IBOutlet UIDatePicker *datePicker;

@end

@implementation ViewController

- (IBAction)displayDay:(id)sender {
    NSDate *chosen = [self.datePicker date];
    NSDateFormatter *formatter = [[NSDateFormatter alloc] init];
    [formatter setDateFormat:@"EEEE"];
    NSString *weeday = [formatter stringFromDate:chosen];
    NSString *msg = [[NSString alloc] initWithFormat:@"That's a %@", weeday];
    
    UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"What day is that?" message:msg delegate:nil cancelButtonTitle:@"OK" otherButtonTitles:nil, nil];
    [alert show];
    
}

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
