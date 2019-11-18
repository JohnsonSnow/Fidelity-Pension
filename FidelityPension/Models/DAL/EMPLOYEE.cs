namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEES")]
    public partial class EMPLOYEE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string REGISTRATION_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string PIN { get; set; }

        [StringLength(10)]
        public string TITLE { get; set; }

        [StringLength(30)]
        public string SURNAME { get; set; }

        [StringLength(30)]
        public string FIRSTNAME { get; set; }

        [StringLength(30)]
        public string OTHERNAMES { get; set; }

        [StringLength(1)]
        public string GENDER { get; set; }

        [StringLength(30)]
        public string SSN { get; set; }

        public DateTime? DATE_OF_BIRTH { get; set; }

        [StringLength(10)]
        public string MARITAL_STATUS_CODE { get; set; }

        [Column(TypeName = "text")]
        public string PERMANENT_ADDRESS { get; set; }

        [StringLength(10)]
        public string NATIONALITY_CODE { get; set; }

        [StringLength(10)]
        public string STATE_OF_ORIGIN { get; set; }

        [StringLength(10)]
        public string LGA_CODE { get; set; }

        [StringLength(10)]
        public string QUALIFICATION_CODE { get; set; }

        [StringLength(10)]
        public string OCCUPATION_CODE { get; set; }

        [StringLength(10)]
        public string INDUSTRY_CODE { get; set; }

        [StringLength(60)]
        public string HOME_PHONE { get; set; }

        [StringLength(60)]
        public string MOBILE_PHONE { get; set; }

        [StringLength(80)]
        public string EMAIL { get; set; }

        [StringLength(80)]
        public string NOK_NAME { get; set; }

        [Column(TypeName = "text")]
        public string NOK_ADDRESS { get; set; }

        [StringLength(10)]
        public string NOK_RELATIONSHIP { get; set; }

        [StringLength(60)]
        public string NOK_OFFICE_PHONE { get; set; }

        [StringLength(60)]
        public string NOK_MOBILE_PHONE { get; set; }

        [StringLength(60)]
        public string NOK_HOME_PHONE { get; set; }

        [StringLength(20)]
        public string EMPLOYEE_ID { get; set; }

        [StringLength(100)]
        public string EMPLOYER_NAME { get; set; }

        [StringLength(20)]
        public string EMPLOYER_RCNO { get; set; }

        [StringLength(250)]
        public string EMPLOYER_ADDRESS { get; set; }

        [StringLength(60)]
        public string EMPLOYER_PHONE { get; set; }

        [StringLength(80)]
        public string EMPLOYER_EMAIL { get; set; }

        [StringLength(80)]
        public string EMPLOYER_WEBSITE { get; set; }

        [StringLength(80)]
        public string EMPLOYER_CONTACT { get; set; }

        [StringLength(10)]
        public string EMPLOYER_BANK { get; set; }

        [StringLength(50)]
        public string EMPLOYER_INDUSTRY { get; set; }

        [StringLength(10)]
        public string EMPLOYER_BUSINESS { get; set; }

        public DateTime? DATE_EMPLOYED { get; set; }

        public decimal? MONTHLY_SALARY { get; set; }

        [StringLength(200)]
        public string PICTURE_URL { get; set; }

        [StringLength(200)]
        public string SIGNATURE_URL { get; set; }

        public decimal? SERIAL { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal INVESTOR_ID { get; set; }

        public bool EXTRACTED { get; set; }

        [StringLength(20)]
        public string PFA_CODE { get; set; }

        [StringLength(10)]
        public string BRANCH_CODE { get; set; }

        [Column(TypeName = "text")]
        public string NOTES { get; set; }

        public decimal? CHECKED_BY { get; set; }

        public DateTime? CHECKED_DATE { get; set; }

        public decimal? APPROVED_BY { get; set; }

        public DateTime? APPROVED_DATE { get; set; }

        public decimal? CHECKED { get; set; }

        public bool APPROVED { get; set; }

        public bool EXP_TO_PENCOM { get; set; }

        public bool EXP_TO_PRINT { get; set; }

        public bool PIN_NOTIFICATION { get; set; }

        public bool UPLOAD { get; set; }

        [Column(TypeName = "text")]
        public string CORRESPONDENCE_ADDS { get; set; }

        public decimal? EMPLOYEE_CONTRIBUTION { get; set; }

        public decimal? EMPLOYER_CONTRIBUTION { get; set; }

        public decimal? OTHER_CONTRIBUTION { get; set; }

        [StringLength(10)]
        public string DEPARTMENT { get; set; }

        [StringLength(10)]
        public string DESIGNATION { get; set; }

        [StringLength(40)]
        public string PASSPORT { get; set; }

        [StringLength(40)]
        public string SIGNATURE { get; set; }

        [StringLength(1)]
        public string STATUS { get; set; }

        public decimal? PRINTED_BY { get; set; }

        public decimal? NO_OF_PRINTS { get; set; }

        public DateTime? PRINT_DATE { get; set; }

        public bool PRINT_STATUS { get; set; }

        [StringLength(5)]
        public string PICTURE_TYPE { get; set; }

        [StringLength(5)]
        public string SIGNATURE_TYPE { get; set; }

        public bool COY_SELECT_OPTION { get; set; }

        [StringLength(15)]
        public string AGENT_CODE { get; set; }

        [Column(TypeName = "image")]
        public byte[] FINGER_PRINT { get; set; }

        public DateTime? DATE_CONFIRMED { get; set; }

        [StringLength(15)]
        public string SALARY_SCALE { get; set; }

        public decimal? GRADE_LEVEL { get; set; }

        public decimal? STEP { get; set; }

        [StringLength(25)]
        public string POSTING_LOCATION { get; set; }

        public decimal? BASIC_ALLOWANCE { get; set; }

        public decimal? TRANSPORT_ALLOWANCE { get; set; }

        public decimal? HOUSING_ALLOWANCE { get; set; }

        public decimal? OTHER_ALLOWANCE { get; set; }

        [StringLength(1)]
        public string EMPLOYEE_TYPE { get; set; }

        [StringLength(25)]
        public string MAIDEN_NAME { get; set; }

        public decimal? INVEST_PRODUCT1 { get; set; }

        public decimal? INVEST_PRODUCT2 { get; set; }

        public decimal? INVEST_PERCENTAGE2 { get; set; }

        public decimal? INVEST_PRODUCT3 { get; set; }

        public decimal? INVEST_PERCENTAGE3 { get; set; }

        public decimal? INVEST_PRODUCT4 { get; set; }

        public decimal? INVEST_PERCENTAGE4 { get; set; }

        public decimal? INVEST_PRODUCT5 { get; set; }

        public decimal? INVEST_PERCENTAGE5 { get; set; }

        public decimal? SCHEME_ID { get; set; }

        public decimal? INVEST_PERCENTAGE1 { get; set; }

        [StringLength(250)]
        public string EMPLOYER_ADDRESS1 { get; set; }

        [StringLength(25)]
        public string EMPLOYER_CITY { get; set; }

        [StringLength(15)]
        public string EMPLOYER_STATECODE { get; set; }

        [Column(TypeName = "text")]
        public string CORRESPONDENCE_ADDS1 { get; set; }

        [StringLength(25)]
        public string NOK_SURNAME { get; set; }

        [StringLength(40)]
        public string NOK_OTHERNAME { get; set; }

        [StringLength(1)]
        public string NOK_GENDER { get; set; }

        [StringLength(10)]
        public string NOK_STATECODE { get; set; }

        [Column(TypeName = "text")]
        public string NOK_CORRADDRESS1 { get; set; }

        [Column(TypeName = "text")]
        public string NOK_CORRADDRESS2 { get; set; }

        [StringLength(25)]
        public string NOK_CITY { get; set; }

        [StringLength(45)]
        public string NOK_EMAILADDRESS { get; set; }

        [StringLength(20)]
        public string CITY { get; set; }

        [StringLength(10)]
        public string STATE_OF_POSTING { get; set; }

        [StringLength(10)]
        public string STATE { get; set; }

        [StringLength(20)]
        public string PFA_TRANS_IN { get; set; }

        [StringLength(1)]
        public string ACCT_TYPE { get; set; }

        [StringLength(16)]
        public string RSA_NUMBER { get; set; }

        [StringLength(1)]
        public string CLIENT_STATUS { get; set; }

        [StringLength(40)]
        public string FORM_IMAGE { get; set; }

        [StringLength(40)]
        public string BIOMETRICS { get; set; }

        public DateTime? DATE_CREATED { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(25)]
        public string PIN_BATCH { get; set; }

        public decimal? ER_NO_OF_PRINTS { get; set; }

        public bool ER_PRINT_STATUS { get; set; }

        public decimal? ER_PRINTED_BY { get; set; }

        public DateTime? ER_PRINT_DATE { get; set; }

        [StringLength(40)]
        public string BIOMETRICS1 { get; set; }

        [StringLength(25)]
        public string BATCH_ID { get; set; }

        [StringLength(100)]
        public string FORM_REFNO { get; set; }

        public bool GENDER1 { get; set; }

        public bool MARITAL_STATUS1 { get; set; }

        public bool NOK_GENDER1 { get; set; }

        [StringLength(20)]
        public string NOK_TITLE { get; set; }

        [StringLength(20)]
        public string NOK_COUNTRY { get; set; }

        public bool PIN_INVALID { get; set; }

        public decimal? EE_NO_OF_PRINTS { get; set; }

        public decimal? EE_PRINTED_BY { get; set; }

        public DateTime? EE_PRINT_DATE { get; set; }

        public bool EE_PRINT_STATUS { get; set; }

        public bool EE_PFC_CHECK { get; set; }

        public bool ER_PFC_CHECK { get; set; }

        [StringLength(15)]
        public string EE_PFC_BATCH { get; set; }

        [StringLength(15)]
        public string ER_PFC_BATCH { get; set; }

        [StringLength(15)]
        public string OLD_EMPLOYEEID { get; set; }

        [StringLength(20)]
        public string EMPLOYEE_GROUP { get; set; }

        [StringLength(20)]
        public string LOCATION_CODE { get; set; }

        [StringLength(15)]
        public string SAP_NO { get; set; }

        public decimal? MEAL_SUBSIDY { get; set; }

        public decimal? LEAVE_ALLOWANCE { get; set; }

        [StringLength(20)]
        public string STAFF_GRADE { get; set; }

        public DateTime? DATE_JOINED_FUND { get; set; }

        public DateTime? LAST_PROMO_DATE { get; set; }

        public DateTime? DATE_SENT { get; set; }

        [StringLength(1)]
        public string REQ_BY_PENCOM { get; set; }

        [StringLength(20)]
        public string UPLOAD_PIN { get; set; }

        [Column(TypeName = "image")]
        public byte[] PICTURE_IMAGE { get; set; }

        [Column(TypeName = "image")]
        public byte[] SIGNATURE_IMAGE { get; set; }

        [Column(TypeName = "image")]
        public byte[] THUMBPRINT { get; set; }

        [Column(TypeName = "image")]
        public byte[] THUMBPRINT1 { get; set; }

        public decimal? GRATUITY_RATE { get; set; }

        public DateTime? EXIT_DATE { get; set; }

        [StringLength(20)]
        public string EMPLOYEE_CATEGORY { get; set; }

        public bool STMT_OPTION { get; set; }

        [StringLength(1)]
        public string PIN_INVALID1 { get; set; }

        [StringLength(1)]
        public string PIN_NOTIFY { get; set; }

        [StringLength(1)]
        public string APPROVED1 { get; set; }

        public DateTime? UPLOAD_DATE { get; set; }

        [StringLength(250)]
        public string COMMENT { get; set; }

        public DateTime? LAST_CONTRIBUTION_DATE { get; set; }

        [StringLength(1)]
        public string FLAGNARRATION { get; set; }

        [StringLength(200)]
        public string FLAGDESCRIPTION { get; set; }

        [StringLength(20)]
        public string TEAM { get; set; }

        [StringLength(20)]
        public string PERM_CITY { get; set; }

        [StringLength(10)]
        public string PERM_STATE { get; set; }

        [StringLength(1)]
        public string ACCT_FLAG { get; set; }

        [StringLength(10)]
        public string NOK2_TITLE { get; set; }

        [StringLength(25)]
        public string NOK2_SURNAME { get; set; }

        [StringLength(25)]
        public string NOK2_FIRSTNAME { get; set; }

        [StringLength(25)]
        public string NOK2_OTHERNAME { get; set; }

        [StringLength(1)]
        public string NOK2_GENDER { get; set; }

        public DateTime? NOK2_DATE_OF_BIRTH { get; set; }

        [StringLength(10)]
        public string NOK2_RELATIONSHIP { get; set; }

        [StringLength(25)]
        public string NOK2_MAIDENNAME { get; set; }

        [Column(TypeName = "text")]
        public string NOK2_ADDRESS { get; set; }

        [StringLength(25)]
        public string NOK2_CITY { get; set; }

        [StringLength(10)]
        public string NOK2_STATECODE { get; set; }

        [StringLength(10)]
        public string NOK2_COUNTRYCODE { get; set; }

        [StringLength(25)]
        public string NOK2_MOBILEPHONE { get; set; }

        [StringLength(80)]
        public string NOK2_EMAILADDRESS { get; set; }

        [Column(TypeName = "text")]
        public string ER_ADDR { get; set; }

        [StringLength(20)]
        public string FILE_NUM { get; set; }

        [StringLength(250)]
        public string EMPLOYER_ADDRESS_BK { get; set; }

        [StringLength(250)]
        public string EMPLOYER_ADDRESS1_BK { get; set; }

        public DateTime? NOK_DOB { get; set; }

        [StringLength(1)]
        public string EMAIL_ONLY { get; set; }

        public bool? ISNOTIFIED { get; set; }

        [StringLength(20)]
        public string ADDRESS_CODE { get; set; }

        [StringLength(20)]
        public string BRANCHADDRESS_NAME { get; set; }

        public decimal? LATEST_IMAGE_UPDATE { get; set; }

        [StringLength(20)]
        public string BVN { get; set; }

        [StringLength(50)]
        public string MOTHER_MAIDEN_NAME { get; set; }

        public DateTime? NOK_DOB2 { get; set; }

        [StringLength(1)]
        public string SMS_NOTIFICATION { get; set; }

        [StringLength(5)]
        public string REGISTRATION_TYPE { get; set; }

        [StringLength(50)]
        public string PLACE_OF_BIRTH { get; set; }

        [StringLength(1)]
        public string PERMANENT_ADDRESS_LOCATION { get; set; }

        [StringLength(100)]
        public string PERMANENT_ADDRESS1 { get; set; }

        [StringLength(10)]
        public string PERM_LGA { get; set; }

        [StringLength(10)]
        public string PERM_COUNTRY { get; set; }

        [StringLength(10)]
        public string PERM_ZIP { get; set; }

        [StringLength(50)]
        public string PERM_BOX { get; set; }

        [StringLength(80)]
        public string EMAIL1 { get; set; }

        [StringLength(25)]
        public string MOBILE_PHONE1 { get; set; }

        [StringLength(2)]
        public string EMPLOYER_TYPE { get; set; }

        [StringLength(1)]
        public string EMPLOYER_LOCATION { get; set; }

        [StringLength(10)]
        public string EMPLOYER_LGA { get; set; }

        [StringLength(10)]
        public string EMPLOYER_COUNTRY { get; set; }

        [StringLength(10)]
        public string EMPLOYER_ZIP { get; set; }

        [StringLength(50)]
        public string EMPLOYER_BOX { get; set; }

        public DateTime? DATE_OF_FIRST_APPPOINMENT { get; set; }

        [StringLength(1)]
        public string NOK_LOCATION { get; set; }

        [StringLength(100)]
        public string NOK_ADDRESS1 { get; set; }

        [StringLength(10)]
        public string NOK_ZIP { get; set; }

        [StringLength(50)]
        public string NOK_BOX { get; set; }

        [StringLength(1)]
        public string NOK2_LOCATION { get; set; }

        [StringLength(100)]
        public string NOK2_ADDRESS1 { get; set; }

        [StringLength(10)]
        public string NOK2_LGA { get; set; }

        [StringLength(10)]
        public string NOK2_ZIP { get; set; }

        [StringLength(50)]
        public string NO2K_BOX { get; set; }

        [StringLength(10)]
        public string TITLE_BK { get; set; }

        [StringLength(10)]
        public string NOK_LGA { get; set; }

        [StringLength(50)]
        public string NOK2_BOX { get; set; }
    }
}
