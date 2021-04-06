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
            app.Contacts.EditFirstName();
            app.Contacts.EditMiddleName();
            app.Contacts.EditLastName();
            app.Contacts.EditAddress();
            app.Contacts.ClickUpdateButton();
            app.Contacts.ClickToHomePage();
            app.Auth.Logout();
        }
    }
}

