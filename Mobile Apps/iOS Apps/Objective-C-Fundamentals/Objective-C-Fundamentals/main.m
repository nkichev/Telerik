#import <Foundation/Foundation.h>

NSArray* createSpiralMatrix(int size)
{
    NSMutableArray* matrix = [[NSMutableArray alloc] initWithCapacity:size];
    NSNull* nullValue = [NSNull null];

    for (int row = 0; row < size; row++) {
        matrix[row] = [[NSMutableArray alloc] initWithCapacity:size];
        for (int col = 0; col < size; col++) {
            matrix[row][col] = nullValue;
        }
    }

    int posX = 0;
    int posY = 0;
    int directionX = 0;
    int directionY = 1;

    int numbersCount = size * size;
    for (int matrixNumber = 0; matrixNumber < numbersCount; matrixNumber++) {
        matrix[posX][posY] = [NSNumber numberWithInt:matrixNumber + 1];

        int newPosX = posX + directionX;
        int newPosY = posY + directionY;

        // If the new position is in the array bound and it's empty
        if (newPosX < 0 || newPosY < 0 || newPosX >= size || newPosY >= size ||
            [matrix[newPosX][newPosY] isNotEqualTo:nullValue]) {
            // Change direction clockwise (swap direction values)
            int tempValue = directionX;
            directionX = directionY;
            directionY = -tempValue;

            // Update position
            posX += directionX;
            posY += directionY;
        }
        else {
            // Continue same direction
            posX = newPosX;
            posY = newPosY;
        }
    }

    return matrix;
}

void printMatrix(NSArray* matrix)
{
    NSMutableString* stringBuilder = [NSMutableString string];
    [stringBuilder appendString:@"\n"];

    for (NSArray* row in matrix) {
        for (NSNumber* cell in row) {
            [stringBuilder appendFormat:@"%3d, ", [cell intValue]];
        }

        [stringBuilder appendString:@"\n"];
    }

    NSLog(@"%@", stringBuilder);
}

int main(int argc, const char* argv[])
{
    @autoreleasepool
    {
        NSLog(@"Task1 matrix 1:\n");
        NSArray* task1Matrix1 = @[
            @[ @1, @2, @3 ],
            @[ @8, @9, @4 ],
            @[ @7, @6, @5 ],
        ];
        printMatrix(task1Matrix1);
        NSLog(@"Task1 matrix 2:\n");
        NSArray* task1Matrix2 = @[
            @[ @1, @2, @3, @4 ],
            @[ @12, @13, @14, @5 ],
            @[ @11, @16, @15, @6 ],
            @[ @10, @9, @8, @7 ]
        ];
        printMatrix(task1Matrix2);
        NSLog(@"Task1 matrix 3:\n");
        NSArray* task1Matrix3 = @[
            @[ @1, @2, @3, @4, @5 ],
            @[ @14, @15, @16, @17, @6 ],
            @[ @13, @20, @19, @18, @7 ],
            @[ @12, @11, @10, @9, @8 ]
        ];
        printMatrix(task1Matrix3);

        NSLog(@"\nEnter matrix size: ");
        int matrixSize;
        // TODO: Enter key on numpad doesn't work
        scanf("%d", &matrixSize);

        NSLog(@"\nSpiral matrix with size: %d", matrixSize);
        NSArray* spiralMatrix = createSpiralMatrix(matrixSize);
        printMatrix(spiralMatrix);
    }
    return 0;
}
