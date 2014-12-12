//
//  List.m
//  Notes
//
//  Created by Pesho on 11/2/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import "List.h"

@implementation List{
    NSMutableArray *allNotes;
}

-(int) notesCount{
    return allNotes.count;
}

-(instancetype)initWithTitle: (NSString*) title
                         AndCategory: (NSString*) category
{
    self = [super init];
    if (self) {
        self.title = title;
        self.category = category;
        allNotes = [[NSMutableArray alloc] init];
    }
    return self;
}

-(NSArray *)getAllNotes{
    NSArray *allNotesToReturn = [[NSArray alloc] initWithArray:allNotes];
    return allNotesToReturn;
}

-(void)addNote:(Note *)note{
    [allNotes addObject:note];
}

// TODO: Protocol for validation?
-(void)addNotesFromArray:(NSArray *)arrayOfNotes{
    [allNotes addObjectsFromArray:arrayOfNotes];
}

@end
