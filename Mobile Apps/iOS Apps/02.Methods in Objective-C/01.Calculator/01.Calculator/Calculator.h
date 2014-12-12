#import <Foundation/Foundation.h>

@interface Calculator : NSObject

@property (nonatomic) double result;

-(void) addValue:(double)value;
-(void) subtractValue:(double)value;
-(void) divideBy:(double)value;
-(void) multiplyBy:(double)value;
-(void) clear;
-(void) printResult;

@end
