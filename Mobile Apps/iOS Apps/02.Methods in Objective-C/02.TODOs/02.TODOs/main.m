#import <Foundation/Foundation.h>
#import "TODO.h"
#import "TODOsManager.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        TODOsManager *manager = [[TODOsManager alloc] init];
        
        NSDate *now = [NSDate date];
        NSDate *firstTodoEndDate = [now dateByAddingTimeInterval:(60 * 60 * 24 * 7)];
        NSDate *secondTodoEndDate = [now dateByAddingTimeInterval:(60 * 60 * 24 * 14)];
        
        
        TODO *firstTodo = [TODO initWithTitle:@"homework 1" andEndDate:firstTodoEndDate];
        TODO *secondTodo = [TODO initWithTitle:@"homework 2" andEndDate:secondTodoEndDate];
        
        [manager addTodo:firstTodo];
        [manager addTodo:secondTodo];
        
        [manager listTodos];
    }
    return 0;
}
