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
            app.Groups.EditGroupButton();
            GroupData group = new GroupData("zzz");
            group.Footer = "yyy";
            group.Header = "xxx";
            app.Groups.FillGroupForm(group);
            app.Groups.ClickUpdateButton();
            app.Groups.ReturnsToGroupPage();
            app.Auth.Logout();
        }
    }
}