//
//  ListDetailsViewController.h
//  6.Storyboards
//
//  Created by Kris Kichev on 11/3/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "List.h"

@interface ListDetailsViewController : UIViewController<UITableViewDataSource, UITableViewDelegate>

@property (weak, nonatomic) IBOutlet UILabel *listTitleLabel;
@property (weak, nonatomic) IBOutlet UITableView *listNotesTable;
@property (strong, nonatomic) List *list;
@property (strong, nonatomic) NSArray *notes;
@property (weak, nonatomic) IBOutlet UITableView *noteTable;

@end
