using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Clever.Model;

public class CleverEventJsonConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return typeof(ModelEvent).IsAssignableFrom(objectType);
    }

    public override object ReadJson(JsonReader reader,
        Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject model = JObject.Load(reader);
        switch (model["type"].ToString())
        {
            case "districts.created":
              return model.ToObject<DistrictsCreated>();
            case "districts.deleted":
                return model.ToObject<DistrictsDeleted>();
            case "districts.updated":
                return model.ToObject<DistrictsUpdated>();
            case "schooladmins.created":
              return model.ToObject<SchooladminsCreated>();
            case "schooladmins.deleted":
                return model.ToObject<SchooladminsDeleted>();
            case "schooladmins.updated":
                return model.ToObject<SchooladminsUpdated>();
            case "schools.created":
              return model.ToObject<SchoolsCreated>();
            case "schools.deleted":
                return model.ToObject<SchoolsDeleted>();
            case "schools.updated":
                return model.ToObject<SchoolsUpdated>();
            case "sections.created":
              return model.ToObject<SectionsCreated>();
            case "sections.deleted":
                return model.ToObject<SectionsDeleted>();
            case "sections.updated":
                return model.ToObject<SectionsUpdated>();
            case "contacts.created":
              return model.ToObject<ContactsCreated>();
            case "contacts.deleted":
                return model.ToObject<ContactsDeleted>();
            case "contacts.updated":
                return model.ToObject<ContactsUpdated>();
            case "students.created":
              return model.ToObject<StudentsCreated>();
            case "students.deleted":
              return model.ToObject<StudentsDeleted>();
            case "students.updated":
              return model.ToObject<StudentsUpdated>();
            case "teachers.created":
              return model.ToObject<TeachersCreated>();
            case "teachers.deleted":
              return model.ToObject<TeachersDeleted>();
            case "teachers.updated":
              return model.ToObject<TeachersUpdated>();
            case "terms.created":
              return model.ToObject<TermsCreated>();
            case "terms.deleted":
              return model.ToObject<TermsDeleted>();
            case "terms.updated":
              return model.ToObject<TermsUpdated>();
            case "courses.created":
              return model.ToObject<CoursesCreated>();
            case "courses.deleted":
              return model.ToObject<CoursesDeleted>();
            case "courses.updated":
              return model.ToObject<CoursesUpdated>();
            case "districtadmins.created":
              return model.ToObject<DistrictadminsCreated>();
            case "districtadmins.deleted":
              return model.ToObject<DistrictadminsDeleted>();
            case "districtadmins.updated":
              return model.ToObject<DistrictadminsUpdated>();

            default:
              throw new Exception("Unknown event type "+model["type"].ToString());
        }
    }

    public override void WriteJson(JsonWriter writer,
        object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}
