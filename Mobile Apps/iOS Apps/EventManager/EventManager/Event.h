#import <Foundation/Foundation.h>

@interface Event : NSObject

@property (strong, nonatomic) NSString *title;
@property (strong, nonatomic) NSString *category;
@property (strong, nonatomic) NSString *content;
@property (strong, nonatomic) NSDate *date;
@property (strong, nonatomic) NSMutableArray *guests;

+ (instancetype) eventWithTitle:(NSString *)title
                       category:(NSString *)category
                        content:(NSString *)content
                           date:(NSDate *)date
                      andGuests:(NSMutableArray *)guests;

@end
