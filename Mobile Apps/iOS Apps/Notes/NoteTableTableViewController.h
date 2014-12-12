//
//  NoteTableTableViewController.h
//  Notes
//
//  Created by Pesho on 11/2/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "List.h"
#import "AddNoteViewController.h"
#import "DisplayNoteViewController.h"

@interface NoteTableTableViewController : UITableViewController

@property (nonatomic) List *listOfNotes;

@end
