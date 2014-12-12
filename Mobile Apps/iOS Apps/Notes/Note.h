//
//  Note.h
//  Notes
//
//  Created by Pesho on 11/2/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Note : NSObject

@property (nonatomic) NSString *title;
@property (nonatomic) NSString *details;
@property (nonatomic) NSDate *date;

- (instancetype)initWithTitle: (NSString*) title
                     Details: (NSString*) details
                      AndDate:(NSDate*) date;

@end
