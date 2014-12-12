//
//  ListTableViewController.h
//  Notes
//
//  Created by Pesho on 11/2/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "AddListViewController.h"
#import "NoteTableTableViewController.h"
#import "List.h"


@interface ListTableViewController : UITableViewController

@property (nonatomic) NSMutableArray *allListsOfNotes;
@property (nonatomic) NSMutableSet *categoriesSet;

@end
