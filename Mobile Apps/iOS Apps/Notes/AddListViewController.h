//
//  AddListViewController.h
//  Notes
//
//  Created by Pesho on 11/2/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "List.h"

@interface AddListViewController : UIViewController

@property (nonatomic) NSMutableArray *newlyAddedListsOfNotes;
@property (nonatomic) NSMutableSet *categoriesSet;

@end
