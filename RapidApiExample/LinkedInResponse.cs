public class LinkedInResponse
{
    public int id { get; set; }
    public string urn { get; set; }
    public string username { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public bool isTopVoice { get; set; }
    public bool isCreator { get; set; }
    public string profilePicture { get; set; }
    public Backgroundimage[] backgroundImage { get; set; }
    public string summary { get; set; }
    public string headline { get; set; }
    public Geo geo { get; set; }
    public Education[] educations { get; set; }
    public Position[] position { get; set; }
    public Fullposition[] fullPositions { get; set; }
    public Skill[] skills { get; set; }
    public Projects projects { get; set; }
    public Supportedlocale[] supportedLocales { get; set; }
    public Multilocalefirstname multiLocaleFirstName { get; set; }
    public Multilocalelastname multiLocaleLastName { get; set; }
    public Multilocaleheadline multiLocaleHeadline { get; set; }
}

public class Geo
{
    public string country { get; set; }
    public string city { get; set; }
    public string full { get; set; }
    public string countryCode { get; set; }
}

public class Projects
{
}

public class Multilocalefirstname
{
    public string en { get; set; }
}

public class Multilocalelastname
{
    public string en { get; set; }
}

public class Multilocaleheadline
{
    public string en { get; set; }
}

public class Backgroundimage
{
    public int width { get; set; }
    public int height { get; set; }
    public string url { get; set; }
}

public class Education
{
    public Start start { get; set; }
    public End end { get; set; }
    public string fieldOfStudy { get; set; }
    public string degree { get; set; }
    public string grade { get; set; }
    public string schoolName { get; set; }
    public string description { get; set; }
    public string activities { get; set; }
    public string url { get; set; }
    public string schoolId { get; set; }
    public Logo[] logo { get; set; }
}

public class Start
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class End
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class Logo
{
    public string url { get; set; }
    public int width { get; set; }
    public int height { get; set; }
}

public class Position
{
    public int companyId { get; set; }
    public string companyName { get; set; }
    public string companyUsername { get; set; }
    public string companyURL { get; set; }
    public string companyLogo { get; set; }
    public string companyIndustry { get; set; }
    public string companyStaffCountRange { get; set; }
    public string title { get; set; }
    public Multilocaletitle multiLocaleTitle { get; set; }
    public Multilocalecompanyname multiLocaleCompanyName { get; set; }
    public string location { get; set; }
    public string description { get; set; }
    public string employmentType { get; set; }
    public Start1 start { get; set; }
    public End1 end { get; set; }
}

public class Multilocaletitle
{
    public string en_US { get; set; }
}

public class Multilocalecompanyname
{
    public string en_US { get; set; }
}

public class Start1
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class End1
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class Fullposition
{
    public int companyId { get; set; }
    public string companyName { get; set; }
    public string companyUsername { get; set; }
    public string companyURL { get; set; }
    public string companyLogo { get; set; }
    public string companyIndustry { get; set; }
    public string companyStaffCountRange { get; set; }
    public string title { get; set; }
    public Multilocaletitle1 multiLocaleTitle { get; set; }
    public Multilocalecompanyname1 multiLocaleCompanyName { get; set; }
    public string location { get; set; }
    public string description { get; set; }
    public string employmentType { get; set; }
    public Start2 start { get; set; }
    public End2 end { get; set; }
}

public class Multilocaletitle1
{
    public string en_US { get; set; }
}

public class Multilocalecompanyname1
{
    public string en_US { get; set; }
}

public class Start2
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class End2
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class Skill
{
    public string name { get; set; }
    public bool passedSkillAssessment { get; set; }
    public int endorsementsCount { get; set; }
}

public class Supportedlocale
{
    public string country { get; set; }
    public string language { get; set; }
}
