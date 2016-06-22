namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly Membership' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly Membership' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual Membership' WHERE Id = 4");

        }
        
        public override void Down()
        {
        }
    }
}
