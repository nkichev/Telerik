//
//  Note.m
//  Notes
//
//  Created by Pesho on 11/2/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import "Note.h"

@implementation Note

- (instancetype)initWithTitle: (NSString*) title
                  Details: (NSString*) details
                      AndDate:(NSDate*) date
{
    self = [super init];
    if (self) {
        self.title = title;
        self.details = details;
        self.date = date;
    }
    return self;
}

@end
