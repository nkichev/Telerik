//
//  HTTPRequester.h
//  08.MakeHTTPRequests
//
//  Created by Kris Kichev on 11/4/14.
//  Copyright (c) 2014 TelerikAcademyTeamwork. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface HTTPRequester : NSObject

-(instancetype) initWithBase:(NSString *)baseUrl;

+(HTTPRequester *) requesterWithBase:(NSString *)baseUrl;

-(void) get:(NSString *)url
    headers:(NSDictionary *)headers
  andTarget:(NSObject *)target;
-(void) post:(NSString *)url
        data:(NSData *)data
     headers:(NSDictionary *)headers
   andTarget:(NSObject *)target;
-(void) put:(NSString *)url
       data:(NSData *)data
    headers:(NSDictionary *)headers
  andTarget:(NSObject *)target;
-(void) delete:(NSString *)url
          data:(NSData *)data
       headers:(NSDictionary *)headers
     andTarget:(NSObject *)target;

@end
