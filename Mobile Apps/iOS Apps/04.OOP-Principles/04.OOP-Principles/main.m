//
//  main.m
//  04.OOP-Principles
//
//  Created by Kris Kichev on 10/29/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Character.h"
#import "Raiden.h"
#import "Sub-Zero.h"
#import "Scorpion.h"


int main(int argc, const char * argv[]) {
    @autoreleasepool {
        Raiden *raiden = [[Raiden alloc] init];
        SubZero *subZero = [[SubZero alloc] init];
        
        [raiden kick:subZero];
        [raiden lightningStrike:subZero];
        [raiden lightningStrike:subZero];
        [raiden kick:subZero];
        [raiden kick:subZero];
        [raiden kick:subZero];
        [raiden lightningStrike:subZero];
    }
    return 0;
}
