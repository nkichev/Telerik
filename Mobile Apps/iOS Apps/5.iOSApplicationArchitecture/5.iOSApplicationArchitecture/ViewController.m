//
//  ViewController.m
//  5.iOSApplicationArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import "ViewController.h"
#import "PasswordsTableViewController.h"
#import "Password.h"

@interface ViewController ()

@end

@implementation ViewController

bool isEqual;

- (void)viewDidLoad {
    [super viewDidLoad];
    isEqual = NO;
    
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)checkPressed:(id)sender {
    NSString *codeText = self.codeInput.text;
    if ([codeText isEqualToString:self.password.code]) {
        isEqual = YES;
        UIAlertView *alerview = [[UIAlertView alloc] initWithTitle:@"Correct!" message:nil delegate:self cancelButtonTitle:@"Ok" otherButtonTitles:nil];
        [alerview show];
        self.codeLabel.text = self.password.name;
        
    } else {
        UIAlertView *alerview = [[UIAlertView alloc] initWithTitle:@"Incorrect!" message:nil delegate:self cancelButtonTitle:@"Ok" otherButtonTitles:nil];
        [alerview show];
        self.codeLabel.text = @"";
    }
}

@end
