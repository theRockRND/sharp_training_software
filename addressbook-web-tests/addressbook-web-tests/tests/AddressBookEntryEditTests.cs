using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddressBookEntryEditTests : TestBase
    {
        [Test]
        public void TheAddressBookEntryEditTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.ClickToHomePage();
            app.Contacts.SelectContact(1);
            app.Contacts.ClickDetailsButton();
            app.Contacts.ClickModifyButton();
            EntryData entry = new EntryData("new Михаил");
            entry.Lastname = "Трубицин new";
            entry.Middlename = "New";
            entry.Nickname = "zzz автотестов";
            entry.Title = "Это zzz";
            entry.Company = "yyy компании";
            entry.Address = "";
            entry.Home = "1564df5g6";
            entry.Mobile = "3df9iuh53789";
            entry.Work = "4564";
            entry.Fax = "3gdfg3";
            entry.Email = "email1dfgil.ru";
            entry.Email2 = "emaildfgfdgil.ru";
            entry.Email3 = "emadfgfdgl.ru";
            entry.Homepage = "wwwdfgfdgdfgpb.ru";
            entry.Address2 = "195000dfgdfgdfлотский переулок 12";
            entry.Phone2 = "81dfgfdg-456";
            entry.Notes = "Комментарий dfgdfgне уверен точно";
            app.Contacts.FillEntryForm(entry);
            app.Contacts.ClickUpdateButton();
            app.Contacts.ClickToHomePage();
            app.Auth.Logout();
        }
    }
}

