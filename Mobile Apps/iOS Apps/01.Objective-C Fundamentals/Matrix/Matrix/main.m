#import <Foundation/Foundation.h>

void printMatrix(NSArray *matrix){
    NSMutableString *result = [[NSMutableString alloc] init];
    for (NSArray *row in matrix) {
        for (NSNumber *number in row) {
            [result appendFormat:@"%d ", [number intValue]];
        }
        [result appendString:@"\n"];
    }
    
    NSLog(@"\n%@", result);
}

NSArray* createSpiral(int n) {
    
    NSMutableArray *matrix = [[NSMutableArray alloc] initWithCapacity:n];
    for (int i = 0; i < n; i++) {
        matrix[i] = [[NSMutableArray alloc] initWithCapacity:n];
        for (int j = 0; j < n; j++) {
            matrix[i][j] = [NSNull null];
        }
    }
    
    int x = 0;
    int y = 0;
    int dx = 0;
    int dy = 1;
    
    for (int i = 0; i < n * n; i++) {
        matrix[x][y] = [NSNumber numberWithInt:i+1];
        int nx = x + dx;
        int ny = y + dy;
        if (0 <= nx && nx < n && 0 <= ny && ny < n && [matrix[nx][ny] isEqual:[NSNull null]]) {
            x = nx;
            y = ny;
        } else {
            int temp = dx;
            dx = dy;
            dy = -temp;
            x = x + dx;
            y = y + dy;
        }
    }
    
    return matrix;
}


int main(int argc, const char * argv[]) {
    @autoreleasepool {
        NSMutableArray *spiral = [[NSMutableArray alloc] initWithObjects:
                                 [[NSMutableArray alloc] initWithObjects:@1,@2,@3, nil],
                                 [[NSMutableArray alloc] initWithObjects:@8,@9,@4, nil],
                                 [[NSMutableArray alloc] initWithObjects:@7,@6,@5, nil], nil];
        printMatrix(spiral);
        
        NSArray *newSpiral = createSpiral(6);
        printMatrix(newSpiral);
        
    }
    return 0;
}
