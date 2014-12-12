//
//  Note.h
//  05.iOSAppArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Note : NSObject

@property NSString *title;
@property NSString *text;
@property NSDate *date;

-(instancetype)initWithTitle:(NSString *)title
                        text:(NSString *)text
                     andDate:(NSDate *)date;

@end
