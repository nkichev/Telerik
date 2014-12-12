//
//  Raiden.m
//  04.OOP-Principles
//
//  Created by Kris Kichev on 10/29/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "Raiden.h"

@implementation Raiden

-(instancetype)init{
    self = [super init];
    if (self) {
        self.name = @"Raiden";
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

-(void)lightningStrike:(Character *)opponent{
    if (opponent.lifePoints > 0 && self.powerPoints > 0) {
        opponent.lifePoints -= 30;
        self.powerPoints -= 30;
        NSLog(@"Lightning strike!, power: %d", self.powerPoints);
        if (opponent.lifePoints <= 0) {
            NSLog(@"%@ has been killed!", opponent.name);
        }
    }
}

@end