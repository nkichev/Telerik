//
//  List.h
//  6.Storyboards
//
//  Created by Kris Kichev on 11/3/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface List : NSObject

@property NSMutableArray *notes;
@property NSString *title;

-(instancetype)initWithNotes:(NSMutableArray *)notes
                    andTitle:(NSString *)title;

@end
