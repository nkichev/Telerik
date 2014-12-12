#import <UIKit/UIKit.h>
#import "AppDelegate.h"
#import "Event.h"
#import "EventManager.h"

int main(int argc, char * argv[]) {
    @autoreleasepool {
        NSDate *firstEventDate = [[NSDate date] dateByAddingTimeInterval:(60 * 60 * 24 * 14)];
        NSMutableArray *firstEventGuests = [NSMutableArray arrayWithArray:@[@"Joro", @"Ivan", @"Maria", @"Misho", @"Geri"]];
        
        Event *firstEvent = [Event eventWithTitle:@"Birthday party" category:@"birthday" content:@"Birthday party for Ivan Dimov" date:firstEventDate andGuests:firstEventGuests];
        
        NSDate *secondEventDate = [[NSDate date] dateByAddingTimeInterval:(60 * 60 * 24 * 18)];
        NSMutableArray *secondEventGuests = [NSMutableArray arrayWithArray:@[@"Mimi", @"Petar", @"Dimi", @"Silvi", @"Geri"]];
        
        Event *secondEvent = [Event eventWithTitle:@"Graduation celebration" category:@"celebration" content:@"Graduation celebration in Hotel Moscow for successfully completed bachelor degree" date:secondEventDate andGuests:secondEventGuests];
        
        EventManager *manager = [[EventManager alloc] init];
        [manager createEvent:firstEvent];
        [manager createEvent:secondEvent];
//        [manager sortEventsByTitle];
//        [manager sortEventsByDate];
//        [manager listEventsByCategory:@"birthday"];
        
        return UIApplicationMain(argc, argv, nil, NSStringFromClass([AppDelegate class]));
    }
}
