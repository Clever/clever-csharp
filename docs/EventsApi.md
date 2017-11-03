# Clever.Api.EventsApi

All URIs are relative to *https://api.clever.com/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEvent**](EventsApi.md#getevent) | **GET** /events/{id} | 
[**GetEvents**](EventsApi.md#getevents) | **GET** /events | 


<a name="getevent"></a>
# **GetEvent**
> EventResponse GetEvent (string id)



Returns the specific event

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var id = id_example;  // string | 

            try
            {
                EventResponse result = apiInstance.GetEvent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevents"></a>
# **GetEvents**
> EventsResponse GetEvents (int? limit = null, string startingAfter = null, string endingBefore = null, string school = null, List<string> recordType = null)



Returns a list of events

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 
            var school = school_example;  // string |  (optional) 
            var recordType = new List<string>(); // List<string> |  (optional) 

            try
            {
                EventsResponse result = apiInstance.GetEvents(limit, startingAfter, endingBefore, school, recordType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 
 **school** | **string**|  | [optional] 
 **recordType** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**EventsResponse**](EventsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

