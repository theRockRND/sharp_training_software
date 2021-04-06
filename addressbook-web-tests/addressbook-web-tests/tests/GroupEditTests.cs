using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupEditTests : TestBase
    {
        [Test]
        public void GroupEditTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.SelectGroup(1);
            app.Groups.EditGroup();
            app.Groups.EditGroupName();
            app.Groups.EditGroupHeader();
            app.Groups.EditGroupFooter();
            app.Groups.ClickUpdateButton();
            app.Groups.ReturnsToGroupPage();
            app.Auth.Logout();
        }
    }
}

