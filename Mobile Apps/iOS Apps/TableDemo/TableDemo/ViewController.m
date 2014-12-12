//
//  ViewController.m
//  TableDemo
//
//  Created by Kris Kichev on 10/27/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController {
    NSDictionary *courseDetails;
    NSArray *justCourseNames;
    
    NSDictionary *webCourseDetails;
    NSArray *justWebCourseNames;
}

-(NSInteger)numberOfSectionsInTableView:(UITableView *)tableView{
    return 2;
}


-(NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section{
    if (section == 0) {
        return [courseDetails count];
    } else {
        return [webCourseDetails count];
    }
}

-(NSString *)tableView:(UITableView *)tableView titleForHeaderInSection:(NSInteger)section{
    if (section == 0) {
        return @"iOS Courses";
    } else {
        return @"iOS Web Courses";
    }
}

-(UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath{
    
    // UITableViewCell *cell = [[UITableViewCell alloc] initWithStyle:UITableViewCellStyleDefault reuseIdentifier:@"cell"];
    
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:@"cell"];
    
    
    if (indexPath.section == 0) {
        cell.textLabel.text = justCourseNames[indexPath.row];
        cell.detailTextLabel.text = courseDetails[justCourseNames[indexPath.row]];
    } else {
        cell.textLabel.text = justWebCourseNames[indexPath.row];
        cell.detailTextLabel.text = webCourseDetails[justWebCourseNames[indexPath.row]];
    }
    
    return cell;
}

- (void)viewDidLoad {
    [super viewDidLoad];
    // Reading content from plist file
    // NSURL *url = [[NSBundle mainBundle] URLForResource:@"courses" withExtension:@"plist"];
    // courseDetails = [NSDictionary dictionaryWithContentsOfURL:url];
    
    // Do any additional setup after loading the view, typically from a nib.
    courseDetails = @{@"iOS App Dev Essential Training" : @"Simon Allardice",
                      @"iOS 7 SDK New Feauture" : @"Simon Allardice",
                      @"iOS SDK and SQLite: Building Data" : @"Bill Weinman",
                      @"iOS SDK: Building Apps with MapKit" : @"Simon Allardice",
                      @"iOS 6 SDK New Feautures" : @"Simon Allardice"};
    
    webCourseDetails = @{@"Apps for iOS" : @"Doncho Minkov",
                      @"Apps for Android" : @"Antony Jekov",
                      @"Hybrid Apps" : @"Doncho Minkov"};
    
    justCourseNames = courseDetails.allKeys;
    justWebCourseNames = webCourseDetails.allKeys;
    
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
