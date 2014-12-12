//
//  List.h
//  05.iOSAppArchitecture
//
//  Created by Kris Kichev on 11/2/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Note.h"

@interface List : NSObject

@property NSMutableArray *notes;
@property NSString *title;

-(instancetype)initWithNotes:(NSMutableArray *)notes
                    andTitle:(NSString *)title;

@end
