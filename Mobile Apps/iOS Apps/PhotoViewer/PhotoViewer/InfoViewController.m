//
//  InfoViewController.m
//  PhotoViewer
//
//  Created by Kris Kichev on 10/28/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "InfoViewController.h"

@interface InfoViewController ()

@property (weak, nonatomic) IBOutlet UILabel *detailsLabel;

@end

@implementation InfoViewController

- (IBAction)dismiss:(id)sender {
    [self dismissViewControllerAnimated:YES completion:nil];
}

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
    self.detailsLabel.text = self.currentPhoto.notes;
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

@end
