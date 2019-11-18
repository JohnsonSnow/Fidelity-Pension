namespace FidelityPension.Models.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PfaDbContext : DbContext
    {
        public PfaDbContext()
            : base("name=PfaDbContext")
        {
        }

        public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public virtual DbSet<CONTRIBUTION> CONTRIBUTIONs { get; set; }
        public virtual DbSet<CONTRIBUTION_BATCH> CONTRIBUTION_BATCH { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.REGISTRATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.OTHERNAMES)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.GENDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.MARITAL_STATUS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PERMANENT_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NATIONALITY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.STATE_OF_ORIGIN)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.LGA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.QUALIFICATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.OCCUPATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INDUSTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.HOME_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.MOBILE_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_RELATIONSHIP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_OFFICE_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_MOBILE_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_HOME_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYEE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_RCNO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_BANK)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_INDUSTRY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_BUSINESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PICTURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SIGNATURE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SERIAL)
                .HasPrecision(20, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVESTOR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PFA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOTES)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.APPROVED_BY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.CHECKED)
                .HasPrecision(1, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.CORRESPONDENCE_ADDS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.DESIGNATION)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PASSPORT)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SIGNATURE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.STATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PRINTED_BY)
                .HasPrecision(5, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NO_OF_PRINTS)
                .HasPrecision(5, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PICTURE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SIGNATURE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.AGENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SALARY_SCALE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.POSTING_LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYEE_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.MAIDEN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PRODUCT1)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PRODUCT2)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PERCENTAGE2)
                .HasPrecision(8, 2);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PRODUCT3)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PERCENTAGE3)
                .HasPrecision(8, 2);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PRODUCT4)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PERCENTAGE4)
                .HasPrecision(8, 2);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PRODUCT5)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PERCENTAGE5)
                .HasPrecision(8, 2);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SCHEME_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.INVEST_PERCENTAGE1)
                .HasPrecision(8, 2);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_ADDRESS1)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_STATECODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.CORRESPONDENCE_ADDS1)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_OTHERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_GENDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_STATECODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_CORRADDRESS1)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_CORRADDRESS2)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_EMAILADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.STATE_OF_POSTING)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PFA_TRANS_IN)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.ACCT_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.RSA_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.CLIENT_STATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.FORM_IMAGE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.BIOMETRICS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.USERID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PIN_BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.ER_NO_OF_PRINTS)
                .HasPrecision(5, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.ER_PRINTED_BY)
                .HasPrecision(15, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.BIOMETRICS1)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.BATCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.FORM_REFNO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK_COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EE_NO_OF_PRINTS)
                .HasPrecision(5, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EE_PRINTED_BY)
                .HasPrecision(15, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EE_PFC_BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.ER_PFC_BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.OLD_EMPLOYEEID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYEE_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.LOCATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SAP_NO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.STAFF_GRADE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.REQ_BY_PENCOM)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.UPLOAD_PIN)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.GRATUITY_RATE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYEE_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PIN_INVALID1)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PIN_NOTIFY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.APPROVED1)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.FLAGNARRATION)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.FLAGDESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.TEAM)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PERM_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.PERM_STATE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.ACCT_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_OTHERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_GENDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_RELATIONSHIP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_MAIDENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_STATECODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_COUNTRYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_MOBILEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NOK2_EMAILADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.ER_ADDR)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.FILE_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_ADDRESS_BK)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMPLOYER_ADDRESS1_BK)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMAIL_ONLY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.ADDRESS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.BRANCHADDRESS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.LATEST_IMAGE_UPDATE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.BVN)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.MOTHER_MAIDEN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.BATCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.POSTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.EMPLOYEE_VARIANCE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.EMPLOYER_VARIANCE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.OTHER_VARIANCE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.OTHER_FEE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TOTAL_UNITS)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.EMPLOYER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.SCHEME_ID)
                .HasPrecision(15, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PAYMENT_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PRICE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_UNITS_R)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_UNITS_V)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.RETIREE_DEPOSITE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.FUND_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.OLD_PFACODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PFC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.PFA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_UNITS)
                .HasPrecision(10, 4);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.SENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.POSTED_BY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.USERID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.FEE_ID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.TRANS_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.CHECKED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.CHECKED_BY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION>()
                .Property(e => e.POSTED1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.BATCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.USERID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.CHECKED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.CHECKED_BY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.NARRATION)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.SCHEME_ID)
                .HasPrecision(15, 0);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.BATCH_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.FEECODE)
                .HasPrecision(15, 0);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.PFA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.OLD_PFACODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.PFC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.EMPLOYER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.SCHEDULE_ID)
                .HasPrecision(15, 0);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.TXN)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.CONTRIBUTION_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.LOADED)
                .HasPrecision(5, 0);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.PROCCESSED)
                .HasPrecision(5, 0);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.REFNO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.FILE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.LOCKED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.INTEREST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIBUTION_BATCH>()
                .Property(e => e.INTEREST_BY)
                .HasPrecision(10, 0);
        }
    }
}
