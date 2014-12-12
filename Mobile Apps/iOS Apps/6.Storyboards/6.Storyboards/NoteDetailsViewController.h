//
//  NoteDetailsViewController.h
//  6.Storyboards
//
//  Created by Kris Kichev on 11/3/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Note.h"

@interface NoteDetailsViewController : UIViewController

@property (weak, nonatomic) IBOutlet UILabel *noteTitle;
@property (weak, nonatomic) IBOutlet UILabel *noteText;
@property (weak, nonatomic) IBOutlet UILabel *noteDate;

@property (strong, nonatomic) Note *note;

@end
