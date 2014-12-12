//
//  AddListViewController.m
//  Notes
//
//  Created by Pesho on 11/2/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import "AddListViewController.h"

@interface AddListViewController ()
@property (weak, nonatomic) IBOutlet UITextField *titleTextField;
@property (weak, nonatomic) IBOutlet UITextField *categoryTextField;

@end

@implementation AddListViewController

- (IBAction)addButton:(id)sender {
    NSString *title = self.titleTextField.text;
    NSString *category = self.categoryTextField.text;
    
    // TODO: validate empty TextFields with TRIM
    if (title.length == 0) {
        [[[UIAlertView alloc] initWithTitle:@"Invalid data!" message:@"The 'Title' you entered shouldn't be empty!" delegate:nil cancelButtonTitle:@"Go back" otherButtonTitles:nil, nil] show];
        return;
    }
    if (category.length == 0) {
        [[[UIAlertView alloc] initWithTitle:@"Invalid data!" message:@"The 'Category' you entered shouldn't be empty!" delegate:nil cancelButtonTitle:@"Go back" otherButtonTitles:nil, nil] show];
        return;
    }
    if ([self.categoriesSet containsObject:category]) {
        [[[UIAlertView alloc] initWithTitle:@"Invalid data!" message:@"The 'Category' you entered already exists!" delegate:nil cancelButtonTitle:@"Go back" otherButtonTitles:nil, nil] show];
        return;
    }
    
    List *newListOfNotes = [[List alloc] initWithTitle:title AndCategory:category];
    
    [self.newlyAddedListsOfNotes addObject:newListOfNotes];
    [self.categoriesSet addObject:category];
    
    self.titleTextField.text = @"";
    self.categoryTextField.text = @"";
   
    [[[UIAlertView alloc] initWithTitle:@"Successful Operation!" message:@"You have successfully added new List of Notes" delegate:nil cancelButtonTitle:@"Continue" otherButtonTitles:nil, nil] show];
}

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    // Do any additional setup after loading the view.
    if (!self.newlyAddedListsOfNotes) {
        self.newlyAddedListsOfNotes = [[NSMutableArray alloc] init];
    }
    NSLog(@"From viewDidLoad %d", self.categoriesSet.count);
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender
{
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

@end
