#import "Calculator.h"

@implementation Calculator {
    NSMutableString *operations;
}

-(instancetype) init {
    self = [super init];
    if (self) {
        operations = [[NSMutableString alloc] init];
        [self clear];
    }
    return self;
}

-(void) clear {
    self.result = 0;
    [operations setString:@"0"];
}

-(void) addValue:(double)value {
    [operations appendFormat:@" + %0.2f", value];
    self.result += value;
}

-(void) subtractValue:(double)value {
    [operations appendFormat:@" - %0.2f", value];
    self.result -= value;
}

-(void) divideBy:(double)value {
    [operations appendFormat:@" / %0.2f", value];
    self.result /= value;
}

-(void) multiplyBy:(double)value {
    [operations appendFormat:@" * %0.2f", value];
    self.result *= value;
}

-(void) printResult {
    [operations appendFormat:@" = %0.2f", self.result];
    NSLog(@"%@", operations);
    [self clear];
}

@end
