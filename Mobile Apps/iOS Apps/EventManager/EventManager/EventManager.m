#import "EventManager.h"

@implementation EventManager

-(instancetype)init{
    self = [super init];
    if (self) {
        self.events = [[NSMutableArray alloc] init];
    }
    
    return self;
}

-(void)createEvent:(Event *)event{
    [self.events addObject:event];
}

-(void)listEvents{
    NSMutableString *result = [[NSMutableString alloc] init];
    [result appendString:@"Events:\n"];
    for (Event *event in self.events) {
        [result appendFormat:@"%@\n", event.description];
    }
    NSLog(@"%@", result);
}

-(void)listEventsByCategory:(NSString *)category{
    NSMutableString *result = [[NSMutableString alloc] init];
    [result appendString:@"Events:\n"];
    
    for (Event *event in self.events) {
        if ([event.category isEqualToString:category]) {
            [result appendFormat:@"%@\n", event.description];
        }
    }
    NSLog(@"%@", result);
}

-(void) sortEventsByTitle{
    NSMutableString *result = [[NSMutableString alloc] init];
    [result appendString:@"Events:\n"];
    
    NSSortDescriptor *sortDescriptor;
    sortDescriptor = [[NSSortDescriptor alloc] initWithKey:@"title"
                                                 ascending:YES];
    NSArray *sortDescriptors = [NSArray arrayWithObject:sortDescriptor];
    NSArray *sortedByTitle = [self.events sortedArrayUsingDescriptors:sortDescriptors];
    
    for (Event *event in sortedByTitle) {
        [result appendFormat:@"%@\n", event.description];
    }
    NSLog(@"%@", result);
}

-(void) sortEventsByDate{
    NSMutableString *result = [[NSMutableString alloc] init];
    [result appendString:@"Events:\n"];
    
    NSSortDescriptor *sortDescriptor;
    sortDescriptor = [[NSSortDescriptor alloc] initWithKey:@"date"
                                                 ascending:YES];
    NSArray *sortDescriptors = [NSArray arrayWithObject:sortDescriptor];
    NSArray *sortedByTitle = [self.events sortedArrayUsingDescriptors:sortDescriptors];
    
    for (Event *event in self.events) {
        [result appendFormat:@"%@\n", event.description];
    }
    NSLog(@"%@", result);
}


@end
