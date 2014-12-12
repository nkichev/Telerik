//
//  DisplayNoteViewController.m
//  Notes
//
//  Created by Pesho on 11/3/14.
//  Copyright (c) 2014 Pesho. All rights reserved.
//

#import "DisplayNoteViewController.h"

@interface DisplayNoteViewController ()

@property (weak, nonatomic) IBOutlet UITextField *titleTextField;
@property (weak, nonatomic) IBOutlet UITextView *detailsTextView;
@property (weak, nonatomic) IBOutlet UIDatePicker *datePicker;
@property (weak, nonatomic) IBOutlet UIButton *confirmButton;
@property (weak, nonatomic) IBOutlet UIButton *editButtonOutlet;

@end

@implementation DisplayNoteViewController{
    NSDate *maximumDate;
}

- (IBAction)editButton:(id)sender {
    [self.titleTextField setEnabled:YES];
    [self.detailsTextView setEditable:YES];
    [self.confirmButton setHidden: NO];
    
    // Prevet from putting past date
    [self.datePicker setMinimumDate:[NSDate date]];
    [self.datePicker setMaximumDate:maximumDate];
    
    [self.editButtonOutlet setHidden: YES];
}
- (IBAction)confirmButtonAction:(id)sender {
    // TODO: validate empty TextFields with TRIM
    self.note.title = self.titleTextField.text;
    self.note.details = self.detailsTextView.text;
    self.note.date = self.datePicker.date;
    
    [self disableEditing];
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
    
    // Set border on detailsTextView
    [[self.detailsTextView layer] setBorderColor:[[UIColor lightGrayColor] CGColor]];
    [[self.detailsTextView layer] setBorderWidth:.4];
    [[self.detailsTextView layer] setCornerRadius:8.0f];
    
    // Update views to show correct data
    [self.titleTextField setText:self.note.title ];
    [self.detailsTextView setText:self.note.details ];
    [self.datePicker setDate:self.note.date];
    
    [self disableEditing];
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

- (void)disableEditing
{
    //Disable Editing
    [self.titleTextField setEnabled:NO];
    [self.detailsTextView setEditable:NO];
    // disable editing datePicker
    maximumDate = [self.datePicker maximumDate];
    NSDate *currentDatePickerDate = [self.datePicker date];
    [self.datePicker setMinimumDate:currentDatePickerDate];
    [self.datePicker setMaximumDate:currentDatePickerDate];
    // Hide confirm button
    [self.confirmButton setHidden:YES];
    [self.editButtonOutlet setHidden: NO];
}

@end
