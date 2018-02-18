namespace MarCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SingUpFree, DurationInMonth, DiscountRate) VALUES (1, 0, 0, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFree, DurationInMonth, DiscountRate) VALUES (2, 10, 10, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFree, DurationInMonth, DiscountRate) VALUES (3, 20, 15, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
