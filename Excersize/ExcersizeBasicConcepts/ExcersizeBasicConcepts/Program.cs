using ExcersizeBasicConcepts;
List<Person> listOfPersons = new List<Person>();

Person Mike = new Person()
{
    FirstName = "Mike",
    LastName = "Jonson",
    Age = 14,
    State = "NY",
    Email = "MikeJo11@gmail.com",
    Mobile = "0025899644",


};
Mike.EmailCheck(Mike.Email);
Mike.PhoneCheck(Mike.Mobile);
Mike.OccupationCheck(Mike.Age);

Person Kco = new Person()
{
    FirstName = "Krste",
    LastName = "Krstevski",
    Age = 24,
    State = "Skopje",
    Email = "Krste123@yahoo.com",
    Mobile = "07070707"

};
Kco.EmailCheck(Kco.Email);
Kco.PhoneCheck(Kco.Phone);
Kco.OccupationCheck(Kco.Age);
