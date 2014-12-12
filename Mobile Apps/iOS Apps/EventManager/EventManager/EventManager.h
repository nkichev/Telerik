#import <Foundation/Foundation.h>
#import "Event.h"

@interface EventManager : NSObject

@property (strong, nonatomic) NSMutableArray *events;

- (void) createEvent:(Event *)event;
- (void) listEvents;
- (void) listEventsByCategory:(NSString *)category;
- (void) sortEventsByDate;
- (void) sortEventsByTitle;

@end
