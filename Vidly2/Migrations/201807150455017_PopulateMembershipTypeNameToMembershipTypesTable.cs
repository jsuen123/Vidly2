namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeNameToMembershipTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET Name='Pay as You Go' WHERE Id=1");
            Sql("Update MembershipTypes SET Name='Monthly' WHERE Id=2");
            Sql("Update MembershipTypes SET Name='Quarterly' WHERE Id=3");
            Sql("Update MembershipTypes SET Name='Annually' WHERE Id=4");
        }

        public override void Down()
        {
            Sql("Update MembershipTypes SET Name=Null WHERE Id=1");
            Sql("Update MembershipTypes SET Name=Null WHERE Id=2");
            Sql("Update MembershipTypes SET Name=Null WHERE Id=3");
            Sql("Update MembershipTypes SET Name=Null WHERE Id=4");
        }
    }
}
