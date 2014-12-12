#import <Foundation/Foundation.h>

@interface TODO : NSObject

@property NSString *title;
@property NSDate *endDate;

+(TODO *) initWithTitle:(NSString *)title
               andEndDate:(NSDate *)endDate;

@end
