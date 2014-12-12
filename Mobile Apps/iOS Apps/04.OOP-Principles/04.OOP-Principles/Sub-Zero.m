//
//  Sub-Zero.m
//  04.OOP-Principles
//
//  Created by Kris Kichev on 10/29/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "Sub-Zero.h"

@implementation SubZero

-(instancetype)init{
    self = [super init];
    if (self) {
        self.name = @"Sub-Zero";
    }
    
    return self;
}

-(void)kick:(Character *)opponent{
    if (opponent.lifePoints > 0) {
        opponent.lifePoints -= 10;
        self.powerPoints += 10;
        NSLog(@"%@ has been kicked, life: %d, your power: %d", opponent.name, opponent.lifePoints, self.powerPoints);
        if (opponent.lifePoints <= 0) {
            NSLog(@"%@ has been killed!", opponent.name);
        }
    }
}

-(void)punch:(Character *)opponent{
    if (opponent.lifePoints > 0) {
        opponent.lifePoints -= 10;
        self.powerPoints += 10;
        NSLog(@"%@ has been punched, life: %d, your power: %d", opponent.name, opponent.lifePoints, self.powerPoints);
        if (opponent.lifePoints <= 0) {
            NSLog(@"%@ has been killed!", opponent.name);
        }
    }
}

-(void)freeze:(Character *)opponent{
    if (opponent.lifePoints > 0 && self.powerPoints > 0) {
        opponent.lifePoints -= 30;
        self.powerPoints -= 30;
        NSLog(@"Freeze Attack!, power: %d", self.powerPoints);
        if (opponent.lifePoints <= 0) {
            NSLog(@"%@ has been killed!", opponent.name);
        }
    }
}

@end
