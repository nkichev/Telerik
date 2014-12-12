//
//  HTTPRequester.m
//  08.MakeHTTPRequests
//
//  Created by Kris Kichev on 11/4/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import "HTTPRequester.h"

@implementation HTTPRequester{
    NSString *baseUrl;
}

static NSString *getMethod = @"GET";
static NSString *postMethod = @"POST";
static NSString *putMethod = @"PUT";
static NSString *deleteMethod = @"DELETE";

-(instancetype)initWithBase:(NSString *)baseUrl{
    self = [super init];
    if (self) {
        baseUrl = baseUrl;
    }
    
    return self;
}

+(HTTPRequester *)requesterWithBase:(NSString *)baseUrl{
    return [[HTTPRequester alloc] initWithBase:baseUrl];
}

-(void)createRequest:(NSString *)method
                 url:(NSString *)url
                data:(NSData *)data
             headers:(NSDictionary *)headers
           andTarget:(NSObject *)target{
    NSString *urll = [NSString stringWithFormat:@"%@%@", baseUrl, url];
    
    NSMutableURLRequest *request = [NSMutableURLRequest requestWithURL:[NSURL URLWithString:urll]];
    [request setHTTPMethod:method];
    
    if (headers) {
        for (id key in headers) {
            [request setValue:[headers objectForKey:key] forHTTPHeaderField:key];
        }
    }
    else {
        [request setValue:@"application/json" forHTTPHeaderField:@"Content-type"];
        [request setValue:@"application/json" forHTTPHeaderField:@"Accepr"];
    }
    
    if (data) {
        [request setHTTPBody:data];
    }
    
    [NSURLConnection connectionWithRequest:request delegate:target];
}

-(void)get:(NSString *)url headers:(NSDictionary *)headers andTarget:(NSObject *)target{
    [self createRequest:getMethod url:url data:nil headers:headers andTarget:target];
}

-(void)post:(NSString *)url data:(NSData *)data headers:(NSDictionary *)headers andTarget:(NSObject *)target{
    [self createRequest:postMethod url:url data:data headers:headers andTarget:target];
}

-(void)put:(NSString *)url data:(NSData *)data headers:(NSDictionary *)headers andTarget:(NSObject *)target{
    [self createRequest:putMethod url:url data:data headers:headers andTarget:target];
}

-(void)delete:(NSString *)url data:(NSData *)data headers:(NSDictionary *)headers andTarget:(NSObject *)target{
    [self createRequest:deleteMethod url:url data:data headers:headers andTarget:target];
}

@end
