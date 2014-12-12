//
//  ListsTableViewController.h
//  05.iOSAppArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface ListsTableViewController : UITableViewController

@property (strong, nonatomic) IBOutlet UITableView *listsTable;
@property (strong, nonatomic) NSMutableArray *lists;

@end
