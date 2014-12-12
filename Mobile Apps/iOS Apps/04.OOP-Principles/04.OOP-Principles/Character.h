//
//  Character.h
//  04.OOP-Principles
//
//  Created by Kris Kichev on 10/29/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Character : NSObject

@property (strong, nonatomic) NSString *name;
@property int lifePoints;
@property int powerPoints;

@end
