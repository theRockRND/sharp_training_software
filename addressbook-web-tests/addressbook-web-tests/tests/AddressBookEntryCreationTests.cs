using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddressBookEntryCreationTests : TestBase
    {
        [Test]
        public void TheAddressBookEntryCreationTestsTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToEntryPage();
            EntryData entry = new EntryData("Михаил");
            entry.Lastname = "Трубицин";
            entry.Middlename = "Юрьевич";
            entry.Nickname = "Король автотестов";
            entry.Title = "Это заголовок";
            entry.Company = "Название компании";
            entry.Address = "344000 Ростов-на-Дону, Ворошиловский 15";
            entry.Home = "+7-862-123-456";
            entry.Mobile = "+7-987-123-04-05";
            entry.Work = "02";
            entry.Fax = "123456789";
            entry.Email = "email1@mail.ru";
            entry.Email2 = "email2@mail.ru";
            entry.Email3 = "email3@mail.ru";
            entry.Homepage = "www.leningrad.spb.ru";
            entry.Address2 = "195000 Санкт-Петербург, Нейшлотский переулок 12";
            entry.Phone2 = "812-123-456";
            entry.Notes = "Комментарий или замечание, или и то и другое. не уверен точно"; 
            app.Contacts.FillEntryForm(entry);
            app.Contacts.SubmitEntryCreation();
            app.Contacts.ReturnToEntryPage();
            app.Auth.Logout();
        }
    }
}
