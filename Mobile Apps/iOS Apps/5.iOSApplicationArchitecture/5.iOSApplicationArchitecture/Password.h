//
//  Password.h
//  5.iOSApplicationArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Password : NSObject

@property (strong, nonatomic) NSString *name;
@property (strong, nonatomic) NSString *code;

-(instancetype) initWithName:(NSString *)name
                     andCode:(NSString *)code;

@end
