//
//  Note.m
//  05.iOSAppArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import "Note.h"

@implementation Note

-(instancetype)init{
    self = [super init];
    if (self) {
        
    }
    
    return self;
}

-(instancetype)initWithTitle:(NSString *)title
                        text:(NSString *)text
                     andDate:(NSDate *)date{
    self = self.init;
    self.title = title;
    self.text = text;
    self.date = date;
    
    return self;
}

@end
