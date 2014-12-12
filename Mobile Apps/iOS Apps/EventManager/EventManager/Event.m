#import "Event.h"

@implementation Event

-(instancetype)init{
    self = [super init];
    if (self) {
        self.guests = [[NSMutableArray alloc] init];
    }
    
    return self;
}

+(instancetype)eventWithTitle:(NSString *)title category:(NSString *)category content:(NSString *)content date:(NSDate *)date andGuests:(NSMutableArray *)guests{
    
    Event *event = [[Event alloc] init];
    event.guests = [[NSMutableArray alloc] init];
    
    event.title = title;
    event.category = category;
    event.content = content;
    event.date = date;
    event.guests = guests;
    
    return event;
}

-(NSString *)description{
    return [NSString stringWithFormat:@"Title: %@, Category: %@, Content: %@, Date: %@, Guests: %@", self.title, self.category, self.content, self.date, [self.guests componentsJoinedByString:@" ,"]];
}

@end
