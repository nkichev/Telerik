#import "AddEventViewController.h"

@interface AddEventViewController ()

@property (weak, nonatomic) IBOutlet UITextField *textField;

@property (weak, nonatomic) IBOutlet UIBarButtonItem *doneButton;


@end

@implementation AddEventViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    
    if (sender != self.doneButton) return;
    if (self.textField.text.length > 0) {
        self.event = [Event eventWithTitle:self.textField.text category:@"" content:@"" date:[NSDate date] andGuests:[[NSMutableArray alloc] init]];
    }
    
}



@end
