//
//  ListDetailsViewController.h
//  05.iOSAppArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "List.h"

@interface ListDetailsViewController : UIViewController<UITableViewDataSource, UITableViewDelegate>
@property (weak, nonatomic) IBOutlet UILabel *listName;
@property (weak, nonatomic) IBOutlet UITableView *listNotes;
@property (strong, nonatomic) List *list;

@end
