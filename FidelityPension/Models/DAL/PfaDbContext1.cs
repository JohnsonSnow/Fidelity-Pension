namespace FidelityPension.Models.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PfaDbContext1 : DbContext
    {
        public PfaDbContext1()
            : base("name=PfaDbContext1")
        {
        }

        public virtual DbSet<AGENT> AGENTs { get; set; }
        public virtual DbSet<BANK_BRANCHES> BANK_BRANCHES { get; set; }
        public virtual DbSet<BANK> BANKS { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public virtual DbSet<EMPLOYER_DETAILS> EMPLOYER_DETAILS { get; set; }
        public virtual DbSet<LGA> LGAs { get; set; }
        public virtual DbSet<PFA> PFAs { get; set; }
        public virtual DbSet<CONTRIBUTION> CONTRIBUTIONs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AGENT>()
                .Property(e => e.AGENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.AGENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.MOBILE_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.HOME_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.PERMANENT_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.CORRESPONDENCE_ADDS)
                .IsUnicode(false);

            modelBuilder.Entity<AGENT>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BANK_BRANCHES>()
                .Property(e => e.BANK_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BANK_BRANCHES>()
                .Property(e => e.SORTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BANK_BRANCHES>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<BANK_BRANCHES>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<BANK_BRANCHES>()
                .Property(e => e.TRANS_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.TRANS_ID)
                .HasPrecision(10, 0);

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

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.RCNO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.CORRESPONDENCE_ADDS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.EMAIL_ADDS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.WEBSITE_ADDS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.INDUSTRY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.BUSINESS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.EMPLOYER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.ER_PFC_BATCH)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.SECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.SUBSECTOR)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.STATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.RETIREMENT_AGE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.EMAIL_ONLY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER_DETAILS>()
                .Property(e => e.Sequence_Identity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LGA>()
                .Property(e => e.STATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<LGA>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<LGA>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<LGA>()
                .Property(e => e.TRANSID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PFA>()
                .Property(e => e.PFA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.PFA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.PFA_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.PFA_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.PFA_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.PFA_LOGO)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.CONTACT_PERSON)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.CONTACT_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.CONTACT_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PFA>()
                .Property(e => e.WEBSITE)
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
        }
    }
}
