//
//  ViewController.m
//  CustomViews
//
//  Created by Kris Kichev on 10/30/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import "ViewController.h"
#import "DetailsUIView.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    DetailsUIView *detailsUiView = [[NSBundle mainBundle] loadNibNamed:@"DetailsView" owner:self options:nil][0];
    
    [self.view addSubview:detailsUiView];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
