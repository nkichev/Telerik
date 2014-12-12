//
//  List.h
//  Notes
//
//  Created by Pesho on 11/2/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Note.h"
@interface List : NSObject

@property (nonatomic) NSString *title;
@property (nonatomic) NSString *category;
@property (nonatomic, readonly) int notesCount;

- (instancetype)initWithTitle: (NSString*) title
                     AndCategory: (NSString*) category;

// Shallow Copy
-(NSArray*)getAllNotes;
-(void)addNote: (Note*) note;
-(void)addNotesFromArray:(NSArray *)arrayOfNotes;
// TODO: remove Note
//
@end
