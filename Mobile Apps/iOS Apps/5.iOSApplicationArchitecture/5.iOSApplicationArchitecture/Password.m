//
//  Password.m
//  5.iOSApplicationArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import "Password.h"

@implementation Password

-(instancetype)initWithName:(NSString *)name andCode:(NSString *)code{
    self = [super init];
    if (self) {
        self.name = name;
        self.code = code;
    }
    
    return self;
}

@end
