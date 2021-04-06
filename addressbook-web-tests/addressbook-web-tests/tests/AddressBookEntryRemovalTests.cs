using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddressBookEntryRemovalTests : TestBase
    {
        [Test]
        public void AddressBookEntryRemovalTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.ClickToHomePage();
            app.Contacts.SelectContact(1);
            app.Contacts.ClickDeleteButton();
            app.Contacts.CloseWindowDialog();
            app.Contacts.ClickToHomePage();
            app.Auth.Logout();
        }
    }
}