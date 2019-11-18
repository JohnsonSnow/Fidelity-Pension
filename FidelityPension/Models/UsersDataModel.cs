namespace FidelityPension.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UsersDataModel : DbContext
    {
        public UsersDataModel()
            : base("name=UsersDataModel")
        {
        }

        public virtual DbSet<S_USER> S_USER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<S_USER>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.DAY_1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.DAY_2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.DAY_3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.DAY_4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.DAY_5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.DAY_6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.DAY_7)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.SUPERVISOR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.USER_LOGIN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.PASS_FREQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.PASS_DURATION)
                .HasPrecision(3, 0);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.FULL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.USERID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.USERPIN)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.ROLEID)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.STREET)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.HINTQUESTION)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.HINTANSWER)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.PASSCHG_LOGON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.PASSNO_EXPIRE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.PIN_MISSED)
                .HasPrecision(1, 0);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.PASSNO_CHANGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.USER_DISABLED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.USER_LOCKED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.USER_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.ACCOUNT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.INVESTOR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<S_USER>()
                .Property(e => e.WORKSTATION)
                .IsUnicode(false);
        }
    }
}
