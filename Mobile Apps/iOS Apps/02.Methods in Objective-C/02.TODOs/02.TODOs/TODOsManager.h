#import <Foundation/Foundation.h>
#import "TODO.h"

@interface TODOsManager : NSObject

-(void) addTodo:(TODO *)todo;
-(void) listTodos;

@end
