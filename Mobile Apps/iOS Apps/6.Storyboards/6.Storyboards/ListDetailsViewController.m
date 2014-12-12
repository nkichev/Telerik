//
//  ListDetailsViewController.m
//  6.Storyboards
//
//  Created by Kris Kichev on 11/3/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import "ListDetailsViewController.h"
#import "NoteDetailsViewController.h"

@interface ListDetailsViewController ()

@end

@implementation ListDetailsViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    self.listTitleLabel.text = self.list.title;
    self.notes = [[NSArray alloc] init];
    self.notes = self.list.notes;
    // Do any additional setup after loading the view.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Table view data source

- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView {
    // Return the number of sections.
    return 1;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
    // Return the number of rows in the section.
    return [self.notes count];;
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:@"notesCell" forIndexPath:indexPath];
    
    List *list = self.notes[indexPath.row];
    cell.textLabel.text = list.title;
    
    // Configure the cell...
    
    return cell;
}

#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    NoteDetailsViewController *destinationVC = [segue destinationViewController];
    // Pass the selected object to the new view controller.
    NSIndexPath *path = [self.noteTable indexPathForSelectedRow];
    destinationVC.note = self.notes[path.row];
}

@end
