# Clever - the C# library for the Clever API

The Clever API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.2.0
- SDK version: 1.2.0
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

All URIs are relative to *https://api.clever.com/v1.2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataApi* | [**GetContact**](docs/DataApi.md#getcontact) | **GET** /contacts/{id} |
*DataApi* | [**GetContacts**](docs/DataApi.md#getcontacts) | **GET** /contacts |
*DataApi* | [**GetContactsForStudent**](docs/DataApi.md#getcontactsforstudent) | **GET** /students/{id}/contacts |
*DataApi* | [**GetDistrict**](docs/DataApi.md#getdistrict) | **GET** /districts/{id} |
*DataApi* | [**GetDistrictAdmin**](docs/DataApi.md#getdistrictadmin) | **GET** /district_admins/{id} |
*DataApi* | [**GetDistrictAdmins**](docs/DataApi.md#getdistrictadmins) | **GET** /district_admins |
*DataApi* | [**GetDistrictForSchool**](docs/DataApi.md#getdistrictforschool) | **GET** /schools/{id}/district |
*DataApi* | [**GetDistrictForSection**](docs/DataApi.md#getdistrictforsection) | **GET** /sections/{id}/district |
*DataApi* | [**GetDistrictForStudent**](docs/DataApi.md#getdistrictforstudent) | **GET** /students/{id}/district |
*DataApi* | [**GetDistrictForStudentContact**](docs/DataApi.md#getdistrictforstudentcontact) | **GET** /contacts/{id}/district |
*DataApi* | [**GetDistrictForTeacher**](docs/DataApi.md#getdistrictforteacher) | **GET** /teachers/{id}/district |
*DataApi* | [**GetDistrictStatus**](docs/DataApi.md#getdistrictstatus) | **GET** /districts/{id}/status |
*DataApi* | [**GetDistricts**](docs/DataApi.md#getdistricts) | **GET** /districts |
*DataApi* | [**GetGradeLevelsForTeacher**](docs/DataApi.md#getgradelevelsforteacher) | **GET** /teachers/{id}/grade_levels |
*DataApi* | [**GetSchool**](docs/DataApi.md#getschool) | **GET** /schools/{id} |
*DataApi* | [**GetSchoolAdmin**](docs/DataApi.md#getschooladmin) | **GET** /school_admins/{id} |
*DataApi* | [**GetSchoolAdmins**](docs/DataApi.md#getschooladmins) | **GET** /school_admins |
*DataApi* | [**GetSchoolForSection**](docs/DataApi.md#getschoolforsection) | **GET** /sections/{id}/school |
*DataApi* | [**GetSchoolForStudent**](docs/DataApi.md#getschoolforstudent) | **GET** /students/{id}/school |
*DataApi* | [**GetSchoolForTeacher**](docs/DataApi.md#getschoolforteacher) | **GET** /teachers/{id}/school |
*DataApi* | [**GetSchools**](docs/DataApi.md#getschools) | **GET** /schools |
*DataApi* | [**GetSchoolsForSchoolAdmin**](docs/DataApi.md#getschoolsforschooladmin) | **GET** /school_admins/{id}/schools |
*DataApi* | [**GetSection**](docs/DataApi.md#getsection) | **GET** /sections/{id} |
*DataApi* | [**GetSections**](docs/DataApi.md#getsections) | **GET** /sections |
*DataApi* | [**GetSectionsForSchool**](docs/DataApi.md#getsectionsforschool) | **GET** /schools/{id}/sections |
*DataApi* | [**GetSectionsForStudent**](docs/DataApi.md#getsectionsforstudent) | **GET** /students/{id}/sections |
*DataApi* | [**GetSectionsForTeacher**](docs/DataApi.md#getsectionsforteacher) | **GET** /teachers/{id}/sections |
*DataApi* | [**GetStudent**](docs/DataApi.md#getstudent) | **GET** /students/{id} |
*DataApi* | [**GetStudentForContact**](docs/DataApi.md#getstudentforcontact) | **GET** /contacts/{id}/student |
*DataApi* | [**GetStudents**](docs/DataApi.md#getstudents) | **GET** /students |
*DataApi* | [**GetStudentsForSchool**](docs/DataApi.md#getstudentsforschool) | **GET** /schools/{id}/students |
*DataApi* | [**GetStudentsForSection**](docs/DataApi.md#getstudentsforsection) | **GET** /sections/{id}/students |
*DataApi* | [**GetStudentsForTeacher**](docs/DataApi.md#getstudentsforteacher) | **GET** /teachers/{id}/students |
*DataApi* | [**GetTeacher**](docs/DataApi.md#getteacher) | **GET** /teachers/{id} |
*DataApi* | [**GetTeacherForSection**](docs/DataApi.md#getteacherforsection) | **GET** /sections/{id}/teacher |
*DataApi* | [**GetTeachers**](docs/DataApi.md#getteachers) | **GET** /teachers |
*DataApi* | [**GetTeachersForSchool**](docs/DataApi.md#getteachersforschool) | **GET** /schools/{id}/teachers |
*DataApi* | [**GetTeachersForSection**](docs/DataApi.md#getteachersforsection) | **GET** /sections/{id}/teachers |
*DataApi* | [**GetTeachersForStudent**](docs/DataApi.md#getteachersforstudent) | **GET** /students/{id}/teachers |
*EventsApi* | [**GetEvent**](docs/EventsApi.md#getevent) | **GET** /events/{id} |
*EventsApi* | [**GetEvents**](docs/EventsApi.md#getevents) | **GET** /events |
*EventsApi* | [**GetEventsForSchool**](docs/EventsApi.md#geteventsforschool) | **GET** /schools/{id}/events |
*EventsApi* | [**GetEventsForSchoolAdmin**](docs/EventsApi.md#geteventsforschooladmin) | **GET** /school_admins/{id}/events |
*EventsApi* | [**GetEventsForSection**](docs/EventsApi.md#geteventsforsection) | **GET** /sections/{id}/events |
*EventsApi* | [**GetEventsForStudent**](docs/EventsApi.md#geteventsforstudent) | **GET** /students/{id}/events |
*EventsApi* | [**GetEventsForTeacher**](docs/EventsApi.md#geteventsforteacher) | **GET** /teachers/{id}/events |


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BadRequest](docs/BadRequest.md)
 - [Model.Credentials](docs/Credentials.md)
 - [Model.District](docs/District.md)
 - [Model.DistrictAdmin](docs/DistrictAdmin.md)
 - [Model.DistrictAdminResponse](docs/DistrictAdminResponse.md)
 - [Model.DistrictAdminsResponse](docs/DistrictAdminsResponse.md)
 - [Model.DistrictObject](docs/DistrictObject.md)
 - [Model.DistrictResponse](docs/DistrictResponse.md)
 - [Model.DistrictStatus](docs/DistrictStatus.md)
 - [Model.DistrictStatusResponse](docs/DistrictStatusResponse.md)
 - [Model.DistrictStatusResponses](docs/DistrictStatusResponses.md)
 - [Model.DistrictsResponse](docs/DistrictsResponse.md)
 - [Model.EventResponse](docs/EventResponse.md)
 - [Model.EventsResponse](docs/EventsResponse.md)
 - [Model.GradeLevelsResponse](docs/GradeLevelsResponse.md)
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
 - [Model.StudentContact](docs/StudentContact.md)
 - [Model.StudentContactObject](docs/StudentContactObject.md)
 - [Model.StudentContactResponse](docs/StudentContactResponse.md)
 - [Model.StudentContactsForStudentResponse](docs/StudentContactsForStudentResponse.md)
 - [Model.StudentContactsResponse](docs/StudentContactsResponse.md)
 - [Model.StudentObject](docs/StudentObject.md)
 - [Model.StudentResponse](docs/StudentResponse.md)
 - [Model.StudentsResponse](docs/StudentsResponse.md)
 - [Model.Teacher](docs/Teacher.md)
 - [Model.TeacherObject](docs/TeacherObject.md)
 - [Model.TeacherResponse](docs/TeacherResponse.md)
 - [Model.TeachersResponse](docs/TeachersResponse.md)
 - [Model.Term](docs/Term.md)
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
 - [Model.StudentcontactsCreated](docs/StudentcontactsCreated.md)
 - [Model.StudentcontactsDeleted](docs/StudentcontactsDeleted.md)
 - [Model.StudentcontactsUpdated](docs/StudentcontactsUpdated.md)
 - [Model.StudentsCreated](docs/StudentsCreated.md)
 - [Model.StudentsDeleted](docs/StudentsDeleted.md)
 - [Model.StudentsUpdated](docs/StudentsUpdated.md)
 - [Model.TeachersCreated](docs/TeachersCreated.md)
 - [Model.TeachersDeleted](docs/TeachersDeleted.md)
 - [Model.TeachersUpdated](docs/TeachersUpdated.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth"></a>
### oauth

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://clever.com/oauth/authorize
- **Scopes**: N/A