# Clever - the C# library for the Clever API

The Clever API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.0
- SDK version: 2.0.2
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Clever.Api;
using Clever.Client;
using Clever.Model;
```
<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.clever.com/v2.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataApi* | [**GetContact**](docs/DataApi.md#getcontact) | **GET** /contacts/{id} | 
*DataApi* | [**GetContacts**](docs/DataApi.md#getcontacts) | **GET** /contacts | 
*DataApi* | [**GetContactsForStudent**](docs/DataApi.md#getcontactsforstudent) | **GET** /students/{id}/contacts | 
*DataApi* | [**GetCourse**](docs/DataApi.md#getcourse) | **GET** /courses/{id} | 
*DataApi* | [**GetCourseForSection**](docs/DataApi.md#getcourseforsection) | **GET** /sections/{id}/course | 
*DataApi* | [**GetCourses**](docs/DataApi.md#getcourses) | **GET** /courses | 
*DataApi* | [**GetDistrict**](docs/DataApi.md#getdistrict) | **GET** /districts/{id} | 
*DataApi* | [**GetDistrictAdmin**](docs/DataApi.md#getdistrictadmin) | **GET** /district_admins/{id} | 
*DataApi* | [**GetDistrictAdmins**](docs/DataApi.md#getdistrictadmins) | **GET** /district_admins | 
*DataApi* | [**GetDistrictForContact**](docs/DataApi.md#getdistrictforcontact) | **GET** /contacts/{id}/district | 
*DataApi* | [**GetDistrictForCourse**](docs/DataApi.md#getdistrictforcourse) | **GET** /courses/{id}/district | 
*DataApi* | [**GetDistrictForDistrictAdmin**](docs/DataApi.md#getdistrictfordistrictadmin) | **GET** /district_admins/{id}/district | 
*DataApi* | [**GetDistrictForSchool**](docs/DataApi.md#getdistrictforschool) | **GET** /schools/{id}/district | 
*DataApi* | [**GetDistrictForSchoolAdmin**](docs/DataApi.md#getdistrictforschooladmin) | **GET** /school_admins/{id}/district | 
*DataApi* | [**GetDistrictForSection**](docs/DataApi.md#getdistrictforsection) | **GET** /sections/{id}/district | 
*DataApi* | [**GetDistrictForStudent**](docs/DataApi.md#getdistrictforstudent) | **GET** /students/{id}/district | 
*DataApi* | [**GetDistrictForTeacher**](docs/DataApi.md#getdistrictforteacher) | **GET** /teachers/{id}/district | 
*DataApi* | [**GetDistrictForTerm**](docs/DataApi.md#getdistrictforterm) | **GET** /terms/{id}/district | 
*DataApi* | [**GetDistricts**](docs/DataApi.md#getdistricts) | **GET** /districts | 
*DataApi* | [**GetSchool**](docs/DataApi.md#getschool) | **GET** /schools/{id} | 
*DataApi* | [**GetSchoolAdmin**](docs/DataApi.md#getschooladmin) | **GET** /school_admins/{id} | 
*DataApi* | [**GetSchoolAdmins**](docs/DataApi.md#getschooladmins) | **GET** /school_admins | 
*DataApi* | [**GetSchoolForSection**](docs/DataApi.md#getschoolforsection) | **GET** /sections/{id}/school | 
*DataApi* | [**GetSchoolForStudent**](docs/DataApi.md#getschoolforstudent) | **GET** /students/{id}/school | 
*DataApi* | [**GetSchoolForTeacher**](docs/DataApi.md#getschoolforteacher) | **GET** /teachers/{id}/school | 
*DataApi* | [**GetSchools**](docs/DataApi.md#getschools) | **GET** /schools | 
*DataApi* | [**GetSchoolsForSchoolAdmin**](docs/DataApi.md#getschoolsforschooladmin) | **GET** /school_admins/{id}/schools | 
*DataApi* | [**GetSchoolsForStudent**](docs/DataApi.md#getschoolsforstudent) | **GET** /students/{id}/schools | 
*DataApi* | [**GetSchoolsForTeacher**](docs/DataApi.md#getschoolsforteacher) | **GET** /teachers/{id}/schools | 
*DataApi* | [**GetSection**](docs/DataApi.md#getsection) | **GET** /sections/{id} | 
*DataApi* | [**GetSections**](docs/DataApi.md#getsections) | **GET** /sections | 
*DataApi* | [**GetSectionsForCourse**](docs/DataApi.md#getsectionsforcourse) | **GET** /courses/{id}/sections | 
*DataApi* | [**GetSectionsForSchool**](docs/DataApi.md#getsectionsforschool) | **GET** /schools/{id}/sections | 
*DataApi* | [**GetSectionsForStudent**](docs/DataApi.md#getsectionsforstudent) | **GET** /students/{id}/sections | 
*DataApi* | [**GetSectionsForTeacher**](docs/DataApi.md#getsectionsforteacher) | **GET** /teachers/{id}/sections | 
*DataApi* | [**GetSectionsForTerm**](docs/DataApi.md#getsectionsforterm) | **GET** /terms/{id}/sections | 
*DataApi* | [**GetStudent**](docs/DataApi.md#getstudent) | **GET** /students/{id} | 
*DataApi* | [**GetStudents**](docs/DataApi.md#getstudents) | **GET** /students | 
*DataApi* | [**GetStudentsForContact**](docs/DataApi.md#getstudentsforcontact) | **GET** /contacts/{id}/students | 
*DataApi* | [**GetStudentsForSchool**](docs/DataApi.md#getstudentsforschool) | **GET** /schools/{id}/students | 
*DataApi* | [**GetStudentsForSection**](docs/DataApi.md#getstudentsforsection) | **GET** /sections/{id}/students | 
*DataApi* | [**GetStudentsForTeacher**](docs/DataApi.md#getstudentsforteacher) | **GET** /teachers/{id}/students | 
*DataApi* | [**GetTeacher**](docs/DataApi.md#getteacher) | **GET** /teachers/{id} | 
*DataApi* | [**GetTeacherForSection**](docs/DataApi.md#getteacherforsection) | **GET** /sections/{id}/teacher | 
*DataApi* | [**GetTeachers**](docs/DataApi.md#getteachers) | **GET** /teachers | 
*DataApi* | [**GetTeachersForSchool**](docs/DataApi.md#getteachersforschool) | **GET** /schools/{id}/teachers | 
*DataApi* | [**GetTeachersForSection**](docs/DataApi.md#getteachersforsection) | **GET** /sections/{id}/teachers | 
*DataApi* | [**GetTeachersForStudent**](docs/DataApi.md#getteachersforstudent) | **GET** /students/{id}/teachers | 
*DataApi* | [**GetTerm**](docs/DataApi.md#getterm) | **GET** /terms/{id} | 
*DataApi* | [**GetTermForSection**](docs/DataApi.md#gettermforsection) | **GET** /sections/{id}/term | 
*DataApi* | [**GetTerms**](docs/DataApi.md#getterms) | **GET** /terms | 
*EventsApi* | [**GetEvent**](docs/EventsApi.md#getevent) | **GET** /events/{id} | 
*EventsApi* | [**GetEvents**](docs/EventsApi.md#getevents) | **GET** /events | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BadRequest](docs/BadRequest.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContactObject](docs/ContactObject.md)
 - [Model.ContactResponse](docs/ContactResponse.md)
 - [Model.ContactsResponse](docs/ContactsResponse.md)
 - [Model.Course](docs/Course.md)
 - [Model.CourseObject](docs/CourseObject.md)
 - [Model.CourseResponse](docs/CourseResponse.md)
 - [Model.CoursesResponse](docs/CoursesResponse.md)
 - [Model.Credentials](docs/Credentials.md)
 - [Model.District](docs/District.md)
 - [Model.DistrictAdmin](docs/DistrictAdmin.md)
 - [Model.DistrictAdminObject](docs/DistrictAdminObject.md)
 - [Model.DistrictAdminResponse](docs/DistrictAdminResponse.md)
 - [Model.DistrictAdminsResponse](docs/DistrictAdminsResponse.md)
 - [Model.DistrictObject](docs/DistrictObject.md)
 - [Model.DistrictResponse](docs/DistrictResponse.md)
 - [Model.DistrictsResponse](docs/DistrictsResponse.md)
 - [Model.EventResponse](docs/EventResponse.md)
 - [Model.EventsResponse](docs/EventsResponse.md)
 - [Model.InternalError](docs/InternalError.md)
 - [Model.Location](docs/Location.md)
 - [Model.ModelEvent](docs/ModelEvent.md)
 - [Model.Name](docs/Name.md)
 - [Model.NotFound](docs/NotFound.md)
 - [Model.Principal](docs/Principal.md)
 - [Model.School](docs/School.md)
 - [Model.SchoolAdmin](docs/SchoolAdmin.md)
 - [Model.SchoolAdminObject](docs/SchoolAdminObject.md)
 - [Model.SchoolAdminResponse](docs/SchoolAdminResponse.md)
 - [Model.SchoolAdminsResponse](docs/SchoolAdminsResponse.md)
 - [Model.SchoolObject](docs/SchoolObject.md)
 - [Model.SchoolResponse](docs/SchoolResponse.md)
 - [Model.SchoolsResponse](docs/SchoolsResponse.md)
 - [Model.Section](docs/Section.md)
 - [Model.SectionObject](docs/SectionObject.md)
 - [Model.SectionResponse](docs/SectionResponse.md)
 - [Model.SectionsResponse](docs/SectionsResponse.md)
 - [Model.Student](docs/Student.md)
 - [Model.StudentObject](docs/StudentObject.md)
 - [Model.StudentResponse](docs/StudentResponse.md)
 - [Model.StudentsResponse](docs/StudentsResponse.md)
 - [Model.Teacher](docs/Teacher.md)
 - [Model.TeacherObject](docs/TeacherObject.md)
 - [Model.TeacherResponse](docs/TeacherResponse.md)
 - [Model.TeachersResponse](docs/TeachersResponse.md)
 - [Model.Term](docs/Term.md)
 - [Model.TermObject](docs/TermObject.md)
 - [Model.TermResponse](docs/TermResponse.md)
 - [Model.TermsResponse](docs/TermsResponse.md)
 - [Model.ContactsCreated](docs/ContactsCreated.md)
 - [Model.ContactsDeleted](docs/ContactsDeleted.md)
 - [Model.ContactsUpdated](docs/ContactsUpdated.md)
 - [Model.CoursesCreated](docs/CoursesCreated.md)
 - [Model.CoursesDeleted](docs/CoursesDeleted.md)
 - [Model.CoursesUpdated](docs/CoursesUpdated.md)
 - [Model.DistrictadminsCreated](docs/DistrictadminsCreated.md)
 - [Model.DistrictadminsDeleted](docs/DistrictadminsDeleted.md)
 - [Model.DistrictadminsUpdated](docs/DistrictadminsUpdated.md)
 - [Model.DistrictsCreated](docs/DistrictsCreated.md)
 - [Model.DistrictsDeleted](docs/DistrictsDeleted.md)
 - [Model.DistrictsUpdated](docs/DistrictsUpdated.md)
 - [Model.SchooladminsCreated](docs/SchooladminsCreated.md)
 - [Model.SchooladminsDeleted](docs/SchooladminsDeleted.md)
 - [Model.SchooladminsUpdated](docs/SchooladminsUpdated.md)
 - [Model.SchoolsCreated](docs/SchoolsCreated.md)
 - [Model.SchoolsDeleted](docs/SchoolsDeleted.md)
 - [Model.SchoolsUpdated](docs/SchoolsUpdated.md)
 - [Model.SectionsCreated](docs/SectionsCreated.md)
 - [Model.SectionsDeleted](docs/SectionsDeleted.md)
 - [Model.SectionsUpdated](docs/SectionsUpdated.md)
 - [Model.StudentsCreated](docs/StudentsCreated.md)
 - [Model.StudentsDeleted](docs/StudentsDeleted.md)
 - [Model.StudentsUpdated](docs/StudentsUpdated.md)
 - [Model.TeachersCreated](docs/TeachersCreated.md)
 - [Model.TeachersDeleted](docs/TeachersDeleted.md)
 - [Model.TeachersUpdated](docs/TeachersUpdated.md)
 - [Model.TermsCreated](docs/TermsCreated.md)
 - [Model.TermsDeleted](docs/TermsDeleted.md)
 - [Model.TermsUpdated](docs/TermsUpdated.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth"></a>
### oauth

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://clever.com/oauth/authorize
- **Scopes**: N/A

