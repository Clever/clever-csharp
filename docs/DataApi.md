# Clever.Api.DataApi

All URIs are relative to *https://api.clever.com/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetContact**](DataApi.md#getcontact) | **GET** /contacts/{id} | 
[**GetContacts**](DataApi.md#getcontacts) | **GET** /contacts | 
[**GetContactsForStudent**](DataApi.md#getcontactsforstudent) | **GET** /students/{id}/contacts | 
[**GetCourse**](DataApi.md#getcourse) | **GET** /courses/{id} | 
[**GetCourseForSection**](DataApi.md#getcourseforsection) | **GET** /sections/{id}/course | 
[**GetCourses**](DataApi.md#getcourses) | **GET** /courses | 
[**GetDistrict**](DataApi.md#getdistrict) | **GET** /districts/{id} | 
[**GetDistrictAdmin**](DataApi.md#getdistrictadmin) | **GET** /district_admins/{id} | 
[**GetDistrictAdmins**](DataApi.md#getdistrictadmins) | **GET** /district_admins | 
[**GetDistrictForContact**](DataApi.md#getdistrictforcontact) | **GET** /contacts/{id}/district | 
[**GetDistrictForCourse**](DataApi.md#getdistrictforcourse) | **GET** /courses/{id}/district | 
[**GetDistrictForDistrictAdmin**](DataApi.md#getdistrictfordistrictadmin) | **GET** /district_admins/{id}/district | 
[**GetDistrictForSchool**](DataApi.md#getdistrictforschool) | **GET** /schools/{id}/district | 
[**GetDistrictForSchoolAdmin**](DataApi.md#getdistrictforschooladmin) | **GET** /school_admins/{id}/district | 
[**GetDistrictForSection**](DataApi.md#getdistrictforsection) | **GET** /sections/{id}/district | 
[**GetDistrictForStudent**](DataApi.md#getdistrictforstudent) | **GET** /students/{id}/district | 
[**GetDistrictForTeacher**](DataApi.md#getdistrictforteacher) | **GET** /teachers/{id}/district | 
[**GetDistrictForTerm**](DataApi.md#getdistrictforterm) | **GET** /terms/{id}/district | 
[**GetDistricts**](DataApi.md#getdistricts) | **GET** /districts | 
[**GetSchool**](DataApi.md#getschool) | **GET** /schools/{id} | 
[**GetSchoolAdmin**](DataApi.md#getschooladmin) | **GET** /school_admins/{id} | 
[**GetSchoolAdmins**](DataApi.md#getschooladmins) | **GET** /school_admins | 
[**GetSchoolForSection**](DataApi.md#getschoolforsection) | **GET** /sections/{id}/school | 
[**GetSchoolForStudent**](DataApi.md#getschoolforstudent) | **GET** /students/{id}/school | 
[**GetSchoolForTeacher**](DataApi.md#getschoolforteacher) | **GET** /teachers/{id}/school | 
[**GetSchools**](DataApi.md#getschools) | **GET** /schools | 
[**GetSchoolsForSchoolAdmin**](DataApi.md#getschoolsforschooladmin) | **GET** /school_admins/{id}/schools | 
[**GetSchoolsForStudent**](DataApi.md#getschoolsforstudent) | **GET** /students/{id}/schools | 
[**GetSchoolsForTeacher**](DataApi.md#getschoolsforteacher) | **GET** /teachers/{id}/schools | 
[**GetSection**](DataApi.md#getsection) | **GET** /sections/{id} | 
[**GetSections**](DataApi.md#getsections) | **GET** /sections | 
[**GetSectionsForCourse**](DataApi.md#getsectionsforcourse) | **GET** /courses/{id}/sections | 
[**GetSectionsForSchool**](DataApi.md#getsectionsforschool) | **GET** /schools/{id}/sections | 
[**GetSectionsForStudent**](DataApi.md#getsectionsforstudent) | **GET** /students/{id}/sections | 
[**GetSectionsForTeacher**](DataApi.md#getsectionsforteacher) | **GET** /teachers/{id}/sections | 
[**GetSectionsForTerm**](DataApi.md#getsectionsforterm) | **GET** /terms/{id}/sections | 
[**GetStudent**](DataApi.md#getstudent) | **GET** /students/{id} | 
[**GetStudents**](DataApi.md#getstudents) | **GET** /students | 
[**GetStudentsForContact**](DataApi.md#getstudentsforcontact) | **GET** /contacts/{id}/students | 
[**GetStudentsForSchool**](DataApi.md#getstudentsforschool) | **GET** /schools/{id}/students | 
[**GetStudentsForSection**](DataApi.md#getstudentsforsection) | **GET** /sections/{id}/students | 
[**GetStudentsForTeacher**](DataApi.md#getstudentsforteacher) | **GET** /teachers/{id}/students | 
[**GetTeacher**](DataApi.md#getteacher) | **GET** /teachers/{id} | 
[**GetTeacherForSection**](DataApi.md#getteacherforsection) | **GET** /sections/{id}/teacher | 
[**GetTeachers**](DataApi.md#getteachers) | **GET** /teachers | 
[**GetTeachersForSchool**](DataApi.md#getteachersforschool) | **GET** /schools/{id}/teachers | 
[**GetTeachersForSection**](DataApi.md#getteachersforsection) | **GET** /sections/{id}/teachers | 
[**GetTeachersForStudent**](DataApi.md#getteachersforstudent) | **GET** /students/{id}/teachers | 
[**GetTerm**](DataApi.md#getterm) | **GET** /terms/{id} | 
[**GetTermForSection**](DataApi.md#gettermforsection) | **GET** /sections/{id}/term | 
[**GetTerms**](DataApi.md#getterms) | **GET** /terms | 


<a name="getcontact"></a>
# **GetContact**
> ContactResponse GetContact (string id)



Returns a specific student contact

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                ContactResponse result = apiInstance.GetContact(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetContact: " + e.Message );
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

[**ContactResponse**](ContactResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontacts"></a>
# **GetContacts**
> ContactsResponse GetContacts (int? limit = null, string startingAfter = null, string endingBefore = null)



Returns a list of student contacts

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                ContactsResponse result = apiInstance.GetContacts(limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetContacts: " + e.Message );
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

### Return type

[**ContactsResponse**](ContactsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactsforstudent"></a>
# **GetContactsForStudent**
> ContactsResponse GetContactsForStudent (string id, int? limit = null)



Returns the contacts for a student

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetContactsForStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                ContactsResponse result = apiInstance.GetContactsForStudent(id, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetContactsForStudent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 

### Return type

[**ContactsResponse**](ContactsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourse"></a>
# **GetCourse**
> CourseResponse GetCourse (string id)



Returns a specific course

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetCourseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                CourseResponse result = apiInstance.GetCourse(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetCourse: " + e.Message );
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

[**CourseResponse**](CourseResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourseforsection"></a>
# **GetCourseForSection**
> CourseResponse GetCourseForSection (string id)



Returns the course for a section

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetCourseForSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                CourseResponse result = apiInstance.GetCourseForSection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetCourseForSection: " + e.Message );
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

[**CourseResponse**](CourseResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourses"></a>
# **GetCourses**
> CoursesResponse GetCourses (int? limit = null, string startingAfter = null, string endingBefore = null)



Returns a list of courses

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetCoursesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                CoursesResponse result = apiInstance.GetCourses(limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetCourses: " + e.Message );
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

### Return type

[**CoursesResponse**](CoursesResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrict"></a>
# **GetDistrict**
> DistrictResponse GetDistrict (string id)



Returns a specific district

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrict(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrict: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictadmin"></a>
# **GetDistrictAdmin**
> DistrictAdminResponse GetDistrictAdmin (string id)



Returns a specific district admin

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictAdminExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictAdminResponse result = apiInstance.GetDistrictAdmin(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictAdmin: " + e.Message );
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

[**DistrictAdminResponse**](DistrictAdminResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictadmins"></a>
# **GetDistrictAdmins**
> DistrictAdminsResponse GetDistrictAdmins (string startingAfter = null, string endingBefore = null)



Returns a list of district admins

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictAdminsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                DistrictAdminsResponse result = apiInstance.GetDistrictAdmins(startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictAdmins: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**DistrictAdminsResponse**](DistrictAdminsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictforcontact"></a>
# **GetDistrictForContact**
> DistrictResponse GetDistrictForContact (string id)



Returns the district for a student contact

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForContact(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForContact: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictforcourse"></a>
# **GetDistrictForCourse**
> DistrictResponse GetDistrictForCourse (string id)



Returns the district for a course

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForCourseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForCourse(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForCourse: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictfordistrictadmin"></a>
# **GetDistrictForDistrictAdmin**
> DistrictResponse GetDistrictForDistrictAdmin (string id)



Returns the district for a district admin

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForDistrictAdminExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForDistrictAdmin(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForDistrictAdmin: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictforschool"></a>
# **GetDistrictForSchool**
> DistrictResponse GetDistrictForSchool (string id)



Returns the district for a school

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForSchoolExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForSchool(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForSchool: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictforschooladmin"></a>
# **GetDistrictForSchoolAdmin**
> DistrictResponse GetDistrictForSchoolAdmin (string id)



Returns the district for a school admin

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForSchoolAdminExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForSchoolAdmin(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForSchoolAdmin: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictforsection"></a>
# **GetDistrictForSection**
> DistrictResponse GetDistrictForSection (string id)



Returns the district for a section

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForSection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForSection: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictforstudent"></a>
# **GetDistrictForStudent**
> DistrictResponse GetDistrictForStudent (string id)



Returns the district for a student

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForStudent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForStudent: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictforteacher"></a>
# **GetDistrictForTeacher**
> DistrictResponse GetDistrictForTeacher (string id)



Returns the district for a teacher

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForTeacherExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForTeacher(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForTeacher: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistrictforterm"></a>
# **GetDistrictForTerm**
> DistrictResponse GetDistrictForTerm (string id)



Returns the district for a term

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictForTermExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                DistrictResponse result = apiInstance.GetDistrictForTerm(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistrictForTerm: " + e.Message );
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

[**DistrictResponse**](DistrictResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistricts"></a>
# **GetDistricts**
> DistrictsResponse GetDistricts ()



Returns a list of districts

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetDistrictsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();

            try
            {
                DistrictsResponse result = apiInstance.GetDistricts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDistricts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DistrictsResponse**](DistrictsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschool"></a>
# **GetSchool**
> SchoolResponse GetSchool (string id)



Returns a specific school

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                SchoolResponse result = apiInstance.GetSchool(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchool: " + e.Message );
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

[**SchoolResponse**](SchoolResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschooladmin"></a>
# **GetSchoolAdmin**
> SchoolAdminResponse GetSchoolAdmin (string id)



Returns a specific school admin

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolAdminExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                SchoolAdminResponse result = apiInstance.GetSchoolAdmin(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchoolAdmin: " + e.Message );
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

[**SchoolAdminResponse**](SchoolAdminResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschooladmins"></a>
# **GetSchoolAdmins**
> SchoolAdminsResponse GetSchoolAdmins (int? limit = null, string startingAfter = null, string endingBefore = null)



Returns a list of school admins

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolAdminsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SchoolAdminsResponse result = apiInstance.GetSchoolAdmins(limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchoolAdmins: " + e.Message );
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

### Return type

[**SchoolAdminsResponse**](SchoolAdminsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolforsection"></a>
# **GetSchoolForSection**
> SchoolResponse GetSchoolForSection (string id)



Returns the school for a section

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolForSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                SchoolResponse result = apiInstance.GetSchoolForSection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchoolForSection: " + e.Message );
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

[**SchoolResponse**](SchoolResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolforstudent"></a>
# **GetSchoolForStudent**
> SchoolResponse GetSchoolForStudent (string id)



Returns the primary school for a student

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolForStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                SchoolResponse result = apiInstance.GetSchoolForStudent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchoolForStudent: " + e.Message );
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

[**SchoolResponse**](SchoolResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolforteacher"></a>
# **GetSchoolForTeacher**
> SchoolResponse GetSchoolForTeacher (string id)



Retrieves school info for a teacher.

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolForTeacherExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                SchoolResponse result = apiInstance.GetSchoolForTeacher(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchoolForTeacher: " + e.Message );
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

[**SchoolResponse**](SchoolResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschools"></a>
# **GetSchools**
> SchoolsResponse GetSchools (int? limit = null, string startingAfter = null, string endingBefore = null)



Returns a list of schools

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SchoolsResponse result = apiInstance.GetSchools(limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchools: " + e.Message );
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

### Return type

[**SchoolsResponse**](SchoolsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolsforschooladmin"></a>
# **GetSchoolsForSchoolAdmin**
> SchoolsResponse GetSchoolsForSchoolAdmin (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the schools for a school admin

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolsForSchoolAdminExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SchoolsResponse result = apiInstance.GetSchoolsForSchoolAdmin(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchoolsForSchoolAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**SchoolsResponse**](SchoolsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolsforstudent"></a>
# **GetSchoolsForStudent**
> SchoolsResponse GetSchoolsForStudent (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the schools for a student

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolsForStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SchoolsResponse result = apiInstance.GetSchoolsForStudent(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchoolsForStudent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**SchoolsResponse**](SchoolsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolsforteacher"></a>
# **GetSchoolsForTeacher**
> SchoolsResponse GetSchoolsForTeacher (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the schools for a teacher

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSchoolsForTeacherExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SchoolsResponse result = apiInstance.GetSchoolsForTeacher(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSchoolsForTeacher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**SchoolsResponse**](SchoolsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsection"></a>
# **GetSection**
> SectionResponse GetSection (string id)



Returns a specific section

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                SectionResponse result = apiInstance.GetSection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSection: " + e.Message );
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

[**SectionResponse**](SectionResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsections"></a>
# **GetSections**
> SectionsResponse GetSections (int? limit = null, string startingAfter = null, string endingBefore = null)



Returns a list of sections

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSectionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SectionsResponse result = apiInstance.GetSections(limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSections: " + e.Message );
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

### Return type

[**SectionsResponse**](SectionsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionsforcourse"></a>
# **GetSectionsForCourse**
> SectionsResponse GetSectionsForCourse (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the sections for a Courses

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSectionsForCourseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SectionsResponse result = apiInstance.GetSectionsForCourse(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSectionsForCourse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**SectionsResponse**](SectionsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionsforschool"></a>
# **GetSectionsForSchool**
> SectionsResponse GetSectionsForSchool (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the sections for a school

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSectionsForSchoolExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SectionsResponse result = apiInstance.GetSectionsForSchool(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSectionsForSchool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**SectionsResponse**](SectionsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionsforstudent"></a>
# **GetSectionsForStudent**
> SectionsResponse GetSectionsForStudent (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the sections for a student

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSectionsForStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SectionsResponse result = apiInstance.GetSectionsForStudent(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSectionsForStudent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**SectionsResponse**](SectionsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionsforteacher"></a>
# **GetSectionsForTeacher**
> SectionsResponse GetSectionsForTeacher (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the sections for a teacher

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSectionsForTeacherExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SectionsResponse result = apiInstance.GetSectionsForTeacher(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSectionsForTeacher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**SectionsResponse**](SectionsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionsforterm"></a>
# **GetSectionsForTerm**
> SectionsResponse GetSectionsForTerm (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the sections for a term

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetSectionsForTermExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                SectionsResponse result = apiInstance.GetSectionsForTerm(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSectionsForTerm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**SectionsResponse**](SectionsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudent"></a>
# **GetStudent**
> StudentResponse GetStudent (string id)



Returns a specific student

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                StudentResponse result = apiInstance.GetStudent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetStudent: " + e.Message );
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

[**StudentResponse**](StudentResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudents"></a>
# **GetStudents**
> StudentsResponse GetStudents (int? limit = null, string startingAfter = null, string endingBefore = null)



Returns a list of students

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetStudentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                StudentsResponse result = apiInstance.GetStudents(limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetStudents: " + e.Message );
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

### Return type

[**StudentsResponse**](StudentsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentsforcontact"></a>
# **GetStudentsForContact**
> StudentsResponse GetStudentsForContact (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the students for a student contact

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetStudentsForContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                StudentsResponse result = apiInstance.GetStudentsForContact(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetStudentsForContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**StudentsResponse**](StudentsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentsforschool"></a>
# **GetStudentsForSchool**
> StudentsResponse GetStudentsForSchool (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the students for a school

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetStudentsForSchoolExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                StudentsResponse result = apiInstance.GetStudentsForSchool(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetStudentsForSchool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**StudentsResponse**](StudentsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentsforsection"></a>
# **GetStudentsForSection**
> StudentsResponse GetStudentsForSection (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the students for a section

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetStudentsForSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                StudentsResponse result = apiInstance.GetStudentsForSection(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetStudentsForSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**StudentsResponse**](StudentsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentsforteacher"></a>
# **GetStudentsForTeacher**
> StudentsResponse GetStudentsForTeacher (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the students for a teacher

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetStudentsForTeacherExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                StudentsResponse result = apiInstance.GetStudentsForTeacher(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetStudentsForTeacher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**StudentsResponse**](StudentsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteacher"></a>
# **GetTeacher**
> TeacherResponse GetTeacher (string id)



Returns a specific teacher

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTeacherExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                TeacherResponse result = apiInstance.GetTeacher(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTeacher: " + e.Message );
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

[**TeacherResponse**](TeacherResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteacherforsection"></a>
# **GetTeacherForSection**
> TeacherResponse GetTeacherForSection (string id)



Returns the primary teacher for a section

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTeacherForSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                TeacherResponse result = apiInstance.GetTeacherForSection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTeacherForSection: " + e.Message );
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

[**TeacherResponse**](TeacherResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachers"></a>
# **GetTeachers**
> TeachersResponse GetTeachers (int? limit = null, string startingAfter = null, string endingBefore = null)



Returns a list of teachers

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTeachersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                TeachersResponse result = apiInstance.GetTeachers(limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTeachers: " + e.Message );
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

### Return type

[**TeachersResponse**](TeachersResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachersforschool"></a>
# **GetTeachersForSchool**
> TeachersResponse GetTeachersForSchool (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the teachers for a school

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTeachersForSchoolExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                TeachersResponse result = apiInstance.GetTeachersForSchool(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTeachersForSchool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**TeachersResponse**](TeachersResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachersforsection"></a>
# **GetTeachersForSection**
> TeachersResponse GetTeachersForSection (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the teachers for a section

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTeachersForSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                TeachersResponse result = apiInstance.GetTeachersForSection(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTeachersForSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**TeachersResponse**](TeachersResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachersforstudent"></a>
# **GetTeachersForStudent**
> TeachersResponse GetTeachersForStudent (string id, int? limit = null, string startingAfter = null, string endingBefore = null)



Returns the teachers for a student

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTeachersForStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                TeachersResponse result = apiInstance.GetTeachersForStudent(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTeachersForStudent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **startingAfter** | **string**|  | [optional] 
 **endingBefore** | **string**|  | [optional] 

### Return type

[**TeachersResponse**](TeachersResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getterm"></a>
# **GetTerm**
> TermResponse GetTerm (string id)



Returns a specific term

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTermExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                TermResponse result = apiInstance.GetTerm(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTerm: " + e.Message );
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

[**TermResponse**](TermResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettermforsection"></a>
# **GetTermForSection**
> TermResponse GetTermForSection (string id)



Returns the term for a section

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTermForSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 

            try
            {
                TermResponse result = apiInstance.GetTermForSection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTermForSection: " + e.Message );
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

[**TermResponse**](TermResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getterms"></a>
# **GetTerms**
> TermsResponse GetTerms (int? limit = null, string startingAfter = null, string endingBefore = null)



Returns a list of terms

### Example
```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class GetTermsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                TermsResponse result = apiInstance.GetTerms(limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTerms: " + e.Message );
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

### Return type

[**TermsResponse**](TermsResponse.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

