#import "TODO.h"

@implementation TODO

+(TODO *) initWithTitle:(NSString *)title
           andEndDate:(NSDate *)endDate {
    TODO *todo = [[TODO alloc] init];
    todo.title = title;
    todo.endDate = endDate;
    
    return todo;
}

-(NSString *) description {
    return [NSString stringWithFormat:@"Todo: %@, end date: %@", self.title, self.endDate];
}

@end
