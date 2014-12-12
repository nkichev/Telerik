//
//  DisplayPhotosViewController.m
//  PhotoViewer
//
//  Created by Kris Kichev on 10/28/14.
//  Copyright (c) 2014 Nikolay Kichev. All rights reserved.
//

#import "DisplayPhotosViewController.h"

@interface DisplayPhotosViewController ()

@property (weak, nonatomic) IBOutlet UIImageView *currentImage;

@end

@implementation DisplayPhotosViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    self.title = self.currentPhoto.name;
    // Do any additional setup after loading the view.
    UIImage *img = [UIImage imageNamed:self.currentPhoto.filename];
    [self.currentImage setImage:img];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}


#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    InfoViewController *ivc = [segue destinationViewController];
    // Pass the selected object to the new view controller.
    ivc.currentPhoto = self.currentPhoto;
    
}


@end
