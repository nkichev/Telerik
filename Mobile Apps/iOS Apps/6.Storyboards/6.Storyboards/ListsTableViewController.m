//
//  ListsTableViewController.m
//  6.Storyboards
//
//  Created by Kris Kichev on 11/3/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import "ListsTableViewController.h"
#import "Note.h"
#import "List.h"
#import "ListDetailsViewController.h"

@interface ListsTableViewController ()

@end

@implementation ListsTableViewController

static NSString *cellIdentifier = @"cell";

- (void)viewDidLoad {
    [super viewDidLoad];
    
    self.lists = [[NSMutableArray alloc] init];
    Note *firstNote = [[Note alloc] initWithTitle:@"First note" text:@"This is the first note" andDate:[NSDate dateWithTimeIntervalSinceNow:60 * 60 * 24 * 10]];
    Note *secondNote = [[Note alloc] initWithTitle:@"Second note" text:@"This is the second note" andDate:[NSDate dateWithTimeIntervalSinceNow:60 * 60 * 24 * 30]];
    List *firstList = [[List alloc] initWithNotes:[[NSMutableArray alloc] initWithObjects:firstNote, secondNote, nil] andTitle:@"First List"];
    List *secondList = [[List alloc] initWithNotes:[[NSMutableArray alloc] initWithObjects:firstNote, secondNote, nil] andTitle:@"Second List"];
    [self.lists addObject:firstList];
    [self.lists addObject:secondList];
    
    // Uncomment the following line to preserve selection between presentations.
    // self.clearsSelectionOnViewWillAppear = NO;
    
    // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
    // self.navigationItem.rightBarButtonItem = self.editButtonItem;
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
    return [self.lists count];;
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:cellIdentifier forIndexPath:indexPath];
    
    List *list = self.lists[indexPath.row];
    cell.textLabel.text = list.title;
    
    // Configure the cell...
    
    return cell;
}

/*
// Override to support conditional editing of the table view.
- (BOOL)tableView:(UITableView *)tableView canEditRowAtIndexPath:(NSIndexPath *)indexPath {
    // Return NO if you do not want the specified item to be editable.
    return YES;
}
*/

/*
// Override to support editing the table view.
- (void)tableView:(UITableView *)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath *)indexPath {
    if (editingStyle == UITableViewCellEditingStyleDelete) {
        // Delete the row from the data source
        [tableView deleteRowsAtIndexPaths:@[indexPath] withRowAnimation:UITableViewRowAnimationFade];
    } else if (editingStyle == UITableViewCellEditingStyleInsert) {
        // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
    }   
}
*/

/*
// Override to support rearranging the table view.
- (void)tableView:(UITableView *)tableView moveRowAtIndexPath:(NSIndexPath *)fromIndexPath toIndexPath:(NSIndexPath *)toIndexPath {
}
*/

/*
// Override to support conditional rearranging of the table view.
- (BOOL)tableView:(UITableView *)tableView canMoveRowAtIndexPath:(NSIndexPath *)indexPath {
    // Return NO if you do not want the item to be re-orderable.
    return YES;
}
*/

#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
    ListDetailsViewController *vc = [segue destinationViewController];
    NSIndexPath *path = [self.tableView indexPathForSelectedRow];
    vc.list = self.lists[path.row];
}

@end
