//
//  Fighting.h
//  04.OOP-Principles
//
//  Created by Kris Kichev on 10/29/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import <Foundation/Foundation.h>

@protocol Fighting <NSObject>

-(void)kick:(Character *)opponent;

-(void)punch:(Character *)opponent;

@end
