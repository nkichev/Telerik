#import <Foundation/Foundation.h>

#import "Calculator.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        Calculator *calculator = [[Calculator alloc] init];
        
        [calculator addValue:5];
        [calculator subtractValue:2.5];
        [calculator multiplyBy:6];
        [calculator divideBy:3];
        [calculator printResult];
    }
    return 0;
}
