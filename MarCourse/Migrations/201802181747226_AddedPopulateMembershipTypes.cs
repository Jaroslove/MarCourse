namespace MarCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SingUpFree, DurationInMonth, DiscountRate, Name) VALUES (1, 0, 0, 10, 'first'");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFree, DurationInMonth, DiscountRate, Name) VALUES (2, 10, 10, 10, 'Second')");
            Sql("INSERT INTO MembershipTypes (Id, SingUpFree, DurationInMonth, DiscountRate, Name) VALUES (3, 20, 15, 10, 'thrid')");
        }
        
        public override void Down()
        {
        }
    }
}
