//
//  List.m
//  6.Storyboards
//
//  Created by Kris Kichev on 11/3/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import "List.h"

@implementation List

-(instancetype)init{
    self = [super init];
    if (self) {
        self.notes = [[NSMutableArray alloc] init];
    }
    
    return self;
}

-(instancetype)initWithNotes:(NSMutableArray *)notes
                    andTitle:(NSString *)title{
    self = [self init];
    self.title = title;
    self.notes = notes;
    
    return self;
}

@end
