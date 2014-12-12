//
//  Character.m
//  04.OOP-Principles
//
//  Created by Kris Kichev on 10/29/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "Character.h"

@implementation Character

-(instancetype)init{
    
    self = [super init];
    if (self) {
        self.lifePoints = 100;
        self.powerPoints = 50;
    }
    return self;
    
}

@end
