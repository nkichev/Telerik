#import <UIKit/UIKit.h>
#import "EventManager.h"
#import "Event.h"

@interface EventsListTableViewController : UITableViewController

@property EventManager *manager;

- (IBAction)unwindToList:(UIStoryboardSegue *)segue;

@end
