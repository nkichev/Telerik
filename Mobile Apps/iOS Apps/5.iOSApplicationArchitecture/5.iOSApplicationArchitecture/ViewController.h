//
//  ViewController.h
//  5.iOSApplicationArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Password.h"

@interface ViewController : UIViewController

@property Password *password;
- (IBAction)checkPressed:(id)sender;
@property (weak, nonatomic) IBOutlet UITextField *codeInput;
@property (weak, nonatomic) IBOutlet UILabel *codeLabel;

@end

