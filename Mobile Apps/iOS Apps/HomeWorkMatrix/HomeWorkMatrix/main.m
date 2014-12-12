//
//  main.m
//  HomeWorkMatrix
//
//  Created by Admin on 10/25/14.
//  Copyright (c) 2014 ILR. All rights reserved.
//

#import <Foundation/Foundation.h>

NSMutableString *squareMatrixAsString(NSMutableArray *squareMatrix){
    
    NSMutableString *outputString = [[NSMutableString alloc] init];
    
    for (int row = 0; row < squareMatrix.count; row++) {
        
        for (int col=0; col < squareMatrix.count ; col++) {
            [outputString appendFormat:@"%@ ", squareMatrix[row][col]];
        }
        [outputString appendFormat:@"\n"];
    }
    
    return outputString;
}

void spiralFiller(NSMutableArray *squareMatrix){
    int input = 1;
    int currentCol = 0;
    int currentRow = 0;
    int rowDirection = 0;
    int colDirection = 1;
    
    while (input <= squareMatrix.count*squareMatrix.count) {
        squareMatrix[currentRow][currentCol] = [NSNumber numberWithInt:input];
        input++;
        
        int nextRow = currentRow + rowDirection;
        int nextCol = currentCol + colDirection;
        
        if (nextRow <0 ||
            nextRow >= squareMatrix.count ||
            nextCol <0 ||
            nextCol >= squareMatrix.count ||
            [squareMatrix[nextRow][nextCol] intValue] != 0) {
            
            if (rowDirection == 1) {
                rowDirection = 0;
                colDirection = -1;
            }
            else if (rowDirection == -1){
                rowDirection = 0;
                colDirection = 1;
            }
            else if (colDirection == 1){
                colDirection = 0;
                rowDirection = 1;
            }
            else if (colDirection == -1){
                colDirection = 0;
                rowDirection = -1;
            }
        }
        currentRow += rowDirection;
        currentCol += colDirection;
    }

}

NSMutableArray* sqareMatrixInstanceWithSize(int size){
    NSMutableArray *squareMatrix = [[NSMutableArray alloc] initWithCapacity: size];
    
    for (int row = 0; row < size; row++) {
        
        squareMatrix[row]=[[NSMutableArray alloc] initWithCapacity:size];
        
        for (int col=0; col < size ; col++) {
            squareMatrix[row][col] = @0;
        }
    }
    return squareMatrix;
}

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        
        //Creating matrix by size - Enter size here
        
        NSMutableArray *squareMatrix = sqareMatrixInstanceWithSize(3);
        
        //Filling in spiral
        
        spiralFiller(squareMatrix);
        
        //Printing matrix
        
        NSLog(@"\n%@", squareMatrixAsString(squareMatrix));
    }
    return 0;
}