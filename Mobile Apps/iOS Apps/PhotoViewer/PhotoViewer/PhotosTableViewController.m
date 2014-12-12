//
//  PhotosTableViewController.m
//  PhotoViewer
//
//  Created by Kris Kichev on 10/28/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "PhotosTableViewController.h"

@interface PhotosTableViewController () {
    NSMutableArray *photos;
}

@end

@implementation PhotosTableViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    self.title = @"Photos";
    
    photos = [[NSMutableArray alloc] init];
    
    Photo *pic = [[Photo alloc] init];
    pic.name = @"Sunset";
    pic.filename = @"sunset";
    pic.notes = @"Sunset is really awesome!";
    
    [photos addObject:pic];
    
    pic = [[Photo alloc] init];
    pic.name = @"Sunrise";
    pic.filename = @"sunrise";
    pic.notes = @"Sunrise is really awesome!";
    
    [photos addObject:pic];
    
    pic = [[Photo alloc] init];
    pic.name = @"Nature";
    pic.filename = @"nature";
    pic.notes = @"Nature is really awesome!";
    
    [photos addObject:pic];
    
    pic = [[Photo alloc] init];
    pic.name = @"Water";
    pic.filename = @"water";
    pic.notes = @"Water is really awesome!";
    
    [photos addObject:pic];
    
    
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
    return [photos count];
}


- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    
    static NSString *CellIdentifier = @"Cell";
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:CellIdentifier forIndexPath:indexPath];
    
    // Configure the cell...
    Photo *current = photos[indexPath.row];
    cell.textLabel.text = current.name;
    
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
    DisplayPhotosViewController *pvc = [segue destinationViewController];
    // Pass the selected object to the new view controller.
    NSIndexPath *path = [self.tableView indexPathForSelectedRow];
    Photo *c = photos[path.row];
    pvc.currentPhoto = c;
}

@end
