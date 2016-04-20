using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UMeng.Touch.Analytics
{
    // @interface MobClick : NSObject <UIAlertViewDelegate>
    [BaseType(typeof(NSObject))]
    interface MobClick : IUIAlertViewDelegate
    {
        // +(void)setAppVersion:(NSString *)appVersion;
        [Static]
        [Export("setAppVersion:")]
        void SetAppVersion(string appVersion);

        // +(void)setCrashReportEnabled:(BOOL)value;
        [Static]
        [Export("setCrashReportEnabled:")]
        void SetCrashReportEnabled(bool value);

        // +(void)setLogEnabled:(BOOL)value;
        [Static]
        [Export("setLogEnabled:")]
        void SetLogEnabled(bool value);

        // +(void)setBackgroundTaskEnabled:(BOOL)value;
        [Static]
        [Export("setBackgroundTaskEnabled:")]
        void SetBackgroundTaskEnabled(bool value);

        // +(void)setEncryptEnabled:(BOOL)value;
        [Static]
        [Export("setEncryptEnabled:")]
        void SetEncryptEnabled(bool value);

        // +(void)startWithAppkey:(NSString *)appKey;
        [Static]
        [Export("startWithAppkey:")]
        void StartWithAppkey(string appKey);

        // +(void)startWithAppkey:(NSString *)appKey reportPolicy:(ReportPolicy)rp channelId:(NSString *)cid;
        [Static]
        [Export("startWithAppkey:reportPolicy:channelId:")]
        void StartWithAppkey(string appKey, ReportPolicy rp, string cid);

        // +(void)setLogSendInterval:(double)second;
        [Static]
        [Export("setLogSendInterval:")]
        void SetLogSendInterval(double second);

        // +(void)setLatency:(int)second;
        [Static]
        [Export("setLatency:")]
        void SetLatency(int second);

        // +(void)logPageView:(NSString *)pageName seconds:(int)seconds;
        [Static]
        [Export("logPageView:seconds:")]
        void LogPageView(string pageName, int seconds);

        // +(void)beginLogPageView:(NSString *)pageName;
        [Static]
        [Export("beginLogPageView:")]
        void BeginLogPageView(string pageName);

        // +(void)endLogPageView:(NSString *)pageName;
        [Static]
        [Export("endLogPageView:")]
        void EndLogPageView(string pageName);

        // +(void)event:(NSString *)eventId;
        [Static]
        [Export("event:")]
        void Event(string eventId);

        // +(void)event:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export("event:label:")]
        void Event(string eventId, string label);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes;
        [Static]
        [Export("event:attributes:")]
        void Event(string eventId, NSDictionary attributes);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes counter:(int)number;
        [Static]
        [Export("event:attributes:counter:")]
        void Event(string eventId, NSDictionary attributes, int number);

        // +(void)beginEvent:(NSString *)eventId;
        [Static]
        [Export("beginEvent:")]
        void BeginEvent(string eventId);

        // +(void)endEvent:(NSString *)eventId;
        [Static]
        [Export("endEvent:")]
        void EndEvent(string eventId);

        // +(void)beginEvent:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export("beginEvent:label:")]
        void BeginEvent(string eventId, string label);

        // +(void)endEvent:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export("endEvent:label:")]
        void EndEventLabel(string eventId, string label);

        // +(void)beginEvent:(NSString *)eventId primarykey:(NSString *)keyName attributes:(NSDictionary *)attributes;
        [Static]
        [Export("beginEvent:primarykey:attributes:")]
        void BeginEvent(string eventId, string keyName, NSDictionary attributes);

        // +(void)endEvent:(NSString *)eventId primarykey:(NSString *)keyName;
        [Static]
        [Export("endEvent:primarykey:")]
        void EndEventPrimarykey(string eventId, string keyName);

        // +(void)event:(NSString *)eventId durations:(int)millisecond;
        [Static]
        [Export("event:durations:")]
        void EventDurations(string eventId, int millisecond);

        // +(void)event:(NSString *)eventId label:(NSString *)label durations:(int)millisecond;
        [Static]
        [Export("event:label:durations:")]
        void EventLabelDurations(string eventId, string label, int millisecond);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes durations:(int)millisecond;
        [Static]
        [Export("event:attributes:durations:")]
        void EventAttributesDurations(string eventId, NSDictionary attributes, int millisecond);

        // +(void)profileSignInWithPUID:(NSString *)puid;
        [Static]
        [Export("profileSignInWithPUID:")]
        void ProfileSignInWithPUID(string puid);

        // +(void)profileSignInWithPUID:(NSString *)puid provider:(NSString *)provider;
        [Static]
        [Export("profileSignInWithPUID:provider:")]
        void ProfileSignInWithPUID(string puid, string provider);

        // +(void)profileSignOff;
        [Static]
        [Export("profileSignOff")]
        void ProfileSignOff();

        // +(void)setLatitude:(double)latitude longitude:(double)longitude;
        [Static]
        [Export("setLatitude:longitude:")]
        void SetLatitude(double latitude, double longitude);

        // +(void)setLocation:(CLLocation *)location;
        [Static]
        [Export("setLocation:")]
        void SetLocation(CLLocation location);

        // +(BOOL)isJailbroken;
        [Static]
        [Export("isJailbroken")] 
        bool IsJailbroken { get; }

        // +(BOOL)isPirated;
        [Static]
        [Export("isPirated")] 
        bool IsPirated { get; }

        // +(void)event:(NSString *)eventId acc:(NSInteger)accumulation;
        [Static]
        [Export("event:acc:")]
        void Event(string eventId, nint accumulation);

        // +(void)event:(NSString *)eventId label:(NSString *)label acc:(NSInteger)accumulation;
        [Static]
        [Export("event:label:acc:")]
        void Event(string eventId, string label, nint accumulation);

        // +(void)startSession:(NSNotification *)notification;
        [Static]
        [Export("startSession:")]
        void StartSession(NSNotification notification);
    }

    [Static] 
    partial interface Constants
    {
        // extern const MobClickSocialTypeString MobClickSocialTypeSina;
        [Field("MobClickSocialTypeSina", "__Internal")]
        NSString MobClickSocialTypeSina { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeTencent;
        [Field("MobClickSocialTypeTencent", "__Internal")]
        NSString MobClickSocialTypeTencent { get; }
         

        // extern const MobClickSocialTypeString MobClickSocialTypeQzone;
        [Field("MobClickSocialTypeQzone", "__Internal")]
        NSString MobClickSocialTypeQzone { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeRenren;
        [Field("MobClickSocialTypeRenren", "__Internal")]
        NSString MobClickSocialTypeRenren { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeDouban;
        [Field("MobClickSocialTypeDouban", "__Internal")]
        NSString MobClickSocialTypeDouban { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeWxsesion;
        [Field("MobClickSocialTypeWxsesion", "__Internal")]
        NSString MobClickSocialTypeWxsesion { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeWxtimeline;
        [Field("MobClickSocialTypeWxtimeline", "__Internal")]
        NSString MobClickSocialTypeWxtimeline { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeHuaban;
        [Field("MobClickSocialTypeHuaban", "__Internal")]
        NSString MobClickSocialTypeHuaban { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeKaixin;
        [Field("MobClickSocialTypeKaixin", "__Internal")]
        NSString MobClickSocialTypeKaixin { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeFacebook;
        [Field("MobClickSocialTypeFacebook", "__Internal")]
        NSString MobClickSocialTypeFacebook { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeTwitter;
        [Field("MobClickSocialTypeTwitter", "__Internal")]
        NSString MobClickSocialTypeTwitter { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeInstagram;
        [Field("MobClickSocialTypeInstagram", "__Internal")]
        NSString MobClickSocialTypeInstagram { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeFlickr;
        [Field("MobClickSocialTypeFlickr", "__Internal")]
        NSString MobClickSocialTypeFlickr { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeQQ;
        [Field("MobClickSocialTypeQQ", "__Internal")]
        NSString MobClickSocialTypeQQ { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeWxfavorite;
        [Field("MobClickSocialTypeWxfavorite", "__Internal")]
        NSString MobClickSocialTypeWxfavorite { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeLwsession;
        [Field("MobClickSocialTypeLwsession", "__Internal")]
        NSString MobClickSocialTypeLwsession { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeLwtimeline;
        [Field("MobClickSocialTypeLwtimeline", "__Internal")]
        NSString MobClickSocialTypeLwtimeline { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeYxsession;
        [Field("MobClickSocialTypeYxsession", "__Internal")]
        NSString MobClickSocialTypeYxsession { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeYxtimeline;
        [Field("MobClickSocialTypeYxtimeline", "__Internal")]
        NSString MobClickSocialTypeYxtimeline { get; }
    }

    // @interface MobClickSocialWeibo : NSObject
    [BaseType(typeof(NSObject))]
    interface MobClickSocialWeibo
    {
        // @property (copy, nonatomic) NSString * platformType;
        [Export("platformType")]
        string PlatformType { get; set; }

        // @property (copy, nonatomic) NSString * weiboId;
        [Export("weiboId")]
        string WeiboId { get; set; }

        // @property (copy, nonatomic) NSString * userId;
        [Export("userId")]
        string UserId { get; set; }

        // @property (nonatomic, strong) NSDictionary * param;
        [Export("param", ArgumentSemantic.Strong)]
        NSDictionary Param { get; set; }

        // -(id)initWithPlatformType:(MobClickSocialTypeString)platformType weiboId:(NSString *)weiboId usid:(NSString *)usid param:(NSDictionary *)param;
        [Export("initWithPlatformType:weiboId:usid:param:")]
        IntPtr Constructor(string platformType, string weiboId, string usid, NSDictionary param);
    }

    // typedef void (^MobClickSocialAnalyticsCompletion)(NSDictionary *, NSError *);
    delegate void MobClickSocialAnalyticsCompletion(NSDictionary arg0,NSError arg1);

    // @interface MobClickSocialAnalytics : NSObject
    [BaseType(typeof(NSObject))]
    interface MobClickSocialAnalytics
    {
        // +(void)postWeiboCounts:(NSArray *)weibos appKey:(NSString *)appKey topic:(NSString *)topic completion:(MobClickSocialAnalyticsCompletion)completion;
        [Static]
        [Export("postWeiboCounts:appKey:topic:completion:")] 
        void PostWeiboCounts(NSObject[] weibos, string appKey, string topic, MobClickSocialAnalyticsCompletion completion);
    }
}
