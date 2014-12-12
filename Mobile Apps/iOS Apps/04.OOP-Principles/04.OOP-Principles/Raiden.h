//
//  Raiden.h
//  04.OOP-Principles
//
//  Created by Kris Kichev on 10/29/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Character.h"
#import "Fighting.h"

@interface Raiden : Character<Fighting>

-(void)lightningStrike:(Character *)opponent;

@end
