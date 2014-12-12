#import "TODOsManager.h"

@implementation TODOsManager {
    NSMutableArray *todos;
}

-(instancetype) init {
    self = [super init];
    if (self) {
        todos = [[NSMutableArray alloc] init];
    }
    return self;
}

-(void)addTodo:(TODO *)todo {
    [todos addObject:todo];
}

-(void)listTodos{
    NSMutableString *result = [[NSMutableString alloc] init];
    [result appendString:@"\n"];
    for (TODO *todo in todos) {
        [result appendString:[todo description]];
        [result appendString:@"\n"];
    }
    NSLog(@"%@", result);
}

@end
