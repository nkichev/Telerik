//
//  AddNoteViewController.m
//  Notes
//
//  Created by Pesho on 11/3/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import "AddNoteViewController.h"

@interface AddNoteViewController ()

@property (weak, nonatomic) IBOutlet UITextField *titleTextField;
@property (weak, nonatomic) IBOutlet UITextView *detailsTextView;
@property (weak, nonatomic) IBOutlet UIDatePicker *datePicker;

@end

@implementation AddNoteViewController

- (IBAction)addNoteButton:(id)sender {
    // TODO: validate empty TextFields with TRIM
    NSString *title = [self.titleTextField text];
    NSString *details = [self.detailsTextView text];
    
    NSDate *chosen = [self.datePicker date];
    NSDateFormatter *formatter = [[NSDateFormatter alloc] init];
    [formatter setDateFormat: @"MMM dd, yyyy"];
    NSString *date = [formatter stringFromDate:chosen];
    
    Note *currentNote = [[Note alloc] initWithTitle:title Details:details AndDate: [formatter dateFromString:date]];
    [self.newlyAddedNotes addObject:currentNote];
    
    [self.titleTextField setText:@""];
    [self.detailsTextView setText:@""];
    [self.datePicker setDate:[NSDate date]];
    
    [[[UIAlertView alloc] initWithTitle:@"Successful Operation!" message:@"You have successfully added new Note" delegate:nil cancelButtonTitle:@"Continue" otherButtonTitles:nil, nil] show];
}

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

-(void)touchesBegan:(NSSet *)touches withEvent:(UIEvent *)event{
    [self.view endEditing:YES];
}

- (BOOL)textFieldShouldReturn:(UITextField *)textField{
    [self.titleTextField resignFirstResponder];
    
    return YES;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    // Do any additional setup after loading the view.
    [[self.detailsTextView layer] setBorderColor:[[UIColor lightGrayColor] CGColor]];
    [[self.detailsTextView layer] setBorderWidth:.4];
    [[self.detailsTextView layer] setCornerRadius:8.0f];
    [self.datePicker setMinimumDate:[NSDate date]];
    if (!self.newlyAddedNotes) {
        self.newlyAddedNotes = [[NSMutableArray alloc] init];
    }
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
