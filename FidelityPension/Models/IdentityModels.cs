using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
using FidelityPension.Models.Core;
//using FidelityPension.Models.DAL;

namespace FidelityPension.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string MobileVerificationCode { get; set; }
        public string FileNumber { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            //Database.SetInitializer<ApplicationDbContext>(null); // Remove default initializer
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<HomePageModel> HomePageModels { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<RsaStatus> RsaStatus { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }
        public virtual DbSet<LGA> LGAs { get; set; }
        public virtual DbSet<SectorClassification> SectorClassifications { get; set; }
        public virtual DbSet<State> States { get; set; }


        #region

        //public virtual DbSet<ACCOUNT_FLAG> ACCOUNT_FLAG { get; set; }
        //public virtual DbSet<ACCOUNT_TRANSACTION> ACCOUNT_TRANSACTION { get; set; }
        //public virtual DbSet<ADDRESS_TYPE> ADDRESS_TYPE { get; set; }
        //public virtual DbSet<ADMIN_FEES_SETUP> ADMIN_FEES_SETUP { get; set; }
        //public virtual DbSet<ADMINFEE_CATEGORY> ADMINFEE_CATEGORY { get; set; }
        //public virtual DbSet<ADMINISTRATIVE_FEE> ADMINISTRATIVE_FEE { get; set; }
        //public virtual DbSet<AGENT> AGENTs { get; set; }
        //public virtual DbSet<AUTHORISERS_MENU> AUTHORISERS_MENU { get; set; }
        //public virtual DbSet<avc_email_push> avc_email_push { get; set; }
        //public virtual DbSet<BANK_BRANCHES> BANK_BRANCHES { get; set; }
        //public virtual DbSet<BANK> BANKS { get; set; }
        //public virtual DbSet<BATCH_REG_BATCH> BATCH_REG_BATCH { get; set; }
        //public virtual DbSet<BATCH_REGISTRATION_ABBYY> BATCH_REGISTRATION_ABBYY { get; set; }
        //public virtual DbSet<BOND_AMORTIZATION> BOND_AMORTIZATION { get; set; }
        //public virtual DbSet<BOND_ISSUER> BOND_ISSUER { get; set; }
        //public virtual DbSet<BONDS_ACCT> BONDS_ACCT { get; set; }
        //public virtual DbSet<BONDS_INTEREST_RECEIVED> BONDS_INTEREST_RECEIVED { get; set; }
        //public virtual DbSet<BONDS_PV> BONDS_PV { get; set; }
        //public virtual DbSet<BRANCH> BRANCHes { get; set; }
        //public virtual DbSet<BROKER> BROKERS { get; set; }
        //public virtual DbSet<BUSINESS_TYPES> BUSINESS_TYPES { get; set; }
        //public virtual DbSet<BUSINESS_UNITS> BUSINESS_UNITS { get; set; }
        //public virtual DbSet<CA_JOURNAL> CA_JOURNAL { get; set; }
        //public virtual DbSet<CAJOURNAL_TEMPLATE> CAJOURNAL_TEMPLATE { get; set; }
        //public virtual DbSet<CAJOURNAL_TYPES> CAJOURNAL_TYPES { get; set; }
        //public virtual DbSet<CAPITAL_MARKET_ACCT> CAPITAL_MARKET_ACCT { get; set; }
        //public virtual DbSet<CLIENT_STAT_PIN_BATCH> CLIENT_STAT_PIN_BATCH { get; set; }
        //public virtual DbSet<CLIENT_STAT_PIN_TRANS> CLIENT_STAT_PIN_TRANS { get; set; }
        //public virtual DbSet<COMPANY_SECTORS> COMPANY_SECTORS { get; set; }
        //public virtual DbSet<CONTACT> CONTACTs { get; set; }
        //public virtual DbSet<CONTRIBUTION_ACCT> CONTRIBUTION_ACCT { get; set; }
        //public virtual DbSet<CONTRIBUTION_HISTORY> CONTRIBUTION_HISTORY { get; set; }
        //public virtual DbSet<CONTRIBUTION_RAW> CONTRIBUTION_RAW { get; set; }
        //public virtual DbSet<CONTRIBUTION_TRAN> CONTRIBUTION_TRAN { get; set; }
        //public virtual DbSet<CONTRIBUTION_TYPES> CONTRIBUTION_TYPES { get; set; }
        //public virtual DbSet<CRM_ISSUE_LOG> CRM_ISSUE_LOG { get; set; }
        //public virtual DbSet<CRM_ISSUE_TYPE> CRM_ISSUE_TYPE { get; set; }
        //public virtual DbSet<CRM_ISSUES> CRM_ISSUES { get; set; }
        //public virtual DbSet<CRM_NOTES> CRM_NOTES { get; set; }
        //public virtual DbSet<CRM_NOTIFICATION> CRM_NOTIFICATION { get; set; }
        //public virtual DbSet<CRM_RESOLUTION_TYPE> CRM_RESOLUTION_TYPE { get; set; }
        //public virtual DbSet<CRM_SEVERITY_CODES> CRM_SEVERITY_CODES { get; set; }
        //public virtual DbSet<CURRENCY_FOREX_RATES> CURRENCY_FOREX_RATES { get; set; }
        //public virtual DbSet<DB_EXIT_PROCESS> DB_EXIT_PROCESS { get; set; }
        //public virtual DbSet<DB_EXIT_PROCESS_BATCH> DB_EXIT_PROCESS_BATCH { get; set; }
        //public virtual DbSet<DB_EXIT_PROCESS_LOG> DB_EXIT_PROCESS_LOG { get; set; }
        //public virtual DbSet<DB_PAYMENT> DB_PAYMENT { get; set; }
        //public virtual DbSet<DB_WITHDRAWAL_PROCESS> DB_WITHDRAWAL_PROCESS { get; set; }
        //public virtual DbSet<defaulting_emprs> defaulting_emprs { get; set; }
        //public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        //public virtual DbSet<DESIGNATION> DESIGNATIONs { get; set; }
        //public virtual DbSet<DIVIDEND_ACCT> DIVIDEND_ACCT { get; set; }
        //public virtual DbSet<DOCUMENTATION_TRAIL> DOCUMENTATION_TRAIL { get; set; }
        //public virtual DbSet<DYNAMIC_REPORT> DYNAMIC_REPORT { get; set; }
        //public virtual DbSet<EE_PFC_BATCH> EE_PFC_BATCH { get; set; }
        //public virtual DbSet<EMPLOYEE_ACCOUNTS> EMPLOYEE_ACCOUNTS { get; set; }
        //public virtual DbSet<EMPLOYEE_BUFFER> EMPLOYEE_BUFFER { get; set; }
        //public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        //public virtual DbSet<EMPLOYEES_ACTIVE_31_12_2018> EMPLOYEES_ACTIVE_31_12_2018 { get; set; }
        //public virtual DbSet<EMPLOYEESzz> EMPLOYEESzzs { get; set; }
        //public virtual DbSet<EMPLOYER_DETAILS> EMPLOYER_DETAILS { get; set; }
        //public virtual DbSet<EMPLOYER_DETAILS_LOG> EMPLOYER_DETAILS_LOG { get; set; }
        //public virtual DbSet<EMPLOYER_DETAILS_NORMALIZED> EMPLOYER_DETAILS_NORMALIZED { get; set; }
        //public virtual DbSet<ER_PFC_BATCH> ER_PFC_BATCH { get; set; }
        //public virtual DbSet<EXIT_ADD_PAYMENT> EXIT_ADD_PAYMENT { get; set; }
        //public virtual DbSet<EXIT_PROCESS_BATCH> EXIT_PROCESS_BATCH { get; set; }
        //public virtual DbSet<EXIT_PROCESS_ERRORLOG> EXIT_PROCESS_ERRORLOG { get; set; }
        //public virtual DbSet<EXIT_PROCESS_MASTER> EXIT_PROCESS_MASTER { get; set; }
        //public virtual DbSet<EXIT_PROCESS_PAYMENT_A_BATCH> EXIT_PROCESS_PAYMENT_A_BATCH { get; set; }
        //public virtual DbSet<EXIT_PROCESS_PAYMENT_BATCH> EXIT_PROCESS_PAYMENT_BATCH { get; set; }
        //public virtual DbSet<EXIT_PROCESS_PAYMENT_TYPE> EXIT_PROCESS_PAYMENT_TYPE { get; set; }
        //public virtual DbSet<EXIT_PROCESS_REGISTRATION> EXIT_PROCESS_REGISTRATION { get; set; }
        //public virtual DbSet<EXIT_PROCESS_STATUS> EXIT_PROCESS_STATUS { get; set; }
        //public virtual DbSet<EXIT_TYPE> EXIT_TYPE { get; set; }
        //public virtual DbSet<EXITING_PROCESS> EXITING_PROCESS { get; set; }
        //public virtual DbSet<EXITING_PROCESS_LOG> EXITING_PROCESS_LOG { get; set; }
        //public virtual DbSet<FEES_ACCT> FEES_ACCT { get; set; }
        //public virtual DbSet<FEES_DAILY> FEES_DAILY { get; set; }
        //public virtual DbSet<FEES_SETUP> FEES_SETUP { get; set; }
        //public virtual DbSet<FEES_SUMMARY> FEES_SUMMARY { get; set; }
        //public virtual DbSet<FI_EXPOSURE_SUMMARY> FI_EXPOSURE_SUMMARY { get; set; }
        //public virtual DbSet<FID_IPPIS> FID_IPPIS { get; set; }
        //public virtual DbSet<FIDELITY_TCF_SAVE_07_02_2019> FIDELITY_TCF_SAVE_07_02_2019 { get; set; }
        //public virtual DbSet<FINANCIAL_ANALYSIS_UPDATE> FINANCIAL_ANALYSIS_UPDATE { get; set; }
        //public virtual DbSet<FIXED_INCOME_BLOTTER> FIXED_INCOME_BLOTTER { get; set; }
        //public virtual DbSet<FOREX> FOREXes { get; set; }
        //public virtual DbSet<FOREX_RATES> FOREX_RATES { get; set; }
        //public virtual DbSet<FORM_REF_DUP> FORM_REF_DUP { get; set; }
        //public virtual DbSet<FORM_REF_TEMP> FORM_REF_TEMP { get; set; }
        //public virtual DbSet<fund_3_import> fund_3_import { get; set; }
        //public virtual DbSet<fund_ii_import> fund_ii_import { get; set; }
        //public virtual DbSet<fund_iii_import> fund_iii_import { get; set; }
        //public virtual DbSet<FUND_PERFORMANCE_REPORT> FUND_PERFORMANCE_REPORT { get; set; }
        //public virtual DbSet<FUNDED_DATA_LOG> FUNDED_DATA_LOG { get; set; }
        //public virtual DbSet<FUNDED_DATA_RMAS> FUNDED_DATA_RMAS { get; set; }
        //public virtual DbSet<FUNDED_PERIODIC> FUNDED_PERIODIC { get; set; }
        //public virtual DbSet<FUNDED_PINS> FUNDED_PINS { get; set; }
        //public virtual DbSet<FUNDED_RSA> FUNDED_RSA { get; set; }
        //public virtual DbSet<FUNDED_YTD> FUNDED_YTD { get; set; }
        //public virtual DbSet<FUNDMANAGER_BATCH> FUNDMANAGER_BATCH { get; set; }
        //public virtual DbSet<FUNDMANAGER_TRAN> FUNDMANAGER_TRAN { get; set; }
        //public virtual DbSet<GL_ACCOUNT_TEMPLATE_MEMBERS> GL_ACCOUNT_TEMPLATE_MEMBERS { get; set; }
        //public virtual DbSet<GL_ACCOUNT_TEMPLATES> GL_ACCOUNT_TEMPLATES { get; set; }
        //public virtual DbSet<GL_ACCT_ANALYSIS> GL_ACCT_ANALYSIS { get; set; }
        //public virtual DbSet<GL_AUTO> GL_AUTO { get; set; }
        //public virtual DbSet<GL_AUTOGROUP> GL_AUTOGROUP { get; set; }
        //public virtual DbSet<GL_BAL_CHANGE_DATA> GL_BAL_CHANGE_DATA { get; set; }
        //public virtual DbSet<GL_BALANCE_SHEET> GL_BALANCE_SHEET { get; set; }
        //public virtual DbSet<GL_BALSHT_ACCOUNT> GL_BALSHT_ACCOUNT { get; set; }
        //public virtual DbSet<GL_BALSHT_ITEM> GL_BALSHT_ITEM { get; set; }
        //public virtual DbSet<GL_BAT> GL_BAT { get; set; }
        //public virtual DbSet<GL_BAT_TRS> GL_BAT_TRS { get; set; }
        //public virtual DbSet<GL_BUDGET> GL_BUDGET { get; set; }
        //public virtual DbSet<GL_CASH_FLOW> GL_CASH_FLOW { get; set; }
        //public virtual DbSet<GL_CASH_FLOWS> GL_CASH_FLOWS { get; set; }
        //public virtual DbSet<GL_CATEGORY> GL_CATEGORY { get; set; }
        //public virtual DbSet<GL_CF_ACCOUNT> GL_CF_ACCOUNT { get; set; }
        //public virtual DbSet<GL_CF_ITEM> GL_CF_ITEM { get; set; }
        //public virtual DbSet<GL_CLIENT_ACCTS> GL_CLIENT_ACCTS { get; set; }
        //public virtual DbSet<GL_CLIENT_STATEMENT> GL_CLIENT_STATEMENT { get; set; }
        //public virtual DbSet<GL_CLIENTS> GL_CLIENTS { get; set; }
        //public virtual DbSet<GL_COMPANY> GL_COMPANY { get; set; }
        //public virtual DbSet<GL_COMPANY_PL_RPT> GL_COMPANY_PL_RPT { get; set; }
        //public virtual DbSet<GL_COMPANY_UNITS> GL_COMPANY_UNITS { get; set; }
        //public virtual DbSet<GL_COUNTRY> GL_COUNTRY { get; set; }
        //public virtual DbSet<GL_CSH_ACCOUNT> GL_CSH_ACCOUNT { get; set; }
        //public virtual DbSet<GL_CSH_ITEM> GL_CSH_ITEM { get; set; }
        //public virtual DbSet<GL_CURRENCY> GL_CURRENCY { get; set; }
        //public virtual DbSet<GL_DEPARTMENT> GL_DEPARTMENT { get; set; }
        //public virtual DbSet<GL_DISTRIBUTION> GL_DISTRIBUTION { get; set; }
        //public virtual DbSet<GL_DIVISION> GL_DIVISION { get; set; }
        //public virtual DbSet<GL_EMPLOYEE> GL_EMPLOYEE { get; set; }
        //public virtual DbSet<GL_INDIVIDUAL_PL_RPT> GL_INDIVIDUAL_PL_RPT { get; set; }
        //public virtual DbSet<GL_INTERFACE> GL_INTERFACE { get; set; }
        //public virtual DbSet<GL_MAST> GL_MAST { get; set; }
        //public virtual DbSet<GL_MATERIAL> GL_MATERIAL { get; set; }
        //public virtual DbSet<GL_MISCCODE> GL_MISCCODE { get; set; }
        //public virtual DbSet<GL_MISCTYPE> GL_MISCTYPE { get; set; }
        //public virtual DbSet<GL_PL_ACCOUNT> GL_PL_ACCOUNT { get; set; }
        //public virtual DbSet<GL_PL_COMPANY> GL_PL_COMPANY { get; set; }
        //public virtual DbSet<GL_PL_COMPANY_UNIT> GL_PL_COMPANY_UNIT { get; set; }
        //public virtual DbSet<GL_PL_ITEM> GL_PL_ITEM { get; set; }
        //public virtual DbSet<GL_PL_UNIT_INDIVIDUAL> GL_PL_UNIT_INDIVIDUAL { get; set; }
        //public virtual DbSet<GL_PROFIT_LOSS> GL_PROFIT_LOSS { get; set; }
        //public virtual DbSet<GL_PROFITS_LOSS> GL_PROFITS_LOSS { get; set; }
        //public virtual DbSet<GL_PSL_ACCOUNT> GL_PSL_ACCOUNT { get; set; }
        //public virtual DbSet<GL_PSL_ITEM> GL_PSL_ITEM { get; set; }
        //public virtual DbSet<GL_RATE> GL_RATE { get; set; }
        //public virtual DbSet<GL_RELATIONSHIP> GL_RELATIONSHIP { get; set; }
        //public virtual DbSet<GL_REPORT_COLUMNS> GL_REPORT_COLUMNS { get; set; }
        //public virtual DbSet<GL_STATE> GL_STATE { get; set; }
        //public virtual DbSet<GL_SYS> GL_SYS { get; set; }
        //public virtual DbSet<GL_TEAM> GL_TEAM { get; set; }
        //public virtual DbSet<GL_TITLE> GL_TITLE { get; set; }
        //public virtual DbSet<GL_TRL_EMPLOYEE_REPORT_DATA> GL_TRL_EMPLOYEE_REPORT_DATA { get; set; }
        //public virtual DbSet<GL_TRL_REPORT_DATA> GL_TRL_REPORT_DATA { get; set; }
        //public virtual DbSet<GL_TRS> GL_TRS { get; set; }
        //public virtual DbSet<GL_TRS_MORITORIUM> GL_TRS_MORITORIUM { get; set; }
        //public virtual DbSet<GL_TRS_PREPAYMENTS> GL_TRS_PREPAYMENTS { get; set; }
        //public virtual DbSet<GL_UNIT> GL_UNIT { get; set; }
        //public virtual DbSet<GL_UNIT_PL_RPT> GL_UNIT_PL_RPT { get; set; }
        //public virtual DbSet<GL_UNITS_INDIVIDUALS> GL_UNITS_INDIVIDUALS { get; set; }
        //public virtual DbSet<GLMAST> GLMASTs { get; set; }
        //public virtual DbSet<IMAGE_PROFILE> IMAGE_PROFILE { get; set; }
        //public virtual DbSet<INCENTIVE_FEE_SETUP> INCENTIVE_FEE_SETUP { get; set; }
        //public virtual DbSet<INDIVIDUAL_CONFIRM_LETTER> INDIVIDUAL_CONFIRM_LETTER { get; set; }
        //public virtual DbSet<INDUSTRy> INDUSTRIES { get; set; }
        //public virtual DbSet<INDUSTRY1> INDUSTRies1 { get; set; }
        //public virtual DbSet<INSTRUMENT_RECONCILER> INSTRUMENT_RECONCILER { get; set; }
        //public virtual DbSet<INSTRUMENT_TEMPLATE> INSTRUMENT_TEMPLATE { get; set; }
        //public virtual DbSet<INSTRUMENT_VALUATION_HISTORY> INSTRUMENT_VALUATION_HISTORY { get; set; }
        //public virtual DbSet<INSURER> INSURERS { get; set; }
        //public virtual DbSet<INVESTMENT_TYPE_LIMIT> INVESTMENT_TYPE_LIMIT { get; set; }
        //public virtual DbSet<INVESTOR_ACCT> INVESTOR_ACCT { get; set; }
        //public virtual DbSet<INVESTOR_TRANSACTIONS> INVESTOR_TRANSACTIONS { get; set; }
        //public virtual DbSet<INVESTOR> INVESTORS { get; set; }
        //public virtual DbSet<LAST_CONTRIBUTION> LAST_CONTRIBUTION { get; set; }
        //public virtual DbSet<LETTER_BY_COY_ALL> LETTER_BY_COY_ALL { get; set; }
        //public virtual DbSet<LETTER> LETTERS { get; set; }
        //public virtual DbSet<LGA> LGAs { get; set; }
        //public virtual DbSet<MISSING_MONTH> MISSING_MONTH { get; set; }
        //public virtual DbSet<MOBILE_CODES> MOBILE_CODES { get; set; }
        //public virtual DbSet<MONEY_MARKET_ACCT> MONEY_MARKET_ACCT { get; set; }
        //public virtual DbSet<MONEY_MARKET_SALES> MONEY_MARKET_SALES { get; set; }
        //public virtual DbSet<MULTIFUND_TRAN> MULTIFUND_TRAN { get; set; }
        //public virtual DbSet<NATIONALITY> NATIONALITies { get; set; }
        //public virtual DbSet<NEW_EXIT_BATCH> NEW_EXIT_BATCH { get; set; }
        //public virtual DbSet<NEWLY_FUNDED> NEWLY_FUNDED { get; set; }
        //public virtual DbSet<NEXT_OF_KIN> NEXT_OF_KIN { get; set; }
        //public virtual DbSet<NOTIF_LETTER_BY_COY> NOTIF_LETTER_BY_COY { get; set; }
        //public virtual DbSet<OCCUPATION> OCCUPATIONs { get; set; }
        //public virtual DbSet<PAYMENT> PAYMENTs { get; set; }
        //public virtual DbSet<PDF_REPORTS> PDF_REPORTS { get; set; }
        //public virtual DbSet<PENCOM_BATCH_TRAN> PENCOM_BATCH_TRAN { get; set; }
        //public virtual DbSet<PENCOM_DATA_BATCH> PENCOM_DATA_BATCH { get; set; }
        //public virtual DbSet<PenCom_EmployeesRD> PenCom_EmployeesRD { get; set; }
        //public virtual DbSet<PENCOM_RESPONSE> PENCOM_RESPONSE { get; set; }
        //public virtual DbSet<PERFORMANCE_BENCHMARK> PERFORMANCE_BENCHMARK { get; set; }
        //public virtual DbSet<PFA> PFAs { get; set; }
        //public virtual DbSet<PFA_PARAMETER> PFA_PARAMETER { get; set; }
        //public virtual DbSet<PFA_SCHEMES> PFA_SCHEMES { get; set; }
        //public virtual DbSet<PFC> PFCs { get; set; }
        //public virtual DbSet<PIN_BATCH> PIN_BATCH { get; set; }
        //public virtual DbSet<pin_fetch> pin_fetch { get; set; }
        //public virtual DbSet<pin_import_temp> pin_import_temp { get; set; }
        //public virtual DbSet<PIN_INVALID_BATCH> PIN_INVALID_BATCH { get; set; }
        //public virtual DbSet<PIN_INVALIDATE> PIN_INVALIDATE { get; set; }
        //public virtual DbSet<pin_niger> pin_niger { get; set; }
        //public virtual DbSet<pin_rpt> pin_rpt { get; set; }
        //public virtual DbSet<PIN_UPLOAD> PIN_UPLOAD { get; set; }
        //public virtual DbSet<PIN_UPLOAD_LOG> PIN_UPLOAD_LOG { get; set; }
        //public virtual DbSet<PINCHANGE_BATCH> PINCHANGE_BATCH { get; set; }
        //public virtual DbSet<PINCHANGE_TRANS> PINCHANGE_TRANS { get; set; }
        //public virtual DbSet<PRICE_HISTORY> PRICE_HISTORY { get; set; }
        //public virtual DbSet<PS_MMRATINGS> PS_MMRATINGS { get; set; }
        //public virtual DbSet<QUALIFICATION> QUALIFICATIONs { get; set; }
        //public virtual DbSet<R_BENEFITS> R_BENEFITS { get; set; }
        //public virtual DbSet<REAL_ESTATE> REAL_ESTATE { get; set; }
        //public virtual DbSet<REAL_ESTATE_ACCT> REAL_ESTATE_ACCT { get; set; }
        //public virtual DbSet<REGISTRATION> REGISTRATIONs { get; set; }
        //public virtual DbSet<REGISTRATION_BATCH> REGISTRATION_BATCH { get; set; }
        //public virtual DbSet<REGISTRATION_CFI> REGISTRATION_CFI { get; set; }
        //public virtual DbSet<REGISTRATION_INVESTORS> REGISTRATION_INVESTORS { get; set; }
        //public virtual DbSet<REGISTRATION_SELECTED> REGISTRATION_SELECTED { get; set; }
        //public virtual DbSet<REGISTRATION_TRANSFER> REGISTRATION_TRANSFER { get; set; }
        //public virtual DbSet<RegistrationDetail> RegistrationDetails { get; set; }
        //public virtual DbSet<REGNO_CONFIRM> REGNO_CONFIRM { get; set; }
        //public virtual DbSet<RELATIONSHIP> RELATIONSHIPS { get; set; }
        //public virtual DbSet<RETIREES_TRAIL> RETIREES_TRAIL { get; set; }
        //public virtual DbSet<RETIREMENT_SCHEDULE> RETIREMENT_SCHEDULE { get; set; }
        //public virtual DbSet<RMAS_SCHEME_ASSOCIATION> RMAS_SCHEME_ASSOCIATION { get; set; }
        //public virtual DbSet<RMAS_SUMMARY_REPORT> RMAS_SUMMARY_REPORT { get; set; }
        //public virtual DbSet<RMAS_UNFUNDED_EXCEPTION> RMAS_UNFUNDED_EXCEPTION { get; set; }
        //public virtual DbSet<RPT_EMPLOYEE_ACCOUNTS> RPT_EMPLOYEE_ACCOUNTS { get; set; }
        //public virtual DbSet<RPT_INVESTORS> RPT_INVESTORS { get; set; }
        //public virtual DbSet<RPT_STATEMENT> RPT_STATEMENT { get; set; }
        //public virtual DbSet<RPT_STATEMENT_ONLINE> RPT_STATEMENT_ONLINE { get; set; }
        //public virtual DbSet<RPT_WELCOME_LETTER> RPT_WELCOME_LETTER { get; set; }
        //public virtual DbSet<RSAXMLEXPORTFILE> RSAXMLEXPORTFILEs { get; set; }
        //public virtual DbSet<S_AUDIT> S_AUDIT { get; set; }
        //public virtual DbSet<S_GROUP> S_GROUP { get; set; }
        //public virtual DbSet<S_LOGIN> S_LOGIN { get; set; }
        //public virtual DbSet<S_MENU> S_MENU { get; set; }
        //public virtual DbSet<S_MENUOBJECT> S_MENUOBJECT { get; set; }
        //public virtual DbSet<S_PRIVILEGE> S_PRIVILEGE { get; set; }
        //public virtual DbSet<S_RESOURCE> S_RESOURCE { get; set; }
        //public virtual DbSet<S_RESOURCEGROUPS> S_RESOURCEGROUPS { get; set; }
        //public virtual DbSet<S_ROLE> S_ROLE { get; set; }
        //public virtual DbSet<S_ROLERESOURCE> S_ROLERESOURCE { get; set; }
        //public virtual DbSet<S_ROLETYPE> S_ROLETYPE { get; set; }
        //public virtual DbSet<S_SERVERDATE> S_SERVERDATE { get; set; }
        //public virtual DbSet<S_SYSPARAMETER> S_SYSPARAMETER { get; set; }
        //public virtual DbSet<S_USER> S_USER { get; set; }
        //public virtual DbSet<S_USER_TRAIL> S_USER_TRAIL { get; set; }
        //public virtual DbSet<S_USERLOG> S_USERLOG { get; set; }
        //public virtual DbSet<S_USERROLES> S_USERROLES { get; set; }
        //public virtual DbSet<S_WEBUSER> S_WEBUSER { get; set; }
        //public virtual DbSet<S_WORKGROUP> S_WORKGROUP { get; set; }
        //public virtual DbSet<SALARY_STRUCTURE> SALARY_STRUCTURE { get; set; }
        //public virtual DbSet<SCHEME_FUND> SCHEME_FUND { get; set; }
        //public virtual DbSet<SCHEME> SCHEMES { get; set; }
        //public virtual DbSet<SCHEMES_INTEREST_RATES> SCHEMES_INTEREST_RATES { get; set; }
        //public virtual DbSet<SCHEMES_SUMMARY> SCHEMES_SUMMARY { get; set; }
        //public virtual DbSet<SIGNATORY> SIGNATORies { get; set; }
        //public virtual DbSet<SMS_TEMPLATE> SMS_TEMPLATE { get; set; }
        //public virtual DbSet<STATE_FUNDED> STATE_FUNDED { get; set; }
        //public virtual DbSet<STATE_ZONE> STATE_ZONE { get; set; }
        //public virtual DbSet<STATEMENT_DETAIL> STATEMENT_DETAIL { get; set; }
        //public virtual DbSet<STATEMENT_PINS> STATEMENT_PINS { get; set; }
        //public virtual DbSet<STATEMENT_SUMMARY> STATEMENT_SUMMARY { get; set; }
        //public virtual DbSet<STATEMENT_SUMMARY_IND> STATEMENT_SUMMARY_IND { get; set; }
        //public virtual DbSet<STATE> STATES { get; set; }
        //public virtual DbSet<STATUS> STATUS { get; set; }
        //public virtual DbSet<STOCK_REVALUATION_ACCT> STOCK_REVALUATION_ACCT { get; set; }
        //public virtual DbSet<STOCK> STOCKS { get; set; }
        //public virtual DbSet<STOCKS_ACCT> STOCKS_ACCT { get; set; }
        //public virtual DbSet<TBILL_RATES> TBILL_RATES { get; set; }
        //public virtual DbSet<tbl_all_delta_mm> tbl_all_delta_mm { get; set; }
        //public virtual DbSet<tbl_appendix_c_report> tbl_appendix_c_report { get; set; }
        //public virtual DbSet<tbl_pencom_response_auto_upload> tbl_pencom_response_auto_upload { get; set; }
        //public virtual DbSet<tbl_pencom_response_upload_log> tbl_pencom_response_upload_log { get; set; }
        //public virtual DbSet<temp_25percent_rpt> temp_25percent_rpt { get; set; }
        //public virtual DbSet<temp_pin_import_deleteafter> temp_pin_import_deleteafter { get; set; }
        //public virtual DbSet<TICKET_CATEGORY> TICKET_CATEGORY { get; set; }
        //public virtual DbSet<TICKET_COMMENT> TICKET_COMMENT { get; set; }
        //public virtual DbSet<TICKET_SEVERITY> TICKET_SEVERITY { get; set; }
        //public virtual DbSet<TICKET_STATUS> TICKET_STATUS { get; set; }
        //public virtual DbSet<TICKET_TYPE> TICKET_TYPE { get; set; }
        //public virtual DbSet<TICKET> TICKETS { get; set; }
        //public virtual DbSet<TITLE> TITLEs { get; set; }
        //public virtual DbSet<TRANSFER> TRANSFERs { get; set; }
        //public virtual DbSet<TRANSFER_TRAN> TRANSFER_TRAN { get; set; }
        //public virtual DbSet<TRANSFER1> TRANSFERS1 { get; set; }
        //public virtual DbSet<TROI_TYPES> TROI_TYPES { get; set; }
        //public virtual DbSet<UNFUNDED_DATA> UNFUNDED_DATA { get; set; }
        //public virtual DbSet<UNFUNDED_DATA_LOG> UNFUNDED_DATA_LOG { get; set; }
        //public virtual DbSet<UNFUNDED_DATA_RMAS> UNFUNDED_DATA_RMAS { get; set; }
        //public virtual DbSet<UNFUNDED_RSA> UNFUNDED_RSA { get; set; }
        //public virtual DbSet<UNFUNDED_TEMPO> UNFUNDED_TEMPO { get; set; }
        //public virtual DbSet<UNFUNDED_YTD> UNFUNDED_YTD { get; set; }
        //public virtual DbSet<VALUATION_SUMMARY_REPORT> VALUATION_SUMMARY_REPORT { get; set; }
        //public virtual DbSet<WITHDRAWAL_MORTALITYRATE> WITHDRAWAL_MORTALITYRATE { get; set; }
        //public virtual DbSet<WITHDRAWAL_PROCESS> WITHDRAWAL_PROCESS { get; set; }
        //public virtual DbSet<XML_EMPLOYER_DETAILS> XML_EMPLOYER_DETAILS { get; set; }

        //public virtual DbSet<XML_TEMPLATE_SETTINGS> XML_TEMPLATE_SETTINGS { get; set; }
        //public virtual DbSet<ACCOUNT_RECEIVABLE> ACCOUNT_RECEIVABLE { get; set; }
        //public virtual DbSet<ADMIN_FEES_ACCT> ADMIN_FEES_ACCT { get; set; }
        //public virtual DbSet<ADMIN_FEES_TRANS> ADMIN_FEES_TRANS { get; set; }
        //public virtual DbSet<ADMIN_FEES_TRANS_REV> ADMIN_FEES_TRANS_REV { get; set; }
        //public virtual DbSet<ADMINFEES_SETUP_VALUES> ADMINFEES_SETUP_VALUES { get; set; }
        //public virtual DbSet<AUTHORISE_ALERT> AUTHORISE_ALERT { get; set; }
        //public virtual DbSet<auto_sms> auto_sms { get; set; }
        //public virtual DbSet<auto_sms_nophone> auto_sms_nophone { get; set; }
        //public virtual DbSet<auto_sms_pin> auto_sms_pin { get; set; }
        //public virtual DbSet<autosms2> autosms2 { get; set; }
        //public virtual DbSet<BATCH_BENEFICIARIES> BATCH_BENEFICIARIES { get; set; }
        //public virtual DbSet<BATCH_LOG> BATCH_LOG { get; set; }
        //public virtual DbSet<BATCH_PROFILE> BATCH_PROFILE { get; set; }
        //public virtual DbSet<BATCH_REGISTRATION> BATCH_REGISTRATION { get; set; }
        //public virtual DbSet<BENEFICIARy> BENEFICIARIES { get; set; }
        //public virtual DbSet<BOND_AJUSTMENTS> BOND_AJUSTMENTS { get; set; }
        //public virtual DbSet<BOND_PRICES> BOND_PRICES { get; set; }
        //public virtual DbSet<BOND_SALES> BOND_SALES { get; set; }
        //public virtual DbSet<BOND> BONDS { get; set; }
        //public virtual DbSet<BONDS_INTEREST_RATES> BONDS_INTEREST_RATES { get; set; }
        //public virtual DbSet<BONDS_TRANSFER> BONDS_TRANSFER { get; set; }
        //public virtual DbSet<BONU> BONUS { get; set; }
        //public virtual DbSet<BONUS_RECEIVED> BONUS_RECEIVED { get; set; }
        //public virtual DbSet<BROKERAGE_FEES> BROKERAGE_FEES { get; set; }
        //public virtual DbSet<BUSSINESS_GROUP> BUSSINESS_GROUP { get; set; }
        //public virtual DbSet<CA_JOURNAL_REPORTS> CA_JOURNAL_REPORTS { get; set; }
        //public virtual DbSet<CAJOURNAL_ACCT> CAJOURNAL_ACCT { get; set; }
        //public virtual DbSet<CAPITAL_MARKET> CAPITAL_MARKET { get; set; }
        //public virtual DbSet<CAPITAL_MARKET_TRANSFER> CAPITAL_MARKET_TRANSFER { get; set; }
        //public virtual DbSet<CLIENT_BALANCES> CLIENT_BALANCES { get; set; }
        //public virtual DbSet<CLIENT_NOTES> CLIENT_NOTES { get; set; }
        //public virtual DbSet<COMPANY> COMPANies { get; set; }
        //public virtual DbSet<COMPANY_RATING> COMPANY_RATING { get; set; }
        //public virtual DbSet<COMPANY_SCHEME_LIMIT> COMPANY_SCHEME_LIMIT { get; set; }
        //public virtual DbSet<CONSOLIDATED_STOCKS> CONSOLIDATED_STOCKS { get; set; }
        //public virtual DbSet<CONT_CONVERT> CONT_CONVERT { get; set; }
        //public virtual DbSet<CONT_DETAILS> CONT_DETAILS { get; set; }
        //public virtual DbSet<CONT_RECONCILLIATION> CONT_RECONCILLIATION { get; set; }
        //public virtual DbSet<CONTRIBUTION> CONTRIBUTIONs { get; set; }
        //public virtual DbSet<CONTRIBUTION_BATCH> CONTRIBUTION_BATCH { get; set; }
        //public virtual DbSet<CONTRIBUTION_INTEREST> CONTRIBUTION_INTEREST { get; set; }
        //public virtual DbSet<CONTRIBUTION_LAST_31_12_2018> CONTRIBUTION_LAST_31_12_2018 { get; set; }
        //public virtual DbSet<CONTRIBUTION_LOG> CONTRIBUTION_LOG { get; set; }
        //public virtual DbSet<CONTRIBUTION_REVERSE> CONTRIBUTION_REVERSE { get; set; }
        //public virtual DbSet<contribution_sms_fund3> contribution_sms_fund3 { get; set; }
        //public virtual DbSet<CONTRIBUTIONTMP> CONTRIBUTIONTMPs { get; set; }
        //public virtual DbSet<COUNTER_PARTY> COUNTER_PARTY { get; set; }
        //public virtual DbSet<currency> currencies { get; set; }
        //public virtual DbSet<DB_WITH_PROCESS> DB_WITH_PROCESS { get; set; }
        //public virtual DbSet<DIVIDEND> DIVIDENDs { get; set; }
        //public virtual DbSet<DIVIDEND_RECEIVED> DIVIDEND_RECEIVED { get; set; }
        //public virtual DbSet<DS_PENDING_JOB> DS_PENDING_JOB { get; set; }
        //public virtual DbSet<DS_USER_LIST> DS_USER_LIST { get; set; }
        //public virtual DbSet<EMPLOYEE_PIN> EMPLOYEE_PIN { get; set; }
        //public virtual DbSet<EMPLOYEE_STATUS> EMPLOYEE_STATUS { get; set; }
        //public virtual DbSet<EMPLOYEE_TRAIL> EMPLOYEE_TRAIL { get; set; }
        //public virtual DbSet<EMPLOYEES_ARCHIVE> EMPLOYEES_ARCHIVE { get; set; }
        //public virtual DbSet<EMPLOYEES_PENCOM_DATA> EMPLOYEES_PENCOM_DATA { get; set; }
        //public virtual DbSet<EMPLOYEES_RETIREES_PROFILE> EMPLOYEES_RETIREES_PROFILE { get; set; }
        //public virtual DbSet<EMPLOYER_NOTFUNDEDBYPENCOM> EMPLOYER_NOTFUNDEDBYPENCOM { get; set; }
        //public virtual DbSet<EMPLOYER_PRIVATE_RET> EMPLOYER_PRIVATE_RET { get; set; }
        //public virtual DbSet<EXIT_PROCESS_PAYMENT> EXIT_PROCESS_PAYMENT { get; set; }
        //public virtual DbSet<EXIT_PROCESS_PAYMENT_ERRORLOG> EXIT_PROCESS_PAYMENT_ERRORLOG { get; set; }
        //public virtual DbSet<FAIR_VALUE_HISTORY> FAIR_VALUE_HISTORY { get; set; }
        //public virtual DbSet<FEE_PERIODS> FEE_PERIODS { get; set; }
        //public virtual DbSet<FEE_SETUP_VALUES> FEE_SETUP_VALUES { get; set; }
        //public virtual DbSet<FEE_TRANSACTION> FEE_TRANSACTION { get; set; }
        //public virtual DbSet<fidelity_log> fidelity_log { get; set; }
        //public virtual DbSet<Fidelity_Login> Fidelity_Login { get; set; }
        //public virtual DbSet<fidelity_partial> fidelity_partial { get; set; }
        //public virtual DbSet<Fidelity_States> Fidelity_States { get; set; }
        //public virtual DbSet<FIDELITY_TCF_d66a2a9b> FIDELITY_TCF_d66a2a9b { get; set; }
        //public virtual DbSet<FIDELITY_TCF_dcaf21ce> FIDELITY_TCF_dcaf21ce { get; set; }
        //public virtual DbSet<FIDELITY_TCF_OLD> FIDELITY_TCF_OLD { get; set; }
        //public virtual DbSet<FidPen_EmployeesRD_Dec2016> FidPen_EmployeesRD_Dec2016 { get; set; }
        //public virtual DbSet<FORM_BATCH> FORM_BATCH { get; set; }
        //public virtual DbSet<FORM> FORMS { get; set; }
        //public virtual DbSet<fpml_staff_fidalert_test> fpml_staff_fidalert_test { get; set; }
        //public virtual DbSet<FUND_PERFORMANCE> FUND_PERFORMANCE { get; set; }
        //public virtual DbSet<GRADUATED_MGMT_FEES> GRADUATED_MGMT_FEES { get; set; }
        //public virtual DbSet<ID_TYPE> ID_TYPE { get; set; }
        //public virtual DbSet<INCENTIVE_FEES> INCENTIVE_FEES { get; set; }
        //public virtual DbSet<INSTR_CHARGE_SETUP_VALUES> INSTR_CHARGE_SETUP_VALUES { get; set; }
        //public virtual DbSet<INSTRUMENT> INSTRUMENTS { get; set; }
        //public virtual DbSet<INTEREST_RATES> INTEREST_RATES { get; set; }
        //public virtual DbSet<inv> invs { get; set; }
        //public virtual DbSet<INVESTMENT_RPT> INVESTMENT_RPT { get; set; }
        //public virtual DbSet<INVESTOR_BENEFICIARIES> INVESTOR_BENEFICIARIES { get; set; }
        //public virtual DbSet<MILITARY_EE_ER> MILITARY_EE_ER { get; set; }
        //public virtual DbSet<military_outstanding> military_outstanding { get; set; }
        //public virtual DbSet<MONEY_MARKET> MONEY_MARKET { get; set; }
        //public virtual DbSet<MONEY_MARKET_TRANSFER> MONEY_MARKET_TRANSFER { get; set; }
        //public virtual DbSet<NEW_EXIT_DETAILS> NEW_EXIT_DETAILS { get; set; }
        //public virtual DbSet<NEW_EXIT_ERRORLOG> NEW_EXIT_ERRORLOG { get; set; }
        //public virtual DbSet<NEW_EXIT_RETIREEDETAILS> NEW_EXIT_RETIREEDETAILS { get; set; }
        //public virtual DbSet<nigerstate> nigerstates { get; set; }
        //public virtual DbSet<PARTLY_FUNDED> PARTLY_FUNDED { get; set; }
        //public virtual DbSet<PARTLY_FUNDED_ER> PARTLY_FUNDED_ER { get; set; }

        //public virtual DbSet<pin_invalidation> pin_invalidation { get; set; }
        //public virtual DbSet<PINDELETE> PINDELETEs { get; set; }
        //public virtual DbSet<RE_TENANCY_AGREEMENTS> RE_TENANCY_AGREEMENTS { get; set; }
        //public virtual DbSet<RE_TENANCY_PAYMENTS> RE_TENANCY_PAYMENTS { get; set; }
        //public virtual DbSet<RE_TENANTS> RE_TENANTS { get; set; }
        //public virtual DbSet<REAL_ESTATE_MAINTENANCE> REAL_ESTATE_MAINTENANCE { get; set; }
        //public virtual DbSet<REMITTANCE> REMITTANCEs { get; set; }
        //public virtual DbSet<RENT> RENTs { get; set; }
        //public virtual DbSet<RENT_RECEIVED> RENT_RECEIVED { get; set; }
        //public virtual DbSet<REP_AGENTS> REP_AGENTS { get; set; }
        //public virtual DbSet<RPT_BALANCE> RPT_BALANCE { get; set; }
        //public virtual DbSet<RPT_NOTIFICATION_SMS> RPT_NOTIFICATION_SMS { get; set; }
        //public virtual DbSet<RPT_NOTIFICATION_SMS_LOG> RPT_NOTIFICATION_SMS_LOG { get; set; }
        //public virtual DbSet<RSA_SECTOR> RSA_SECTOR { get; set; }
        //public virtual DbSet<S_PASSWORDLOG> S_PASSWORDLOG { get; set; }
        //public virtual DbSet<S_POLICY> S_POLICY { get; set; }
        //public virtual DbSet<S_USER_FUNDS> S_USER_FUNDS { get; set; }
        //public virtual DbSet<S_WEBUSERLOG> S_WEBUSERLOG { get; set; }
        //public virtual DbSet<SCHEDULE_TRANSFER> SCHEDULE_TRANSFER { get; set; }
        //public virtual DbSet<SCHEDULE> SCHEDULES { get; set; }
        //public virtual DbSet<SCHEME_SETUP> SCHEME_SETUP { get; set; }
        //public virtual DbSet<STOCK_PRICES> STOCK_PRICES { get; set; }
        //public virtual DbSet<tbl_formRefNOTEMP> tbl_formRefNOTEMP { get; set; }
        //public virtual DbSet<tbl_pinxxx> tbl_pinxxx { get; set; }
        //public virtual DbSet<tbl_pre_multifund_units> tbl_pre_multifund_units { get; set; }
        //public virtual DbSet<tbl_tempsms> tbl_tempsms { get; set; }
        //public virtual DbSet<tbl_tempsms_03082017> tbl_tempsms_03082017 { get; set; }
        //public virtual DbSet<tbl_tempsms2> tbl_tempsms2 { get; set; }
        //public virtual DbSet<tbl_transitional_pin_result> tbl_transitional_pin_result { get; set; }
        //public virtual DbSet<TROI_COMPUTATION_HEADER> TROI_COMPUTATION_HEADER { get; set; }
        //public virtual DbSet<TROI_COMPUTATIONS> TROI_COMPUTATIONS { get; set; }
        //public virtual DbSet<TROI_GROWTHS> TROI_GROWTHS { get; set; }
        //public virtual DbSet<TROI_PERIODS> TROI_PERIODS { get; set; }
        //public virtual DbSet<Welcome> Welcomes { get; set; }
        //public virtual DbSet<WITHDRAWAL> WITHDRAWALs { get; set; }
        //public virtual DbSet<XML_EMPLOYER_DETAILS_RMAS> XML_EMPLOYER_DETAILS_RMAS { get; set; }
        //public virtual DbSet<YouTubeVideo> YouTubeVideos { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        //    modelBuilder.Entity<ACCOUNT_FLAG>()
        //        .Property(e => e.ACCT_FLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_FLAG>()
        //        .Property(e => e.FLAG_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_FLAG>()
        //        .Property(e => e.CREDIT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_FLAG>()
        //        .Property(e => e.DEBIT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_FLAG>()
        //        .Property(e => e.STMT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_FLAG>()
        //        .Property(e => e.TRANSFER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.CALC_COT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<ACCOUNT_TRANSACTION>()
        //        .Property(e => e.DB_PAYMENT_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<ADDRESS_TYPE>()
        //        .Property(e => e.CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADDRESS_TYPE>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_SETUP>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<ADMIN_FEES_SETUP>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_SETUP>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMINFEE_CATEGORY>()
        //        .Property(e => e.CATEGORY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMINFEE_CATEGORY>()
        //        .Property(e => e.CATEGORY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMINFEE_CATEGORY>()
        //        .Property(e => e.CATEGORY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMINFEE_CATEGORY>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<ADMINFEE_CATEGORY>()
        //        .Property(e => e.FEE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMINFEE_CATEGORY>()
        //        .Property(e => e.VAT_PERCENT)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<ADMINISTRATIVE_FEE>()
        //        .Property(e => e.FEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMINISTRATIVE_FEE>()
        //        .Property(e => e.AMOUNT)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<ADMINISTRATIVE_FEE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<ADMINISTRATIVE_FEE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.AGENT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AGENT>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AUTHORISERS_MENU>()
        //        .Property(e => e.MENU_OBJECT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AUTHORISERS_MENU>()
        //        .Property(e => e.MENU_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AUTHORISERS_MENU>()
        //        .Property(e => e.JOB_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<avc_email_push>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<avc_email_push>()
        //        .Property(e => e.firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<avc_email_push>()
        //        .Property(e => e.email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BANK_BRANCHES>()
        //        .Property(e => e.BANK_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BANK_BRANCHES>()
        //        .Property(e => e.SORTCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BANK_BRANCHES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BANK_BRANCHES>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BANK_BRANCHES>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BANK>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BANK>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BANK>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REG_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REG_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REG_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REG_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REG_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REG_BATCH>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.PASSPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.SIGNATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.SALARY_SCALE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.GRADE_LEVEL)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.STEP)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.POSTING_LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PRODUCT1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PERCENTAGE1)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PRODUCT2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PERCENTAGE2)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PRODUCT3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PERCENTAGE3)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PRODUCT4)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PERCENTAGE4)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PRODUCT5)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.INVEST_PERCENTAGE5)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.CORRESPONDENCE_ADDS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_CORRADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_CORRADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.BIOMETRICS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.PFA_TRANS_IN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.ACCT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.RSA_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.FORM_IMAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.BIOMETRICS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK_COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.EMPLOYEE_GROUP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.LOCATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.SAP_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.STAFF_GRADE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.REQ_BY_PENCOM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.UPLOAD_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_MAIDENNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_COUNTRYCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_MOBILEPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.NOK2_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.SQL_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION_ABBYY>()
        //        .Property(e => e.REGISTRATION_CODE1)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND_AMORTIZATION>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND_AMORTIZATION>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_AMORTIZATION>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND_AMORTIZATION>()
        //        .Property(e => e.PREMIUM_DISCOUNT)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<BOND_ISSUER>()
        //        .Property(e => e.ISSUER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_ISSUER>()
        //        .Property(e => e.PER_ISSUER_LIMIT)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<BOND_ISSUER>()
        //        .Property(e => e.ISSUER_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_ISSUER>()
        //        .Property(e => e.CORP_BOND_LIMIT)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<BONDS_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_ACCT>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.COMPANY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.REFERENCE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.OLD_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RECEIVED>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_PV>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_PV>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BRANCH>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BRANCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BRANCH>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BRANCH>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BROKER>()
        //        .Property(e => e.BROKERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BROKER>()
        //        .Property(e => e.BROKER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BROKER>()
        //        .Property(e => e.BROKER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BROKER>()
        //        .Property(e => e.BROKER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BROKER>()
        //        .Property(e => e.BROKER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BROKER>()
        //        .Property(e => e.BROKERAGE_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<BUSINESS_TYPES>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BUSINESS_TYPES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BUSINESS_UNITS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BUSINESS_UNITS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BUSINESS_UNITS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BUSINESS_UNITS>()
        //        .Property(e => e.GROUP_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.INTIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.PERFORMANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.OLD_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL>()
        //        .Property(e => e.AFFECT_CASH)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TEMPLATE>()
        //        .Property(e => e.TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TEMPLATE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TEMPLATE>()
        //        .Property(e => e.ROWID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CAJOURNAL_TEMPLATE>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.ROWID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.INCLUDE_REPORT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.DEBIT_ACCT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.CREDIT_ACCT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.INCLUDE_STATEMENT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.PERFORMANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_TYPES>()
        //        .Property(e => e.REG_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_ACCT>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_BATCH>()
        //        .Property(e => e.NARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_BATCH>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_TRANS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_TRANS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_STAT_PIN_TRANS>()
        //        .Property(e => e.CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY_SECTORS>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY_SECTORS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY_SECTORS>()
        //        .Property(e => e.SECTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTACT>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTACT>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTACT>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CONTRIBUTION_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_HISTORY>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_HISTORY>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_HISTORY>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_HISTORY>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_HISTORY>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_HISTORY>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.SNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.OTHER_FEE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.TRANS_UNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.TRANS_UNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.RETIREE_DEPOSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.OLD_PFACODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.TRANS_UNITS)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.SENT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.PID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.NARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.V_DATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_RAW>()
        //        .Property(e => e.T_DATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.ERROR_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.SURNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.FIRSTNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.EMPLOYERCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TRAN>()
        //        .Property(e => e.CORRECTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TYPES>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TYPES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_TYPES>()
        //        .Property(e => e.CLASS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_ISSUE_LOG>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CRM_ISSUE_LOG>()
        //        .Property(e => e.ISSUE_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CRM_ISSUE_LOG>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_ISSUE_TYPE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<CRM_ISSUE_TYPE>()
        //        .Property(e => e.ISSUE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_ISSUE_TYPE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_ISSUES>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CRM_ISSUES>()
        //        .Property(e => e.CLIENT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_ISSUES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_ISSUES>()
        //        .Property(e => e.SEVERITY_ID)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<CRM_ISSUES>()
        //        .Property(e => e.ISSUE_TYPE)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<CRM_ISSUES>()
        //        .Property(e => e.LOGGED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CRM_ISSUES>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_ISSUES>()
        //        .Property(e => e.FIXER)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CRM_NOTES>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CRM_NOTES>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CRM_NOTES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_NOTIFICATION>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CRM_NOTIFICATION>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_NOTIFICATION>()
        //        .Property(e => e.CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_RESOLUTION_TYPE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<CRM_RESOLUTION_TYPE>()
        //        .Property(e => e.RESOLUTION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_RESOLUTION_TYPE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_SEVERITY_CODES>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<CRM_SEVERITY_CODES>()
        //        .Property(e => e.SEVERITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CRM_SEVERITY_CODES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CURRENCY_FOREX_RATES>()
        //        .Property(e => e.PRIMARY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CURRENCY_FOREX_RATES>()
        //        .Property(e => e.SECONDARY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CURRENCY_FOREX_RATES>()
        //        .Property(e => e.RATE)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.SCHEME_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.REASON_RETIRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.CAUSE_OF_DEATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.LUMPSUM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.LSACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.LSACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.LSBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.ANNUITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.ANACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.ANACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.ANBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.PWITHDRAWAL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.PWACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.PWACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.PWBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.PWFREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCLUMPSUM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCLSACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCLSACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCLSBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCPWITHDRAWAL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCPWACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCPWACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCPWBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.VCPWFREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.EVIDENCE_ENCLOSED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.ERR_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.BENEFICIARY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.SERVICE_YEARS)
        //        .HasPrecision(6, 4);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.SERVICE_YR_INTR)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.GRATUITY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.GRATUITY_ACCT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.GRATUITY_ACCT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.GRATUITY_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.SYRS_RANG_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.SCHEME_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.REASON_RETIRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.CAUSE_OF_DEATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.LUMPSUM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.LSACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.LSACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.LSBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.ANNUITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.ANACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.ANACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.ANBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.PWITHDRAWAL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.PWACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.PWACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.PWBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.PWFREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCLUMPSUM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCLSACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCLSACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCLSBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCPWITHDRAWAL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCPWACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCPWACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCPWBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.VCPWFREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.EVIDENCE_ENCLOSED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.ERR_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.BENEFICIARY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.SERVICE_YR_INTR)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.GRATUITY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.GRATUITY_ACCT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.GRATUITY_ACCT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.GRATUITY_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.SYRS_RANG_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_EXIT_PROCESS_LOG>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.PAYMENT_MADE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.EXIT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.EXIT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.BENEFICIARY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.WITHDRAWAL_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.PAYMENT_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.GRATUITY_TAKEN)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_PAYMENT>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SCHEME_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PAYMENT_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.EVIDENCE_ENCLOSED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERMINATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERMINATED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PAYMENT_MADE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.REASON_RETIRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.WITHDRAWAL_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BENEFICIARY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERM_CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERM_CHECKED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.RATE_OF_GRAT)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.GRATUITY_FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PENSION_FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.GRATUITY_TAKEN)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SERVICE_YEARS)
        //        .HasPrecision(6, 4);

        //    modelBuilder.Entity<DB_WITHDRAWAL_PROCESS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<defaulting_emprs>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DEPARTMENT>()
        //        .Property(e => e.Code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DEPARTMENT>()
        //        .Property(e => e.Description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DESIGNATION>()
        //        .Property(e => e.Code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DESIGNATION>()
        //        .Property(e => e.Description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DOCUMENTATION_TRAIL>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DOCUMENTATION_TRAIL>()
        //        .Property(e => e.FIELD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DOCUMENTATION_TRAIL>()
        //        .Property(e => e.PREVIOUS_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DOCUMENTATION_TRAIL>()
        //        .Property(e => e.CURRRENT_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DOCUMENTATION_TRAIL>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DOCUMENTATION_TRAIL>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DOCUMENTATION_TRAIL>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DYNAMIC_REPORT>()
        //        .Property(e => e.SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DYNAMIC_REPORT>()
        //        .Property(e => e.SEQ_NO)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<DYNAMIC_REPORT>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DYNAMIC_REPORT>()
        //        .Property(e => e.CURRENT_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<DYNAMIC_REPORT>()
        //        .Property(e => e.TOTAL_SHARES)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DYNAMIC_REPORT>()
        //        .Property(e => e.APPR_TODATEP)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<EE_PFC_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EE_PFC_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EE_PFC_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.PFA_SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.PCENTAGE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.TOT_TRANSUNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.TOT_TRANSUNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.UNIT_PRICE_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.UNIT_PRICE_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.TRANSUNITS_R_BF)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.TRANSUNITS_V_BF)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<EMPLOYEE_BUFFER>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE_BUFFER>()
        //        .Property(e => e.SUSER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_BUFFER>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_BUFFER>()
        //        .Property(e => e.FIELD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_BUFFER>()
        //        .Property(e => e.OLD_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_BUFFER>()
        //        .Property(e => e.NEW_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_BUFFER>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SERIAL)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.CHECKED)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PASSPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SIGNATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PRINTED_BY)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PICTURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SIGNATURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SALARY_SCALE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.POSTING_LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PRODUCT1)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PRODUCT2)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PERCENTAGE2)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PRODUCT3)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PERCENTAGE3)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PRODUCT4)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PERCENTAGE4)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PRODUCT5)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PERCENTAGE5)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.INVEST_PERCENTAGE1)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.CORRESPONDENCE_ADDS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_CORRADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_CORRADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PFA_TRANS_IN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.ACCT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.RSA_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.FORM_IMAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.BIOMETRICS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PIN_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.ER_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.ER_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.BIOMETRICS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK_COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EE_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EE_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EE_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.ER_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.OLD_EMPLOYEEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYEE_GROUP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.LOCATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.SAP_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.STAFF_GRADE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.REQ_BY_PENCOM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.UPLOAD_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.GRATUITY_RATE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYEE_CATEGORY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PIN_INVALID1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PIN_NOTIFY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.APPROVED1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.FLAGNARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.FLAGDESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.TEAM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PERM_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.PERM_STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.ACCT_FLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_MAIDENNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_COUNTRYCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_MOBILEPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.NOK2_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.ER_ADDR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.FILE_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_ADDRESS_BK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMPLOYER_ADDRESS1_BK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.EMAIL_ONLY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.ADDRESS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.BRANCHADDRESS_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.LATEST_IMAGE_UPDATE)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.BVN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.MOTHER_MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ACTIVE_31_12_2018>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ACTIVE_31_12_2018>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ACTIVE_31_12_2018>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ACTIVE_31_12_2018>()
        //        .Property(e => e.MIDDLE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ACTIVE_31_12_2018>()
        //        .Property(e => e.GENDER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ACTIVE_31_12_2018>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ACTIVE_31_12_2018>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ACTIVE_31_12_2018>()
        //        .Property(e => e.SECTOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.FORM_REFNO)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.LGA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.CORRESPONDENCE_ADDS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.PROFESSION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_SURNAME1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_FIRSTNAME1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_OTHERNAME1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_RELATIONSHIP1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_CORRADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_MOBILE_PHONE1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_STATECODE1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_TITLE1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_GENDER1)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_CITY1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_EMAIL1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_SURNAME2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_FIRSTNAME2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_OTHERNAME2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_RELATIONSHIP2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_CORRADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_MOBILE_PHONE2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_STATECODE2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_TITLE2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_GENDER2)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_CITY2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.NOK_EMAIL2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.USERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.FULLNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEESzz>()
        //        .Property(e => e.STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.EMAIL_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.WEBSITE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.BUSINESS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.EMPLOYER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.ER_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.SECTOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.SUBSECTOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.RETIREMENT_AGE)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.EMAIL_ONLY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS>()
        //        .Property(e => e.Sequence_Identity)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EMPLOYER_DETAILS_LOG>()
        //        .Property(e => e.RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS_LOG>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS_LOG>()
        //        .Property(e => e.EMPLOYERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS_NORMALIZED>()
        //        .Property(e => e.CODES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS_NORMALIZED>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_DETAILS_NORMALIZED>()
        //        .Property(e => e.DUPLICATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ER_PFC_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ER_PFC_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ER_PFC_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.ACCOUNT_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.ACCOUNT_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.BANK_BRANCH)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.SORT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_ADD_PAYMENT>()
        //        .Property(e => e.REC_MONTHLY)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<EXIT_PROCESS_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_BATCH>()
        //        .Property(e => e.NARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_ERRORLOG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_ERRORLOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_ERRORLOG>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_ERRORLOG>()
        //        .Property(e => e.ERROR_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_ERRORLOG>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.MIN_LUMPSUM)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.ADMIN_CHARGE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.ADMINFEE_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.BATCHID_W)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.BATCHID_D)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.GENERATED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.ACCOUNT_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.ACCOUNT_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.PAY_YEARS)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.REC_MONTHLY)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.PAY_YEARS1)
        //        .HasPrecision(4, 2);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.BANK_BRANCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.RSABALANCEOLD)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.TRANS_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.INTERESTRATE)
        //        .HasPrecision(8, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.SORT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.RMAS_GENERATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.VOLUNTARY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.PAYMENTS_IN_ARREARS)
        //        .HasPrecision(18, 15);

        //    modelBuilder.Entity<EXIT_PROCESS_MASTER>()
        //        .Property(e => e.LOCKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_A_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_A_BATCH>()
        //        .Property(e => e.EXITFEE_BATCHID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_A_BATCH>()
        //        .Property(e => e.WITHDFEE_BATCHID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_A_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_BATCH>()
        //        .Property(e => e.NARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_TYPE>()
        //        .Property(e => e.CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_TYPE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.APP_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.EXIT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.SORTCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.SECTOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.ACCOUNTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.ACCOUNTNUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.BANK_BRANCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.RSA_BALANCE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.REG_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.FILE_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.INSURANCE_COMPANY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.ADMIN_LETTER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.BENEFICIARY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.INSURER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.SUSPEND)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.SUBMITTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.ACCRUED_RIGHT_ELIGIBLE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.ACCRUED_RIGHT_PAID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.SALARY_STRUCTURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_REGISTRATION>()
        //        .Property(e => e.FUNDING_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_STATUS>()
        //        .Property(e => e.APP_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_STATUS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_TYPE>()
        //        .Property(e => e.CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_TYPE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_TYPE>()
        //        .Property(e => e.RET_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_TYPE>()
        //        .Property(e => e.EXIT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.SCHEME_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.REASON_RETIRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.CAUSE_OF_DEATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.LUMPSUM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.LSACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.LSACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.LSBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.ANNUITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.ANACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.ANACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.ANBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.PWITHDRAWAL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.PWACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.PWACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.PWBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.PWFREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCLUMPSUM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCLSACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCLSACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCLSBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCPWITHDRAWAL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCPWACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCPWACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCPWBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.VCPWFREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.EVIDENCE_ENCLOSED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.ERR_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.BENEFICIARY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.SERVICE_YR_INTR)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.GRATUITY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.GRATUITY_ACCT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.GRATUITY_ACCT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.GRATUITY_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.SYRS_RANG_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS>()
        //        .Property(e => e.SERVICE_YEARS)
        //        .HasPrecision(6, 4);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.SCHEME_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.REASON_RETIRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.CAUSE_OF_DEATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.LUMPSUM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.LSACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.LSACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.LSBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.ANNUITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.ANACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.ANACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.ANBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.PWITHDRAWAL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.PWACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.PWACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.PWBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.PWFREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCLUMPSUM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCLSACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCLSACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCLSBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCPWITHDRAWAL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCPWACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCPWACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCPWBANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.VCPWFREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.EVIDENCE_ENCLOSED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.ERR_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.BENEFICIARY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.SERVICE_YR_INTR)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.GRATUITY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.GRATUITY_ACCT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.GRATUITY_ACCT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.GRATUITY_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.SYRS_RANG_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXITING_PROCESS_LOG>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEES_ACCT>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<FEES_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_DAILY>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEES_DAILY>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<FEES_DAILY>()
        //        .Property(e => e.FEE_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<FEES_DAILY>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_DAILY>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEES_SETUP>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEES_SETUP>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<FEES_SETUP>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_SETUP>()
        //        .Property(e => e.REG_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_SETUP>()
        //        .Property(e => e.REPORT_LINE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEES_SUMMARY>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEES_SUMMARY>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<FI_EXPOSURE_SUMMARY>()
        //        .Property(e => e.TYPE_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FI_EXPOSURE_SUMMARY>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FI_EXPOSURE_SUMMARY>()
        //        .Property(e => e.YIELD)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<FI_EXPOSURE_SUMMARY>()
        //        .Property(e => e.DECOMPOSITION)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.TFC_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.STAFF_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.PENCOM_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.UPLOAD_DATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.UPLOAD_MONTH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.UPLOAD_YEAR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.TOTAL_UNIT)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.PERIOD_COVERD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_SAVE_07_02_2019>()
        //        .Property(e => e.PFA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCIAL_ANALYSIS_UPDATE>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FIXED_INCOME_BLOTTER>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIXED_INCOME_BLOTTER>()
        //        .Property(e => e.COMPANY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FIXED_INCOME_BLOTTER>()
        //        .Property(e => e.DAYS_30)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<FIXED_INCOME_BLOTTER>()
        //        .Property(e => e.DAYS_60)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<FIXED_INCOME_BLOTTER>()
        //        .Property(e => e.DAYS_90)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<FIXED_INCOME_BLOTTER>()
        //        .Property(e => e.DAYS_180)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<FOREX>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FOREX>()
        //        .Property(e => e.CURRENCY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FOREX_RATES>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FOREX_RATES>()
        //        .Property(e => e.CURRENT_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<FORM_REF_DUP>()
        //        .Property(e => e.FORM_REF_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FORM_REF_DUP>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM_REF_TEMP>()
        //        .Property(e => e.FORM_REF_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FORM_REF_TEMP>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_3_import>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_3_import>()
        //        .Property(e => e.fullname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_3_import>()
        //        .Property(e => e.client_status)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_3_import>()
        //        .Property(e => e.date_of_birth)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_3_import>()
        //        .Property(e => e.mandatory)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_3_import>()
        //        .Property(e => e.voluntary)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_3_import>()
        //        .Property(e => e.mandatory_units)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_3_import>()
        //        .Property(e => e.voluntary_units)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_ii_import>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_ii_import>()
        //        .Property(e => e.fullname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_ii_import>()
        //        .Property(e => e.client_status)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_ii_import>()
        //        .Property(e => e.date_of_birth)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_ii_import>()
        //        .Property(e => e.mandatory)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_ii_import>()
        //        .Property(e => e.voluntary)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_ii_import>()
        //        .Property(e => e.mandatory_units)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_ii_import>()
        //        .Property(e => e.voluntary_units)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_iii_import>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_iii_import>()
        //        .Property(e => e.fullname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_iii_import>()
        //        .Property(e => e.client_status)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_iii_import>()
        //        .Property(e => e.date_of_birth)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fund_iii_import>()
        //        .Property(e => e.mandatory)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_iii_import>()
        //        .Property(e => e.voluntary)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_iii_import>()
        //        .Property(e => e.mandatory_units)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fund_iii_import>()
        //        .Property(e => e.voluntary_units)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
        //        .Property(e => e.FUND_PERCENTAGE)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
        //        .Property(e => e.RETURN_ON_INSTRUMENT)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<FUND_PERFORMANCE_REPORT>()
        //        .Property(e => e.BENCHMARK)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<FUNDED_DATA_LOG>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_DATA_LOG>()
        //        .Property(e => e.EMPLOYEE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_DATA_LOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_DATA_LOG>()
        //        .Property(e => e.AMOUNT)
        //        .HasPrecision(19, 2);

        //    modelBuilder.Entity<FUNDED_DATA_LOG>()
        //        .Property(e => e.REMARKS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_DATA_RMAS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FUNDED_DATA_RMAS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_DATA_RMAS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_DATA_RMAS>()
        //        .Property(e => e.SOURCE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_DATA_RMAS>()
        //        .Property(e => e.REMARKS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_PERIODIC>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_PERIODIC>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_PERIODIC>()
        //        .Property(e => e.EMPLOYEE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_PERIODIC>()
        //        .Property(e => e.EMPLOYER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_PERIODIC>()
        //        .Property(e => e.CATEGORY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_PERIODIC>()
        //        .Property(e => e.PERIOD)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_PERIODIC>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_PINS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FUNDED_PINS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_RSA>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_RSA>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_RSA>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_RSA>()
        //        .Property(e => e.SECTOR)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_YTD>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_YTD>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_YTD>()
        //        .Property(e => e.EMPLOYEE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_YTD>()
        //        .Property(e => e.EMPLOYER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_YTD>()
        //        .Property(e => e.CATEGORY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_YTD>()
        //        .Property(e => e.PERIOD)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDED_YTD>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDMANAGER_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDMANAGER_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FUNDMANAGER_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDMANAGER_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDMANAGER_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FUNDMANAGER_TRAN>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDMANAGER_TRAN>()
        //        .Property(e => e.NEW_BATCHNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUNDMANAGER_TRAN>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<GL_ACCOUNT_TEMPLATE_MEMBERS>()
        //        .Property(e => e.template_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCOUNT_TEMPLATE_MEMBERS>()
        //        .Property(e => e.acct_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCOUNT_TEMPLATE_MEMBERS>()
        //        .Property(e => e.description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCOUNT_TEMPLATE_MEMBERS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCOUNT_TEMPLATES>()
        //        .Property(e => e.template_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCOUNT_TEMPLATES>()
        //        .Property(e => e.template_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCOUNT_TEMPLATES>()
        //        .Property(e => e.description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCOUNT_TEMPLATES>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCT_ANALYSIS>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_ACCT_ANALYSIS>()
        //        .Property(e => e.period)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTO>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTO>()
        //        .Property(e => e.auto_desc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTO>()
        //        .Property(e => e._ref)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTO>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTO>()
        //        .Property(e => e.seq)
        //        .HasPrecision(2, 0);

        //    modelBuilder.Entity<GL_AUTO>()
        //        .Property(e => e.auto_expr)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTO>()
        //        .Property(e => e.group_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTOGROUP>()
        //        .Property(e => e.group_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTOGROUP>()
        //        .Property(e => e.group_desc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTOGROUP>()
        //        .Property(e => e.posting_period)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTOGROUP>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTOGROUP>()
        //        .Property(e => e.short_desc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_AUTOGROUP>()
        //        .Property(e => e.currency)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAL_CHANGE_DATA>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAL_CHANGE_DATA>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.balsht_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.balsht_note)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.period_string)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.pl_acct)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.prepayments)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.acruals)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.bank)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.overdraft)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.balsht_type)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALANCE_SHEET>()
        //        .Property(e => e.BALSHT_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ACCOUNT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ACCOUNT>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ACCOUNT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ACCOUNT>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.item_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.item_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.item_group)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.item_seq)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.balsht_group)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.fontstyle)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.effects)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.item_position)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.as_li)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BALSHT_ITEM>()
        //        .Property(e => e.ITEM_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.OPERATOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.REC_COUNT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.POSTED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.LOCKED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT>()
        //        .Property(e => e.POSTED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.DEPT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.TRS_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.TRS_REF)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.PREV_PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.TRS_SYSTEM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.TRS_PRT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.TRS_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.LOCKED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.SEQ)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.EMPLOYEE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BAT_TRS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.faccno)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.fdept)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.ftype)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.unit_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.employee_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.foption)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.seq)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.perc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period1)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period2)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period3)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period4)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period5)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period6)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period7)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period8)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period9)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period10)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period11)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_BUDGET>()
        //        .Property(e => e.period12)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_CASH_FLOW>()
        //        .Property(e => e.cf_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOW>()
        //        .Property(e => e.cf_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOW>()
        //        .Property(e => e.cf_note)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOW>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOW>()
        //        .Property(e => e.period_string)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOW>()
        //        .Property(e => e.period_string1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.balsht_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.balsht_note)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.period_string)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.pl_acct)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.prepayments)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.acruals)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.bank)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CASH_FLOWS>()
        //        .Property(e => e.overdraft)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CATEGORY>()
        //        .Property(e => e.account_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CATEGORY>()
        //        .Property(e => e.category_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CATEGORY>()
        //        .Property(e => e.category_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CATEGORY>()
        //        .Property(e => e.account_from)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CATEGORY>()
        //        .Property(e => e.account_to)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CATEGORY>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ACCOUNT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ACCOUNT>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ACCOUNT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ACCOUNT>()
        //        .Property(e => e.cf_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.item_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.item_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.item_group)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.item_seq)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.cf_group)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.cf_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.fontstyle)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CF_ITEM>()
        //        .Property(e => e.effects)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENT_ACCTS>()
        //        .Property(e => e.client_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENT_ACCTS>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENT_ACCTS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENT_ACCTS>()
        //        .Property(e => e.proccessed)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENT_STATEMENT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENT_STATEMENT>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENT_STATEMENT>()
        //        .Property(e => e.client_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENT_STATEMENT>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENTS>()
        //        .Property(e => e.client_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENTS>()
        //        .Property(e => e.description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENTS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CLIENTS>()
        //        .Property(e => e.processed)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.COMPANY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.CORPORATE_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PROFILE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.EMPLOYEE_SIZE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.RC_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.TELEPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.E_MAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.DATA_PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR01)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR02)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR03)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR04)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR05)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR06)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR07)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR08)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR09)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR10)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR11)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.PRDSTR12)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_PL_RPT>()
        //        .Property(e => e.seq)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_PL_RPT>()
        //        .Property(e => e.glevel)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_PL_RPT>()
        //        .Property(e => e.status)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_PL_RPT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_PL_RPT>()
        //        .Property(e => e.tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_PL_RPT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_UNITS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_UNITS>()
        //        .Property(e => e.unit_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_UNITS>()
        //        .Property(e => e.account_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COMPANY_UNITS>()
        //        .Property(e => e.p_flag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COUNTRY>()
        //        .Property(e => e.country_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COUNTRY>()
        //        .Property(e => e.country_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_COUNTRY>()
        //        .Property(e => e.continent_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ACCOUNT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ACCOUNT>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ACCOUNT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ACCOUNT>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.item_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.item_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.item_group)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.item_seq)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.balsht_group)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.fontstyle)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.effects)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CSH_ITEM>()
        //        .Property(e => e.item_position)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CURRENCY>()
        //        .Property(e => e.currency_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CURRENCY>()
        //        .Property(e => e.currency_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CURRENCY>()
        //        .Property(e => e.selected)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_CURRENCY>()
        //        .Property(e => e.exchange_rate)
        //        .HasPrecision(12, 2);

        //    modelBuilder.Entity<GL_DEPARTMENT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DEPARTMENT>()
        //        .Property(e => e.department_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DEPARTMENT>()
        //        .Property(e => e.department_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DEPARTMENT>()
        //        .Property(e => e.department_head_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DISTRIBUTION>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DISTRIBUTION>()
        //        .Property(e => e.header_acct)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DISTRIBUTION>()
        //        .Property(e => e.acct_from)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DISTRIBUTION>()
        //        .Property(e => e.acct_to)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DISTRIBUTION>()
        //        .Property(e => e.percentage)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_DISTRIBUTION>()
        //        .Property(e => e.seq)
        //        .HasPrecision(2, 0);

        //    modelBuilder.Entity<GL_DIVISION>()
        //        .Property(e => e.divnum)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_DIVISION>()
        //        .Property(e => e.divname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_DIVISION>()
        //        .Property(e => e.divaddr)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.MIDNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.SEX)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.MSTATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.DEPT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.CATEGORY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.BIRTH_PLACE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.COUNTRY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.STATE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.LGA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.NOK1_SNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.NOK1_FNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.NOK1_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.NOK2_SNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.NOK2_FNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.NOK2_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.POST_HELD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.UNIT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.STREET)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_EMPLOYEE>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INDIVIDUAL_PL_RPT>()
        //        .Property(e => e.seq)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INDIVIDUAL_PL_RPT>()
        //        .Property(e => e.glevel)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INDIVIDUAL_PL_RPT>()
        //        .Property(e => e.status)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INDIVIDUAL_PL_RPT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INDIVIDUAL_PL_RPT>()
        //        .Property(e => e.tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INTERFACE>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INTERFACE>()
        //        .Property(e => e.GL_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INTERFACE>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INTERFACE>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_INTERFACE>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.acct_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.dept_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.acc_desc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.status)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.glevel)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.budget)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.distrib)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.locked)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.unit_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.employee_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.seq)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.acct_group)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MAST>()
        //        .Property(e => e.processed)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MATERIAL>()
        //        .Property(e => e.matnum)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_MATERIAL>()
        //        .Property(e => e.matname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MATERIAL>()
        //        .Property(e => e.mattype)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MISCCODE>()
        //        .Property(e => e.misc_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MISCCODE>()
        //        .Property(e => e.misc_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MISCCODE>()
        //        .Property(e => e.misctype_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MISCTYPE>()
        //        .Property(e => e.misctype_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_MISCTYPE>()
        //        .Property(e => e.misctype_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ACCOUNT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ACCOUNT>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ACCOUNT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ACCOUNT>()
        //        .Property(e => e.pl_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_COMPANY>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_COMPANY>()
        //        .Property(e => e.pl_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_COMPANY_UNIT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_COMPANY_UNIT>()
        //        .Property(e => e.dept)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_COMPANY_UNIT>()
        //        .Property(e => e.pl_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.item_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.item_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.item_group)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.item_seq)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.pl_group)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.pl_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.fontstyle)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_ITEM>()
        //        .Property(e => e.effects)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_UNIT_INDIVIDUAL>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_UNIT_INDIVIDUAL>()
        //        .Property(e => e.unit)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_UNIT_INDIVIDUAL>()
        //        .Property(e => e.individual)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PL_UNIT_INDIVIDUAL>()
        //        .Property(e => e.pl_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFIT_LOSS>()
        //        .Property(e => e.pl_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFIT_LOSS>()
        //        .Property(e => e.pl_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFIT_LOSS>()
        //        .Property(e => e.pl_note)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFIT_LOSS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFIT_LOSS>()
        //        .Property(e => e.period_string)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFIT_LOSS>()
        //        .Property(e => e.period_string1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.balsht_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.balsht_note)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.period_string)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.pl_acct)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.prepayments)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.acruals)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.bank)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.overdraft)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.spl_pl)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.departmental_pl)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.dept1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.dept1_perc)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.dept2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.dept2_perc)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.dept3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.dept3_perc)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.rep_title)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.prior_months)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.prior_year_months)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col01)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col02)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col03)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col04)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col05)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col06)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col07)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col08)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col09)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col10)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col11)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col12)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.col_heading)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PROFITS_LOSS>()
        //        .Property(e => e.balsht_type)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ACCOUNT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ACCOUNT>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ACCOUNT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ACCOUNT>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.item_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.item_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.item_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.item_group)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.item_seq)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.balsht_group)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.balsht_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.fontstyle)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.effects)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.item_position)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.ic_exp)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_PSL_ITEM>()
        //        .Property(e => e.ITEM_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_RATE>()
        //        .Property(e => e.currency_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_RELATIONSHIP>()
        //        .Property(e => e.relationship_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_RELATIONSHIP>()
        //        .Property(e => e.relationship_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_REPORT_COLUMNS>()
        //        .Property(e => e.report_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_REPORT_COLUMNS>()
        //        .Property(e => e.report_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_REPORT_COLUMNS>()
        //        .Property(e => e.col_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_REPORT_COLUMNS>()
        //        .Property(e => e.col_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_REPORT_COLUMNS>()
        //        .Property(e => e.col_heading)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_REPORT_COLUMNS>()
        //        .Property(e => e.formula)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_REPORT_COLUMNS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_REPORT_COLUMNS>()
        //        .Property(e => e.use_formula)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_STATE>()
        //        .Property(e => e.state_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_STATE>()
        //        .Property(e => e.state_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_STATE>()
        //        .Property(e => e.country_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.CURRENT_PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.NEXT_PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.NEXT_BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.DEFAULT_CURRENCY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.DEFAULT_PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.SUPRESS_ZEROES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.UNIT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.INDIVIDUAL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD1)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD2)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD3)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD4)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD5)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD6)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD7)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD8)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD9)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD10)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD11)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_SYS>()
        //        .Property(e => e.PERIOD12)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<GL_TEAM>()
        //        .Property(e => e.teanum)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<GL_TEAM>()
        //        .Property(e => e.teaspe)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TITLE>()
        //        .Property(e => e.title_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TITLE>()
        //        .Property(e => e.title_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRL_EMPLOYEE_REPORT_DATA>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRL_EMPLOYEE_REPORT_DATA>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRL_REPORT_DATA>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRL_REPORT_DATA>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.DEPT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.TRS_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.TRS_REF)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.PREV_PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.TRS_SYSTEM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.TRS_PRT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.TRS_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.LOCKED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.SEQ)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.EMPLOYEE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.EXCHANGE_RATE)
        //        .HasPrecision(12, 2);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.PROCESSED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.acct_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.dept_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.trs_desc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.trs_ref)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.period)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.prev_period)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.batch_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.trs_system)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.trs_prt)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.trs_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.locked)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.seq)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.unit_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.employee_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.currency_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.exchange_rate)
        //        .HasPrecision(12, 2);

        //    modelBuilder.Entity<GL_TRS_MORITORIUM>()
        //        .Property(e => e.moacct_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.DEPT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.TRS_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.TRS_REF)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.PREV_PERIOD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.TRS_SYSTEM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.TRS_PRT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.TRS_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.LOCKED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.SEQ)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.EMPLOYEE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_TRS_PREPAYMENTS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT>()
        //        .Property(e => e.department_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT>()
        //        .Property(e => e.unit_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT>()
        //        .Property(e => e.unit_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT>()
        //        .Property(e => e.unit_head_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT_PL_RPT>()
        //        .Property(e => e.seq)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT_PL_RPT>()
        //        .Property(e => e.glevel)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT_PL_RPT>()
        //        .Property(e => e.status)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT_PL_RPT>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNIT_PL_RPT>()
        //        .Property(e => e.tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNITS_INDIVIDUALS>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNITS_INDIVIDUALS>()
        //        .Property(e => e.unit_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNITS_INDIVIDUALS>()
        //        .Property(e => e.individual_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNITS_INDIVIDUALS>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GL_UNITS_INDIVIDUALS>()
        //        .Property(e => e.p_flag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GLMAST>()
        //        .Property(e => e.acct_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GLMAST>()
        //        .Property(e => e.company_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GLMAST>()
        //        .Property(e => e.period_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GLMAST>()
        //        .Property(e => e.amount)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<GLMAST>()
        //        .Property(e => e.dept_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<IMAGE_PROFILE>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<IMAGE_PROFILE>()
        //        .Property(e => e.FILENAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<IMAGE_PROFILE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<IMAGE_PROFILE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<IMAGE_PROFILE>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INCENTIVE_FEE_SETUP>()
        //        .Property(e => e.SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INCENTIVE_FEE_SETUP>()
        //        .Property(e => e.BASE_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<INCENTIVE_FEE_SETUP>()
        //        .Property(e => e.PERC_EXPECTED)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDIVIDUAL_CONFIRM_LETTER>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDUSTRy>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDUSTRy>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDUSTRY1>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INDUSTRY1>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_RECONCILER>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INSTRUMENT_RECONCILER>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_RECONCILER>()
        //        .Property(e => e.INSTRUMENT_ELEMENT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_RECONCILER>()
        //        .Property(e => e.ACCOUNT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.TEMPLATE_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.INSTRUMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.MONEY_MARKET_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.INSTITUTION_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.FED_OR_STATE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.DEFAULT_INCLUDE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.HAS_CHARGES)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.INTEREST_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_TEMPLATE>()
        //        .Property(e => e.REG_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT_VALUATION_HISTORY>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INSTRUMENT_VALUATION_HISTORY>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSURER>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INSURER>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSURER>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSURER>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSURER>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSURER>()
        //        .Property(e => e.STATE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSURER>()
        //        .Property(e => e.ACCOUNT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSURER>()
        //        .Property(e => e.BANK_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTMENT_TYPE_LIMIT>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<INVESTMENT_TYPE_LIMIT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INVESTMENT_TYPE_LIMIT>()
        //        .Property(e => e.CAPITAL_MARKET)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<INVESTMENT_TYPE_LIMIT>()
        //        .Property(e => e.MONEY_MARKET)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<INVESTMENT_TYPE_LIMIT>()
        //        .Property(e => e.BONDS)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<INVESTOR_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INVESTOR_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_ACCT>()
        //        .Property(e => e.EMPLOYER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.OFFER_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.BID_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.TRANS_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.SALES_PERCENT)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.REP_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.TRANS_STAT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.UPLOADED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.CERTIFICATE_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.FLAGGED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.CERTIFICATE_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.FLAG_NARATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.INVESTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.PFA_SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INVESTOR_TRANSACTIONS>()
        //        .Property(e => e.SBATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INVESTOR>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INVESTOR>()
        //        .Property(e => e.CONTRIBUTION_PERCENT)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<INVESTOR>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<INVESTOR>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<INVESTOR>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<INVESTOR>()
        //        .Property(e => e.INVESTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LAST_CONTRIBUTION>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LAST_CONTRIBUTION>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LAST_CONTRIBUTION>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LAST_CONTRIBUTION>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LAST_CONTRIBUTION>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LAST_CONTRIBUTION>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER_BY_COY_ALL>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER_BY_COY_ALL>()
        //        .Property(e => e.EMPLOYER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER_BY_COY_ALL>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(8, 0);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.LETTER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.LETTER_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.HEADING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.CONTENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.RECEPIENT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.SIGNATORY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.REFERANCE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LETTER>()
        //        .Property(e => e.SNO)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<LGA>()
        //        .Property(e => e.STATE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LGA>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LGA>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LGA>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.JAN)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.FEB)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.MAR)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.APR)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.MAY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.JUN)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.JUL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.AUG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.SEP)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.OCT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.NOV)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.DEC)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MISSING_MONTH>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MOBILE_CODES>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_ACCT>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.REFERENCE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.TENOR)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.REMAIN_TENOR)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.ORIGINAL_RATE)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_SALES>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.SOURCE_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.TARGET_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.TRANS_UNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.TRANS_UNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.SOURCE_SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.SOURCE_FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.TARGET_SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.TARGET_FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MULTIFUND_TRAN>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<NATIONALITY>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NATIONALITY>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<NEW_EXIT_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<NEWLY_FUNDED>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEWLY_FUNDED>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEWLY_FUNDED>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEWLY_FUNDED>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.GENDER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.ADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.EMAIL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEXT_OF_KIN>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<NOTIF_LETTER_BY_COY>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NOTIF_LETTER_BY_COY>()
        //        .Property(e => e.EMPLOYER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NOTIF_LETTER_BY_COY>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(8, 0);

        //    modelBuilder.Entity<OCCUPATION>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<OCCUPATION>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.BENEFICIARY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.PAYMENT_MADE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.EXIT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.EXIT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.WITHDRAWAL_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.PAYMENT_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.GRATUITY_TAKEN)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PAYMENT>()
        //        .Property(e => e.SCHEME_CODE)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PDF_REPORTS>()
        //        .Property(e => e.OBJECT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PDF_REPORTS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PDF_REPORTS>()
        //        .Property(e => e.NO_DAYS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<PDF_REPORTS>()
        //        .Property(e => e.REPORT_ORDER)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<PENCOM_BATCH_TRAN>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_BATCH_TRAN>()
        //        .Property(e => e.REG_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_BATCH_TRAN>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<PENCOM_DATA_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_DATA_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PENCOM_DATA_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.s_no)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.title)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.lastname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.othernames)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.sex)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.dob)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.dofa)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.employer_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.lga)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.state_of_origin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PenCom_EmployeesRD>()
        //        .Property(e => e.reg_date)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .Property(e => e.FORM_REF_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .Property(e => e.RESPONSE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .Property(e => e.EXPORTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .HasMany(e => e.tbl_pencom_response_auto_upload)
        //        .WithOptional(e => e.PENCOM_RESPONSE)
        //        .HasForeignKey(e => e.initiating_id);

        //    modelBuilder.Entity<PENCOM_RESPONSE>()
        //        .HasMany(e => e.tbl_pencom_response_upload_log)
        //        .WithOptional(e => e.PENCOM_RESPONSE)
        //        .HasForeignKey(e => e.initiating_id);

        //    modelBuilder.Entity<PERFORMANCE_BENCHMARK>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PERFORMANCE_BENCHMARK>()
        //        .Property(e => e.TARGET)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<PERFORMANCE_BENCHMARK>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PERFORMANCE_BENCHMARK>()
        //        .Property(e => e.TROI_RETURN_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.PFA_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.PFA_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.PFA_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.PFA_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.PFA_LOGO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.CONTACT_PERSON)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.CONTACT_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.CONTACT_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA>()
        //        .Property(e => e.WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA_PARAMETER>()
        //        .Property(e => e.PENTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA_PARAMETER>()
        //        .Property(e => e.PVALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA_PARAMETER>()
        //        .Property(e => e.PCOMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA_SCHEMES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFA_SCHEMES>()
        //        .Property(e => e.SCHEME_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA_SCHEMES>()
        //        .Property(e => e.SCHEME_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA_SCHEMES>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFA_SCHEMES>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.PFC_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.PFC_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.PFC_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.PFC_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.PFC_LOGO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.CONTACT_PERSON)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.CONTACT_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.CONTACT_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.ACCOUNT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFC>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PIN_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<pin_fetch>()
        //        .Property(e => e.id)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<pin_fetch>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALID_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALID_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PIN_INVALID_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALID_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALID_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PIN_INVALID_BATCH>()
        //        .Property(e => e.NARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALIDATE>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALIDATE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALIDATE>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALIDATE>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_INVALIDATE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PIN_INVALIDATE>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_niger>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_rpt>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD>()
        //        .Property(e => e.EMPLOYEE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<PIN_UPLOAD_LOG>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD_LOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD_LOG>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD_LOG>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<PIN_UPLOAD_LOG>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PIN_UPLOAD_LOG>()
        //        .Property(e => e.CODE)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PINCHANGE_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINCHANGE_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PINCHANGE_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINCHANGE_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINCHANGE_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PINCHANGE_BATCH>()
        //        .Property(e => e.NARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINCHANGE_BATCH>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<PINCHANGE_TRANS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINCHANGE_TRANS>()
        //        .Property(e => e.OLDPIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINCHANGE_TRANS>()
        //        .Property(e => e.NEWPIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINCHANGE_TRANS>()
        //        .Property(e => e.CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PRICE_HISTORY>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PRICE_HISTORY>()
        //        .Property(e => e.BID_PRICE_BF)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<PRICE_HISTORY>()
        //        .Property(e => e.OFFER_PRICE_BF)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<PRICE_HISTORY>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<PRICE_HISTORY>()
        //        .Property(e => e.BID_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<PRICE_HISTORY>()
        //        .Property(e => e.OFFER_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<PRICE_HISTORY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PRICE_HISTORY>()
        //        .Property(e => e.PRICE_MOVEMENT)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.SCHEME_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.AAA)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.AA)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.A)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.DH_B3)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.MMARKET_LIMIT)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.CUSTODIAN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.RATING_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PS_MMRATINGS>()
        //        .Property(e => e.BBB)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<QUALIFICATION>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<QUALIFICATION>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.DOC1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.DOC2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.DOC3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.DOC4)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.DOC5)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<R_BENEFITS>()
        //        .Property(e => e.PAID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.PROPERTY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.PROPERTY_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.PROPERTY_LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REAL_ESTATE>()
        //        .Property(e => e.COMPLETED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REAL_ESTATE_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PASSPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SIGNATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PRINTED_BY)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PICTURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SIGNATURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SALARY_SCALE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.GRADE_LEVEL)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.STEP)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.POSTING_LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT1)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE1)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT2)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE2)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT3)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE3)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT4)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE4)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT5)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE5)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.CORRESPONDENCE_ADDS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_CORRADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_CORRADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PFA_TRANS_IN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.ACCT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.RSA_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.BIOMETRICS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.FORM_IMAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SERIAL)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PIN_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.ER_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.ER_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.BIOMETRICS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK_COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EMPLOYEE_GROUP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.LOCATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.SAP_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.STAFF_GRADE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EE_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.ER_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.OLD_EMPLOYEEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EE_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.EE_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.REQ_BY_PENCOM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.UPLOAD_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PERM_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.PERM_STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_MAIDENNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_COUNTRYCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_MOBILEPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.NOK2_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.ACCT_FLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.ADDRESS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.BRANCHADDRESS_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.BVN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION>()
        //        .Property(e => e.MOTHER_MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PASSPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SIGNATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PRINTED_BY)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PICTURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SIGNATURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SALARY_SCALE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.GRADE_LEVEL)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.STEP)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.POSTING_LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PRODUCT1)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PERCENTAGE1)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PRODUCT2)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PERCENTAGE2)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PRODUCT3)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PERCENTAGE3)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PRODUCT4)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PERCENTAGE4)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PRODUCT5)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVEST_PERCENTAGE5)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.CORRESPONDENCE_ADDS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_CORRADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_CORRADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PFA_TRANS_IN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.ACCT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.RSA_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.BIOMETRICS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.FORM_IMAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SERIAL)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PIN_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.ER_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.ER_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.BIOMETRICS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK_COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EMPLOYEE_GROUP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.LOCATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.SAP_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.STAFF_GRADE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EE_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.ER_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.OLD_EMPLOYEEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EE_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.EE_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.REQ_BY_PENCOM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.UPLOAD_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PERM_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PERM_STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_MAIDENNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_COUNTRYCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_MOBILEPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NOK2_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.MOTHERS_MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NIMC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.BVN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.NAME_OF_SPOUSE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.HIGHEST_QUALIFICATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PLACE_OF_BIRTH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.RELIGION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.MEANS_OF_ID_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PREVIOUSLY_SELF_EMPLOYED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PREVIOUS_BUSINESS_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PREVIOUS_BUSINESS_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PREVIOUS_BUSINESS_TOWN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PROOF_OF_ID_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.PROOF_OF_ADDRESS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_CFI>()
        //        .Property(e => e.MOTHER_MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_INVESTORS>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_INVESTORS>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_INVESTORS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_INVESTORS>()
        //        .Property(e => e.CONTRIBUTION_PERCENT)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<REGISTRATION_INVESTORS>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_SELECTED>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PASSPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SIGNATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PRINTED_BY)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PICTURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SIGNATURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SALARY_SCALE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.GRADE_LEVEL)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.STEP)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.POSTING_LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PRODUCT1)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PERCENTAGE1)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PRODUCT2)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PERCENTAGE2)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PRODUCT3)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PERCENTAGE3)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PRODUCT4)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PERCENTAGE4)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PRODUCT5)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVEST_PERCENTAGE5)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.CORRESPONDENCE_ADDS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_CORRADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_CORRADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PFA_TRANS_IN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.ACCT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.RSA_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.BIOMETRICS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.FORM_IMAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SERIAL)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PIN_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.ER_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.ER_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.BIOMETRICS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK_COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EMPLOYEE_GROUP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.LOCATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.SAP_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.STAFF_GRADE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EE_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.ER_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.OLD_EMPLOYEEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EE_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.EE_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.REQ_BY_PENCOM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.UPLOAD_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PERM_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PERM_STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_MAIDENNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_COUNTRYCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_MOBILEPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NOK2_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.MOTHERS_MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NIMC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.BVN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.NAME_OF_SPOUSE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.HIGHEST_QUALIFICATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PLACE_OF_BIRTH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.RELIGION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.MEANS_OF_ID_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.TRANSFER_PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.TRANSFER_PFA_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.TRANSFER_CURRENT_RSA_BALANCE)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PROOF_OF_ID_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGISTRATION_TRANSFER>()
        //        .Property(e => e.PROOF_OF_ADDRESS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REGNO_CONFIRM>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RELATIONSHIP>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RELATIONSHIP>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RELATIONSHIP>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RETIREES_TRAIL>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RETIREES_TRAIL>()
        //        .Property(e => e.FIELD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RETIREES_TRAIL>()
        //        .Property(e => e.PREVIOUS_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RETIREES_TRAIL>()
        //        .Property(e => e.CURRRENT_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RETIREES_TRAIL>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RETIREES_TRAIL>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RETIREES_TRAIL>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RETIREMENT_SCHEDULE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RETIREMENT_SCHEDULE>()
        //        .Property(e => e.EMPLOYEE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RETIREMENT_SCHEDULE>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RMAS_SCHEME_ASSOCIATION>()
        //        .Property(e => e.PROFILE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RMAS_SCHEME_ASSOCIATION>()
        //        .Property(e => e.REPORT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RMAS_SUMMARY_REPORT>()
        //        .Property(e => e.SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RMAS_SUMMARY_REPORT>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RMAS_SUMMARY_REPORT>()
        //        .Property(e => e.CURRENT_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RMAS_SUMMARY_REPORT>()
        //        .Property(e => e.XML_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RMAS_UNFUNDED_EXCEPTION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RMAS_UNFUNDED_EXCEPTION>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RMAS_UNFUNDED_EXCEPTION>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.PFA_SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RPT_EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.PCENTAGE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<RPT_EMPLOYEE_ACCOUNTS>()
        //        .Property(e => e.INVESTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.CONTRIBUTION_PERCENT)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_INVESTORS>()
        //        .Property(e => e.INVESTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.TOT_TRANSUNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.TOT_TRANSUNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.UNIT_PRICE_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.UNIT_PRICE_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.TRANSUNITS_R_BF)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.TRANSUNITS_V_BF)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.CORR_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.CORR_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.ACCT_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT>()
        //        .Property(e => e.SCHEME_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.TOT_TRANSUNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.TOT_TRANSUNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.UNIT_PRICE_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.UNIT_PRICE_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.TRANSUNITS_R_BF)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_STATEMENT_ONLINE>()
        //        .Property(e => e.TRANSUNITS_V_BF)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<RPT_WELCOME_LETTER>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_WELCOME_LETTER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_WELCOME_LETTER>()
        //        .Property(e => e.PKEY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_WELCOME_LETTER>()
        //        .Property(e => e.VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RSAXMLEXPORTFILE>()
        //        .Property(e => e.FILENAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RSAXMLEXPORTFILE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<S_AUDIT>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_AUDIT>()
        //        .Property(e => e.TRANS_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_AUDIT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_AUDIT>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_GROUP>()
        //        .Property(e => e.GROUP_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_GROUP>()
        //        .Property(e => e.GROUP_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_LOGIN>()
        //        .Property(e => e.USER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_LOGIN>()
        //        .Property(e => e.WORKSTATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_MENU>()
        //        .Property(e => e.MENU_OBJECT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_MENU>()
        //        .Property(e => e.MENU_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_MENU>()
        //        .Property(e => e.MENU_TEXT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_MENUOBJECT>()
        //        .Property(e => e.MENU_OBJECT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_MENUOBJECT>()
        //        .Property(e => e.MENU_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_PRIVILEGE>()
        //        .Property(e => e.USER_OR_GROUP_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_PRIVILEGE>()
        //        .Property(e => e.MENU_OBJECT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_PRIVILEGE>()
        //        .Property(e => e.MENU_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_PRIVILEGE>()
        //        .Property(e => e.USER_OR_GROUP)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.RESOURCE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.RESOURCE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.RESOURCE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.RESOURCE_SCRIPT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.RESOURCE_HELP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.ROLE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.RESOURCE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.RESOURCE_PARENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.WINDOW_WIDTH)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.WINDOW_HEIGHT)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.WINDOW_HEADER)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.APP_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCE>()
        //        .Property(e => e.RESOURCE_SEQ)
        //        .HasPrecision(2, 0);

        //    modelBuilder.Entity<S_RESOURCEGROUPS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_RESOURCEGROUPS>()
        //        .Property(e => e.APP_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_RESOURCEGROUPS>()
        //        .Property(e => e.APP_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_ROLE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_ROLE>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_ROLE>()
        //        .Property(e => e.ROLENAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_ROLE>()
        //        .Property(e => e.LOCK_ROLE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_ROLE>()
        //        .Property(e => e.ROLE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_ROLERESOURCE>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_ROLERESOURCE>()
        //        .Property(e => e.RESOURCE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_ROLERESOURCE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_ROLERESOURCE>()
        //        .Property(e => e.ID_RESOURCE)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_ROLETYPE>()
        //        .Property(e => e.ROLE_TYPEID)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<S_ROLETYPE>()
        //        .Property(e => e.TYPE_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_ROLETYPE>()
        //        .Property(e => e.HOME_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_SERVERDATE>()
        //        .Property(e => e.SERVER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_SERVERDATE>()
        //        .Property(e => e.SUPPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_SYSPARAMETER>()
        //        .Property(e => e.PENTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_SYSPARAMETER>()
        //        .Property(e => e.PVALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_SYSPARAMETER>()
        //        .Property(e => e.PCOMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_SYSPARAMETER>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.USER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.USER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.PASSWORD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.DAY_1)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.DAY_2)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.DAY_3)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.DAY_4)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.DAY_5)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.DAY_6)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.DAY_7)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.SUPERVISOR)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.USER_LOGIN)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.PASS_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.PASS_DURATION)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.FULL_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.USERPIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.LASTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.COMPANY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.STREET)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.ZIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.FAX)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.HINTQUESTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.HINTANSWER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.PASSCHG_LOGON)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.PASSNO_EXPIRE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.PIN_MISSED)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.PASSNO_CHANGE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.USER_DISABLED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.USER_LOCKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.USER_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.ACCOUNT_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER>()
        //        .Property(e => e.WORKSTATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER_TRAIL>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_USER_TRAIL>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER_TRAIL>()
        //        .Property(e => e.TRAIL_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<S_USER_TRAIL>()
        //        .Property(e => e.MODIF_FIELD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USER_TRAIL>()
        //        .Property(e => e.WORKSTATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USERLOG>()
        //        .Property(e => e.USER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USERLOG>()
        //        .Property(e => e.COMMENTS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USERLOG>()
        //        .Property(e => e.WORKSTATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_USERROLES>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_USERROLES>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_USERROLES>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.USERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.PASSWORD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.USERPIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.LASTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.COMPANY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.STREET)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.ZIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.FAX)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.HINTQUESTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.HINTANSWER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.PASSCHG_LOGON)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.PASSNO_EXPIRE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.PASSNO_CHANGE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.USER_DISABLED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.USER_LOCKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.DAY_1)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.DAY_2)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.DAY_3)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.DAY_4)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.DAY_5)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.DAY_6)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.DAY_7)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.PIN_MISSED)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<S_WEBUSER>()
        //        .Property(e => e.PWD_THEHUB)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WORKGROUP>()
        //        .Property(e => e.GROUP_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WORKGROUP>()
        //        .Property(e => e.USER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SALARY_STRUCTURE>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<SALARY_STRUCTURE>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SALARY_STRUCTURE>()
        //        .Property(e => e.NAME_GRL_STP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME_FUND>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEME_FUND>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEME_FUND>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.SCHEME_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.OFFER_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.BID_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.OFFER_FOR)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.BID_FOR)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.PAY_COT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.COT_PERCENT)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.CALC_INTEREST)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.SCHEME_LOGO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.UPDATE_SUCCESS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.MANAGER_HEADER_PAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.MANAGER_FOOTER_PAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.PROMISE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.STAMP_DUTIES)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.NSE_CSCS_FEES)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.BROKERAGE_FEES)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.SEC_FEES)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.MGMT_FEE_PAYABLE_PERC)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.EXCESS_FEE_PAYABLE_PERC)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.VAT_ON_EXCESS_FEE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.TRANS_FEE_PAYABLE_PERC)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.PERCENTAGE_ABOVE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.FEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.ACCOUNT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.CSCS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.TROI_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.RATING_REQUIRMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.INVEST_GUIDELINE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.POINT_TO_NOTE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.STANDING_ORDERS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.REPORTING_FREQ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.ACCOUNT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.ASI_BENCHMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.BOND_BENCHMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.MM_BENCHMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.RISKFREE_BENCHMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.PORTFOLIO_RETURN)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.DEFAULT_CURRENCY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.ACCOUNT_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.SCHEME_CLASS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.INVESTMENT_ACCOUNT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.HOLDING_ACCOUNT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.PAYABLE_ACCOUNT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.FEE_ACCOUNT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME>()
        //        .Property(e => e.PRICE_THRESHOLD)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<SCHEMES_INTEREST_RATES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEMES_INTEREST_RATES>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.BID_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.OFFER_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.TROI)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.WATBR)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.TROI_USED)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.NO_OF_DAYS)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.LOCKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEMES_SUMMARY>()
        //        .Property(e => e.PORTFOLIO_RETURN)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<SIGNATORY>()
        //        .Property(e => e.SIGNATORY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SIGNATORY>()
        //        .Property(e => e.SIGNATORY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SIGNATORY>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SIGNATORY>()
        //        .Property(e => e.SIGNATURE_PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SMS_TEMPLATE>()
        //        .Property(e => e.SMS_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SMS_TEMPLATE>()
        //        .Property(e => e.SMS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SMS_TEMPLATE>()
        //        .Property(e => e.MSG_TEMPLATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SMS_TEMPLATE>()
        //        .Property(e => e.SMS_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE_FUNDED>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE_FUNDED>()
        //        .Property(e => e.ST_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE_FUNDED>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE_ZONE>()
        //        .Property(e => e.ZONE_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE_ZONE>()
        //        .Property(e => e.ZONE_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE_ZONE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<STATEMENT_DETAIL>()
        //        .Property(e => e.SEQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_DETAIL>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_DETAIL>()
        //        .Property(e => e.DETAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_DETAIL>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_PINS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_PINS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.CONTACT_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.EMPLOYER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.UNITS_HELD)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.SOP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.UNITS_HELD_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.NET_CONTRIBUTION_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.UNITS_BF)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.UNITS_BF_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.END_DATE_FORMATTED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY>()
        //        .Property(e => e.PFA_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY_IND>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATEMENT_SUMMARY_IND>()
        //        .Property(e => e.UNITS_HELD)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY_IND>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY_IND>()
        //        .Property(e => e.UNITS_HELD_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY_IND>()
        //        .Property(e => e.UNITS_BF)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATEMENT_SUMMARY_IND>()
        //        .Property(e => e.UNITS_BF_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STATE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE>()
        //        .Property(e => e.ZONE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<STATUS>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STATUS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK_REVALUATION_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<STOCK_REVALUATION_ACCT>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK_REVALUATION_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK_REVALUATION_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK_REVALUATION_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<STOCK>()
        //        .Property(e => e.CURRENT_PRICE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<STOCK>()
        //        .Property(e => e.TOTAL_SHARES)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STOCK>()
        //        .Property(e => e.CURRENT_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<STOCK>()
        //        .Property(e => e.SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<STOCK>()
        //        .Property(e => e.ALERT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK>()
        //        .Property(e => e.COMPANY_SHARES)
        //        .HasPrecision(20, 4);

        //    modelBuilder.Entity<STOCKS_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<STOCKS_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCKS_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCKS_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TBILL_RATES>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TBILL_RATES>()
        //        .Property(e => e.RATE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.id)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.fullname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.employee_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jan2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.feb2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.mar2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.apr2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.may2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jun2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jul2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.aug2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.sep2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.oct2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.nov2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.dec2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.year2013)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.pin2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.fullname2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.employee_id2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jan2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.feb2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.mar2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.apr2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.may2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jun2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jul2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.aug2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.sep2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.oct2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.nov2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.dec2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.year2014)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.pin2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.fullname2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.employee_id2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jan2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.feb2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.mar2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.apr2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.may2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jun2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jul2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.aug2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.sep2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.oct2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.nov2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.dec2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.year2015)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.pin2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.fullname2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.employee_id2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jan2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.feb2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.mar2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.apr2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.may2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jun2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jul2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.aug2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.sep2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.oct2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.nov2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.dec2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.year2016)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.pin2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.fullname2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.employee_id2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jan2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.feb2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.mar2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.apr2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.may2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jun2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.jul2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.aug2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.sep2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.oct2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.nov2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.dec2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_all_delta_mm>()
        //        .Property(e => e.year2017)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_appendix_c_report>()
        //        .Property(e => e.id)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<tbl_appendix_c_report>()
        //        .Property(e => e.rsa_count)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_appendix_c_report>()
        //        .Property(e => e.fed_govt_count)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_appendix_c_report>()
        //        .Property(e => e.state_govt)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_appendix_c_report>()
        //        .Property(e => e.private_sector_count)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_appendix_c_report>()
        //        .Property(e => e.rsa_status_active)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_appendix_c_report>()
        //        .Property(e => e.rsa_status_inactive)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_pencom_response_auto_upload>()
        //        .Property(e => e.id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_pencom_response_auto_upload>()
        //        .Property(e => e.initiating_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_pencom_response_auto_upload>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_pencom_response_auto_upload>()
        //        .Property(e => e.userid)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_pencom_response_upload_log>()
        //        .Property(e => e.id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_pencom_response_upload_log>()
        //        .Property(e => e.initiating_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_pencom_response_upload_log>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_pencom_response_upload_log>()
        //        .Property(e => e.userid)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<temp_25percent_rpt>()
        //        .Property(e => e.id)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<temp_25percent_rpt>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<temp_25percent_rpt>()
        //        .Property(e => e.payment_date)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_CATEGORY>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET_CATEGORY>()
        //        .Property(e => e.CATEGORY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_CATEGORY>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_COMMENT>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET_COMMENT>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_COMMENT>()
        //        .Property(e => e.SEQUENCE)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET_COMMENT>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET_SEVERITY>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET_SEVERITY>()
        //        .Property(e => e.SEVERITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_SEVERITY>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_STATUS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET_STATUS>()
        //        .Property(e => e.STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_STATUS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_TYPE>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET_TYPE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET_TYPE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.ASSIGNED_USER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.ASSIGNED_GROUP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.TICKET_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.FILE_PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.MODE_OF_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.TICKET_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.CLOSED_BY)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.DURATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TICKET>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TITLE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TITLE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TRANSFER>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<TRANSFER>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.TRANS_UNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.RETIREE_DEPOSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER_TRAN>()
        //        .Property(e => e.TRANS_UNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.EMPLOYER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.CATEGORY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.FUND)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(6, 4);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.RSA_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<TRANSFER1>()
        //        .Property(e => e.RSA_PRICE)
        //        .HasPrecision(6, 4);

        //    modelBuilder.Entity<TROI_TYPES>()
        //        .Property(e => e.TROI_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TROI_TYPES>()
        //        .Property(e => e.TROI_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TROI_TYPES>()
        //        .Property(e => e.TROI_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<UNFUNDED_DATA>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA>()
        //        .Property(e => e.employee_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA>()
        //        .Property(e => e.remarks)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA_LOG>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA_LOG>()
        //        .Property(e => e.EMPLOYEE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA_LOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA_LOG>()
        //        .Property(e => e.AMOUNT)
        //        .HasPrecision(19, 2);

        //    modelBuilder.Entity<UNFUNDED_DATA_LOG>()
        //        .Property(e => e.REMARKS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA_RMAS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<UNFUNDED_DATA_RMAS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA_RMAS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_DATA_RMAS>()
        //        .Property(e => e.REMARKS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_RSA>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_RSA>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_RSA>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_RSA>()
        //        .Property(e => e.SECTOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_RSA>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<UNFUNDED_RSA>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_TEMPO>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_TEMPO>()
        //        .Property(e => e.USERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_YTD>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_YTD>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_YTD>()
        //        .Property(e => e.EMPLOYEE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_YTD>()
        //        .Property(e => e.EMPLOYER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_YTD>()
        //        .Property(e => e.CATEGORY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_YTD>()
        //        .Property(e => e.PERIOD)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UNFUNDED_YTD>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<VALUATION_SUMMARY_REPORT>()
        //        .Property(e => e.SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<VALUATION_SUMMARY_REPORT>()
        //        .Property(e => e.SEQ_NO)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<VALUATION_SUMMARY_REPORT>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<VALUATION_SUMMARY_REPORT>()
        //        .Property(e => e.CURRENT_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<VALUATION_SUMMARY_REPORT>()
        //        .Property(e => e.XML_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_MORTALITYRATE>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<WITHDRAWAL_MORTALITYRATE>()
        //        .Property(e => e.Gender)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_MORTALITYRATE>()
        //        .Property(e => e.Age)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<WITHDRAWAL_MORTALITYRATE>()
        //        .Property(e => e.Nx_Dx)
        //        .HasPrecision(24, 18);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SCHEME_CODE)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PAYMENT_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.EVIDENCE_ENCLOSED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERMINATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERMINATED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PAYMENT_MADE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.REASON_RETIRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.WITHDRAWAL_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(36, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERM_CHEKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERM_CHEKED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.GRATUITY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.RATE_OF_GRAT)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.GRATUITY_FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PENSION_FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.GRATUITY_TAKEN)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SERVICE_YEARS)
        //        .HasPrecision(6, 4);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERM_CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PROG_WITHD_OPTION)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BENEFICIARY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.TERM_CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SORT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.VAT)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.ADMIN_FEE)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.SCHEMECODE)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.BANK_BRANCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.REASON)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL_PROCESS>()
        //        .Property(e => e.RMAS_GENERATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_EMPLOYER_DETAILS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_EMPLOYER_DETAILS>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_EMPLOYER_DETAILS>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_MFR_300>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_MFR_300>()
        //        .Property(e => e.BALSHT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_MFR_300>()
        //        .Property(e => e.ITEM_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_MFR135>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<XML_MFR135>()
        //        .Property(e => e.TYPE_OF_PROPERTY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_MFR135>()
        //        .Property(e => e.PROPERTY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1000>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1000>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1000>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1000>()
        //        .Property(e => e.APPOINTMENT_NATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1000>()
        //        .Property(e => e.SHAREHOLDING)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<XML_PFAQCR1100>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1100>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1100>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1100>()
        //        .Property(e => e.OFFICIAL_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1100>()
        //        .Property(e => e.APPOINTMENT_NATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR1100>()
        //        .Property(e => e.POSITION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.HEAD_OFFICE_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.POSTAL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.STATE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.WEBSITE_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.E_MAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.NO_OF_STAFF)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.NO_OF_OFFICES)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.NO_OF_REGIONAL_OFFICES)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.NO_OF_BRANCH_OFFICES)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_PFAQCR300>()
        //        .Property(e => e.NO_OF_SALES_OFFICES)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_PFAQCR301>()
        //        .Property(e => e.REGIONAL_OFFICE_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR301>()
        //        .Property(e => e.STATE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR301>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR301>()
        //        .Property(e => e.NO_OF_STAFF)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_PFAQCR302>()
        //        .Property(e => e.BRANCH_OFFICE_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR302>()
        //        .Property(e => e.STATE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR302>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR302>()
        //        .Property(e => e.NO_OF_STAFF)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_PFAQCR400>()
        //        .Property(e => e.FULL_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR400>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR400>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR400>()
        //        .Property(e => e.EMAIL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR500>()
        //        .Property(e => e.FULL_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR500>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR500>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR500>()
        //        .Property(e => e.EMAIL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR600>()
        //        .Property(e => e.FULL_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR600>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR600>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR600>()
        //        .Property(e => e.EMAIL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR700>()
        //        .Property(e => e.FULL_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR700>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR700>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR700>()
        //        .Property(e => e.EMAIL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR800>()
        //        .Property(e => e.FULL_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR800>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR800>()
        //        .Property(e => e.TELEPHONE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR800>()
        //        .Property(e => e.EMAIL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR800>()
        //        .Property(e => e.SERVICE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR900>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR900>()
        //        .Property(e => e.INSTITUTIONAL_INDIVIDUAL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR900>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQCR900>()
        //        .Property(e => e.SHAREHOLDING)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<XML_PFAQFR1000>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PFAQFR1000>()
        //        .Property(e => e.NO_OF_CONTRIBUTORS)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<XML_PFAQFR1000>()
        //        .Property(e => e.NO_OF_SENT_STATEMENT)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<XML_PFAQFR1000>()
        //        .Property(e => e.DISPATCH_COURIER)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<XML_PFAQFR1000>()
        //        .Property(e => e.DISPATCH_EMAIL)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<XML_PFAQFR1000>()
        //        .Property(e => e.DISPATCH_OTHERS)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<XML_PROCEDURE_PROGRESS>()
        //        .Property(e => e.host_id)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_PROCEDURE_PROGRESS>()
        //        .Property(e => e.status_descr)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR101>()
        //        .Property(e => e.SNO)
        //        .HasPrecision(8, 0);

        //    modelBuilder.Entity<XML_QAR101>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR102>()
        //        .Property(e => e.SNO)
        //        .HasPrecision(8, 0);

        //    modelBuilder.Entity<XML_QAR102>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.STATE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.E_MAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.TELEPHONE_1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.TELEPHONE_2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.FAX_1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.FAX_2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.LICENSE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.NO_OF_SHAREHOLDERS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.NO_OF_DIRECTORS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.NO_OF_BRANCHES_APPROVED)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.NUMBER_OF_BRANCHES)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.TOTAL_ORDINARY_SHARES_ISSUED)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.NO_OF_BRANCHES_NOT_APPROVED)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.PRIVATE_INDIVIDUAL)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.YEAR_END)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<XML_QAR1100>()
        //        .Property(e => e.no_of_auditors)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<XML_QAR1100_AUDITOR>()
        //        .Property(e => e.S_NO)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<XML_QAR1100_AUDITOR>()
        //        .Property(e => e.FIRM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100_AUDITOR>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100_AUDITOR>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100_AUDITOR>()
        //        .Property(e => e.STATE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100_AUDITOR>()
        //        .Property(e => e.PHONE_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1100_AUDITOR>()
        //        .Property(e => e.FAX_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.BRANCH_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.STATE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.TELEPHONE_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.FAX_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.LOCAL_GOVERNMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.TOTAL_NUMBER_OF_CONTRIBUTORS)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.TOTAL_CONTRIBUTION)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.TOTAL_SENIOR)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<XML_QAR1200>()
        //        .Property(e => e.TOTAL_JUNIOR)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<XML_QAR1300>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1300>()
        //        .Property(e => e.FULLNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1300>()
        //        .Property(e => e.POSTAL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1300>()
        //        .Property(e => e.PHYSICAL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1300>()
        //        .Property(e => e.TELEPHONE_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1300>()
        //        .Property(e => e.E_MAIL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1400>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1400>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1500>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1500>()
        //        .Property(e => e.TYPE_OF_APPOINTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1500>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1500>()
        //        .Property(e => e.TEL_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1600>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1600>()
        //        .Property(e => e.POSITION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1600>()
        //        .Property(e => e.RESIDENTIAL_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1600>()
        //        .Property(e => e.PHONE_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR1600>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_QAR201>()
        //        .Property(e => e.SNO)
        //        .HasPrecision(8, 0);

        //    modelBuilder.Entity<XML_QAR201>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_REPORT_NAMES>()
        //        .Property(e => e.FREQ_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_REPORT_NAMES>()
        //        .Property(e => e.REPORT_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_REPORT_NAMES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_REPORT_NAMES_RMAS>()
        //        .Property(e => e.FREQ_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_REPORT_NAMES_RMAS>()
        //        .Property(e => e.REPORT_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_REPORT_NAMES_RMAS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_REPORTS_MFR300>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<XML_REPORTS_MFR300>()
        //        .Property(e => e.RCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_REPORTS_MFR300>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_TEMPLATE_SETTINGS>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<XML_TEMPLATE_SETTINGS>()
        //        .Property(e => e.TEMPLATE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_TEMPLATE_SETTINGS>()
        //        .Property(e => e.CODE_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_TEMPLATE_SETTINGS>()
        //        .Property(e => e.BALSHT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_TEMPLATE_SETTINGS>()
        //        .Property(e => e.RPT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_TEMPLATE_SETTINGS>()
        //        .Property(e => e.GL_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_RECEIVABLE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ACCOUNT_RECEIVABLE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ACCOUNT_RECEIVABLE>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<ACCOUNT_RECEIVABLE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<ACCOUNT_RECEIVABLE>()
        //        .Property(e => e.PAID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_ACCT>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<ADMIN_FEES_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.EMPLOYEE_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.FEE_PCENTUSED)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.VAT_PCENTUSED)
        //        .HasPrecision(14, 2);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.EMPLOYEE_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.FEE_PCENTUSED)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.VAT_PCENTUSED)
        //        .HasPrecision(14, 2);

        //    modelBuilder.Entity<ADMIN_FEES_TRANS_REV>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<ADMINFEES_SETUP_VALUES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<ADMINFEES_SETUP_VALUES>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<ADMINFEES_SETUP_VALUES>()
        //        .Property(e => e.FEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMINFEES_SETUP_VALUES>()
        //        .Property(e => e.FEE_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<ADMINFEES_SETUP_VALUES>()
        //        .Property(e => e.PERCENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMINFEES_SETUP_VALUES>()
        //        .Property(e => e.FREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMINFEES_SETUP_VALUES>()
        //        .Property(e => e.VAT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ADMINFEES_SETUP_VALUES>()
        //        .Property(e => e.VAT_PERCENT)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<AUTHORISE_ALERT>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AUTHORISE_ALERT>()
        //        .Property(e => e.JOB_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AUTHORISE_ALERT>()
        //        .Property(e => e.CREATED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<AUTHORISE_ALERT>()
        //        .Property(e => e.JOB_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<AUTHORISE_ALERT>()
        //        .Property(e => e.JOB_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms>()
        //        .Property(e => e.emp_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms>()
        //        .Property(e => e.phone)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms>()
        //        .Property(e => e.narration)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms>()
        //        .Property(e => e.contribution)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<auto_sms>()
        //        .Property(e => e.total_balance)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<auto_sms>()
        //        .Property(e => e.withdrawal)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<auto_sms>()
        //        .Property(e => e.price)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<auto_sms_nophone>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms_nophone>()
        //        .Property(e => e.emp_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms_nophone>()
        //        .Property(e => e.phone)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms_nophone>()
        //        .Property(e => e.narration)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms_nophone>()
        //        .Property(e => e.contribution)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<auto_sms_nophone>()
        //        .Property(e => e.total_balance)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<auto_sms_nophone>()
        //        .Property(e => e.withdrawal)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<auto_sms_nophone>()
        //        .Property(e => e.price)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<auto_sms_pin>()
        //        .Property(e => e.emp_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms_pin>()
        //        .Property(e => e.phone)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms_pin>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<auto_sms_pin>()
        //        .Property(e => e.username)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<autosms2>()
        //        .Property(e => e.emp_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<autosms2>()
        //        .Property(e => e.phone)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_BENEFICIARIES>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_BENEFICIARIES>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_BENEFICIARIES>()
        //        .Property(e => e.FULLNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_BENEFICIARIES>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_BENEFICIARIES>()
        //        .Property(e => e.RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_BENEFICIARIES>()
        //        .Property(e => e.PERCENTAGE)
        //        .HasPrecision(15, 2);

        //    modelBuilder.Entity<BATCH_BENEFICIARIES>()
        //        .Property(e => e.SERIAL_NO)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_BENEFICIARIES>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_LOG>()
        //        .Property(e => e.BATCH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_LOG>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_LOG>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_LOG>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<BATCH_LOG>()
        //        .Property(e => e.CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_PROFILE>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_PROFILE>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_PROFILE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_PROFILE>()
        //        .Property(e => e.CONTRIBUTION_PERCENT)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<BATCH_PROFILE>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BATCH_PROFILE>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.PASSPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.SIGNATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.SALARY_SCALE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.GRADE_LEVEL)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.STEP)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.POSTING_LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE1)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE2)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE3)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT4)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE4)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PRODUCT5)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.INVEST_PERCENTAGE5)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.CORRESPONDENCE_ADDS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_CORRADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_CORRADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.BIOMETRICS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.PFA_TRANS_IN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.ACCT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.RSA_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.FORM_IMAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.BIOMETRICS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK_COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.EMPLOYEE_GROUP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.LOCATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.SAP_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.STAFF_GRADE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.REQ_BY_PENCOM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.UPLOAD_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_MAIDENNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_COUNTRYCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_MOBILEPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.NOK2_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.SQL_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BATCH_REGISTRATION>()
        //        .Property(e => e.REGISTRATION_CODE1)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BENEFICIARy>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BENEFICIARy>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BENEFICIARy>()
        //        .Property(e => e.FULLNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BENEFICIARy>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BENEFICIARy>()
        //        .Property(e => e.RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BENEFICIARy>()
        //        .Property(e => e.PERCENTAGE)
        //        .HasPrecision(15, 2);

        //    modelBuilder.Entity<BENEFICIARy>()
        //        .Property(e => e.SERIAL_NO)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_AJUSTMENTS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_AJUSTMENTS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND_AJUSTMENTS>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND_AJUSTMENTS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_AJUSTMENTS>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_AJUSTMENTS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_PRICES>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_PRICES>()
        //        .Property(e => e.CURRENT_YIELD)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<BOND_PRICES>()
        //        .Property(e => e.CLOSE_PRICE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<BOND_PRICES>()
        //        .Property(e => e.SYMBOL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.COUPON_RATE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.UNITS_SOLD)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(25, 20);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.REFERENCE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.POSTED_BY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.SALES_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.TERMINATED_TO_RECEIVABLE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.RECEIVABLE_TRANSID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND_SALES>()
        //        .Property(e => e.RECEIVABLE_TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TENOR)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.REMAIN_TENOR)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TERMINATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TRANS_CHECK)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CURR_ORIG_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CURR_CURR_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.PAYMENT_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.BOND_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.DISCOUNT_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.COUNTER_PARTY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.YIELD)
        //        .HasPrecision(16, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.REFERENCE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CHECKED2)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.OLD_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.BOND_TERM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CHILD_FLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CLEAN_PRICE_U)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CURRENT_RATE)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CURRENT_UNITPRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.DIRTY_PRICE_U)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.OLD_TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.ORIGINAL_RATE)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.PARENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.REQUIRED_YIELD)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TOTALUNITS_BALANCE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TOTALUNITS_SOLD)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.UNITPRICE_ATPURCHASE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.DIRTYPRICE_ATPURCHASE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.FX_TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.FX_UNIT_PRICE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.FX_UNITPRICE_ATPURCHASE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.FX_DIRTYPRICE_ATPURCHASE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.CURRENT_YIELD)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.EFFECTIVE_INTEREST_RATE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.EFF_INT_RATE)
        //        .HasPrecision(30, 25);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.COUNTER_PARTY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TERMINATED_TO_RECEIVABLE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.RECEIVABLE_TRANSID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.RECEIVABLE_TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.RECLASSIFICATION_PRICE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.TRANSFERRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BOND>()
        //        .Property(e => e.FROM_SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RATES>()
        //        .Property(e => e.COMPANY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_INTEREST_RATES>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.NEW_SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.TENOR)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.REMAIN_TENOR)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.TERMINATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.TRANS_CHECK)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CURR_ORIG_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CURR_CURR_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.PAYMENT_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.BOND_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.DISCOUNT_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.COUNTER_PARTY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.YIELD)
        //        .HasPrecision(16, 4);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.REFERENCE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CHECKED2)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.TOTALUNITS_BALANCE)
        //        .HasPrecision(20, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.ORIGINAL_RATE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.DIRTYPRICE_ATPURCHASE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.FX_TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.FX_UNIT_PRICE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.FX_UNITPRICE_ATPURCHASE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.FX_DIRTYPRICE_ATPURCHASE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CURRENT_YIELD)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CURRENT_RATE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.CURRENT_UNITPRICE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.UNITPRICE_ATPURCHASE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.BOND_TERM)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.TOTALUNITS_SOLD)
        //        .HasPrecision(20, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.EFF_INT_RATE)
        //        .HasPrecision(30, 25);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(20, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.REQUIRED_YIELD)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.TERMINATED_TO_RECEIVABLE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.RECEIVABLE_TRANSID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.RECEIVABLE_TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.COUNTER_PARTY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONDS_TRANSFER>()
        //        .Property(e => e.POSTED_NEWFUND)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.COMPANY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.SHARE_BONUS)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.BASE_BONUS)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.QUANTITY_AVAILABLE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.QUANTITY_BONUS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.CHECKED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.SPLIT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.OLD_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONU>()
        //        .Property(e => e.UNITS_RECEIVED)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.COMPANY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.UNIT_RECEIVED)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.CHECKED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<BONUS_RECEIVED>()
        //        .Property(e => e.UNITS_RECEIVED)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<BROKERAGE_FEES>()
        //        .Property(e => e.SEQNO)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<BROKERAGE_FEES>()
        //        .Property(e => e.PERCENTAGE)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<BUSSINESS_GROUP>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BUSSINESS_GROUP>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL_REPORTS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CA_JOURNAL_REPORTS>()
        //        .Property(e => e.SEQUENCE_NO)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<CA_JOURNAL_REPORTS>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL_REPORTS>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CA_JOURNAL_REPORTS>()
        //        .Property(e => e.NO_DAYS)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<CAJOURNAL_ACCT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAJOURNAL_ACCT>()
        //        .Property(e => e.TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_ACCT>()
        //        .Property(e => e.TRANS_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_ACCT>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_ACCT>()
        //        .Property(e => e.ACCT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAJOURNAL_ACCT>()
        //        .Property(e => e.OP_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.BROKERS_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.SHARES)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.ORIGINAL_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.CURRENT_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.SEC_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.BROKERAGE_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.STAMP_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.VAT_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.OTHER_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.NSE_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.CSCS_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.ORIGINAL_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.CURRENT_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.COST_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.VAT_NSE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.VAT_SEC)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.VAT_CSCS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.OLD_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.TRANSFERRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET>()
        //        .Property(e => e.FROM_SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.NEW_SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.BROKERS_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.SHARES)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.ORIGINAL_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.CURRENT_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.SEC_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.BROKERAGE_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.STAMP_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.VAT_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.OTHER_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.NSE_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.CSCS_PERCENT)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.ORIGINAL_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.CURRENT_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.COST_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.VAT_NSE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.VAT_SEC)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.VAT_CSCS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CAPITAL_MARKET_TRANSFER>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.CONTACT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.CONTACT_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.EMPLOYER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.UNITS_HELD)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.SOP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_BALANCES>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.NOTE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.DETAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.ACTION_TAKEN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.NOTE_STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.NOTES_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.CONTACT_MODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENT_NOTES>()
        //        .Property(e => e.FEEDBACK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.COMPANY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.MARKET_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.COMPANY_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.COMPANY_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.CONTACT_PERSON)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.SYMBOL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.MARKET_PRICE)
        //        .HasPrecision(12, 2);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.SECTOR_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.TOTAL_SHARES)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.MUTUAL_FUND_PRODUCT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.RATING)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.CBN_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.COMPANY_RATING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.COMPANY_RATING_CM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.BOND_ISSUER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.INSTRUMENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.COUPON_RATE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.BOND_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.PAYMENT_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.REGISTRAR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 10);

        //    modelBuilder.Entity<COMPANY_RATING>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY_RATING>()
        //        .Property(e => e.TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY_RATING>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY_RATING>()
        //        .Property(e => e.RATING_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY_SCHEME_LIMIT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<COMPANY_SCHEME_LIMIT>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<COMPANY_SCHEME_LIMIT>()
        //        .Property(e => e.MM_BB_LIMIT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COMPANY_SCHEME_LIMIT>()
        //        .Property(e => e.CM_LIMIT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONSOLIDATED_STOCKS>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONSOLIDATED_STOCKS>()
        //        .Property(e => e.CURRENT_PRICE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<CONSOLIDATED_STOCKS>()
        //        .Property(e => e.TOTAL_SHARES)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONSOLIDATED_STOCKS>()
        //        .Property(e => e.CURRENT_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONSOLIDATED_STOCKS>()
        //        .Property(e => e.SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONSOLIDATED_STOCKS>()
        //        .Property(e => e.COMPANY_SHARES)
        //        .HasPrecision(20, 4);

        //    modelBuilder.Entity<CONT_CONVERT>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_CONVERT>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_CONVERT>()
        //        .Property(e => e.SOURCE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_CONVERT>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONT_CONVERT>()
        //        .Property(e => e.YEAR)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<CONT_DETAILS>()
        //        .Property(e => e.PENSION_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_DETAILS>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_DETAILS>()
        //        .Property(e => e.INTIALS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.OTHER_FEE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.TRANS_UNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.TRANS_UNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.RETIREE_DEPOSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.OLD_PFACODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.TRANS_UNITS)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.SENT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONT_RECONCILLIATION>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.OTHER_FEE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.TRANS_UNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.TRANS_UNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.RETIREE_DEPOSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.OLD_PFACODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.TRANS_UNITS)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.SENT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION>()
        //        .Property(e => e.POSTED1)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.NARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.BATCH_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.FEECODE)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.OLD_PFACODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.SCHEDULE_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.TXN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.CONTRIBUTION_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.LOADED)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.PROCCESSED)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.FILE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.LOCKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.INTEREST)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_BATCH>()
        //        .Property(e => e.INTEREST_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_INTEREST>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_INTEREST>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_INTEREST>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_INTEREST>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_INTEREST>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_LAST_31_12_2018>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LAST_31_12_2018>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.ERROR_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.TRANSUNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_LOG>()
        //        .Property(e => e.CORRECTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.OTHER_FEE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.TRANS_UNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.TRANS_UNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.RETIREE_DEPOSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.OLD_PFACODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.TRANS_UNITS)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.SENT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTION_REVERSE>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.surname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.othernames)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.mobile_phone)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.client_status)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.employer_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.Total_Units)
        //        .HasPrecision(38, 4);

        //    modelBuilder.Entity<contribution_sms_fund3>()
        //        .Property(e => e.Current_Value)
        //        .HasPrecision(38, 6);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.SNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.EMPLOYEE_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.EMPLOYER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.OTHER_VARIANCE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.OTHER_FEE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.TRANS_UNITS_R)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.TRANS_UNITS_V)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.RETIREE_DEPOSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.OLD_PFACODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.TRANS_UNITS)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.SENT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.PID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.NARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.V_DATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONTRIBUTIONTMP>()
        //        .Property(e => e.T_DATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.PARTYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.CONTACT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.INSTITUTION_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.BRANCH_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.BRANCH_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.BRANCH_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.CONTACT_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.CONTACT_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<COUNTER_PARTY>()
        //        .Property(e => e.BRANCH_ADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<currency>()
        //        .Property(e => e.currency_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<currency>()
        //        .Property(e => e.currency_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<currency>()
        //        .Property(e => e.selected)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<currency>()
        //        .Property(e => e.exchange_rate)
        //        .HasPrecision(12, 2);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.SCHEME_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.ACCOUNT_NUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.BANK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.PAYMENT_FREQ)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.EVIDENCE_ENCLOSED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.TERMINATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.TERMINATED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.PAYMENT_MADE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.REASON_RETIRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.WITHDRAWAL_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.BENEFICIARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.COMPANY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.BENEFICIARY_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.TERM_CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.TERM_CHECKED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.TOT_EMOL_MNL)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.RATE_OF_GRAT)
        //        .HasPrecision(5, 2);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.GRATUITY_TAKEN)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.SERVICE_YEARS)
        //        .HasPrecision(6, 4);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.UNIT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.PROG_WITHD_OPTION)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.RECORD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.GRATUITY_FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.PENSION_FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DB_WITH_PROCESS>()
        //        .Property(e => e.EMP_CATEGORY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.DIVIDEND1)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.PAID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.TAX)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.AVAILABLE_SHARES)
        //        .HasPrecision(20, 4);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.QTY_AVAILABLE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.OLD_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.COMPANY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.OLD_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DIVIDEND_RECEIVED>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.BATCH_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.DOCUMENT_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.PRC_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.USER_SUBMIT_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.PRIORITY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.FREQUENCY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.DAY_TIMING)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.BEGIN_TIME)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.BEGIN_DATE)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.START_DATETIME)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.END_DATETIME)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.SUBMIT_DATETIME)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.EXPIRATION_DATE)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.JOB_STATUS)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.JOB_ERROR)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.DOCSERVER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.JOB_SCRIPT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.JOB_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.JOB_DATA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.IP_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.ERROR_TEXT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.VERSION)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.IN_NAME_OF)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_PENDING_JOB>()
        //        .Property(e => e.JOB_PLATFORM)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_USER_LIST>()
        //        .Property(e => e.DOCUMENT_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<DS_USER_LIST>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE_PIN>()
        //        .Property(e => e.PFA_CODE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_PIN>()
        //        .Property(e => e.REG_ID)
        //        .HasPrecision(12, 0);

        //    modelBuilder.Entity<EMPLOYEE_PIN>()
        //        .Property(e => e.PIN_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_STATUS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_STATUS>()
        //        .Property(e => e.PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_STATUS>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_STATUS>()
        //        .Property(e => e.ACCT_STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_STATUS>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_STATUS>()
        //        .Property(e => e.USER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.FIELD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.PREVIOUS_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.CURRRENT_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.USER_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.UPDATE_STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEE_TRAIL>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.REGISTRATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SSN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.MARITAL_STATUS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PERMANENT_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NATIONALITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.LGA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.QUALIFICATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.OCCUPATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INDUSTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_OFFICE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_HOME_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYEE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_WEBSITE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_CONTACT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_INDUSTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_BUSINESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PICTURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SIGNATURE_URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SERIAL)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOTES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.APPROVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.CHECKED)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.CORRESPONDENCE_ADDS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.DEPARTMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PASSPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SIGNATURE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PRINTED_BY)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PICTURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SIGNATURE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.AGENT_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SALARY_SCALE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.POSTING_LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.MAIDEN_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PRODUCT1)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PRODUCT2)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PERCENTAGE2)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PRODUCT3)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PERCENTAGE3)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PRODUCT4)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PERCENTAGE4)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PRODUCT5)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PERCENTAGE5)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.INVEST_PERCENTAGE1)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_ADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYER_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.CORRESPONDENCE_ADDS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_STATECODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_CORRADDRESS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_CORRADDRESS2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_EMAILADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.CITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.STATE_OF_POSTING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PFA_TRANS_IN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.ACCT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.RSA_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.FORM_IMAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.BIOMETRICS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PIN_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.ER_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.ER_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.BIOMETRICS1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.NOK_COUNTRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EE_NO_OF_PRINTS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EE_PRINTED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EE_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.ER_PFC_BATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.OLD_EMPLOYEEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYEE_GROUP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.LOCATION_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.SAP_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.STAFF_GRADE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.REQ_BY_PENCOM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.UPLOAD_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.GRATUITY_RATE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.EMPLOYEE_CATEGORY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PIN_INVALID1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.PIN_NOTIFY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.APPROVED1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.FLAGNARRATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.FLAGDESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.TEAM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_ARCHIVE>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.TITLE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.LASTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.SEX)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.LGA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_PENCOM_DATA>()
        //        .Property(e => e.STATE_OF_ORIGIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_RETIREES_PROFILE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_RETIREES_PROFILE>()
        //        .Property(e => e.CRITERIA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_RETIREES_PROFILE>()
        //        .Property(e => e.PROFILE_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYEES_RETIREES_PROFILE>()
        //        .Property(e => e.TABLE_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EMPLOYER_NOTFUNDEDBYPENCOM>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_NOTFUNDEDBYPENCOM>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_NOTFUNDEDBYPENCOM>()
        //        .Property(e => e.ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EMPLOYER_PRIVATE_RET>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_PRIVATE_RET>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EMPLOYER_PRIVATE_RET>()
        //        .Property(e => e.ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.ADMIN_FEE)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.PAY_YEARS)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_ERRORLOG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_ERRORLOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_ERRORLOG>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_ERRORLOG>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<EXIT_PROCESS_PAYMENT_ERRORLOG>()
        //        .Property(e => e.PAYMENT_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.TOTAL_UNITS)
        //        .HasPrecision(30, 10);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.CURRENT_RATE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.OPENING_PRICE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.VALUATION_METHOD)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FAIR_VALUE_HISTORY>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEE_PERIODS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FEE_PERIODS>()
        //        .Property(e => e.PERIOD_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEE_PERIODS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FEE_PERIODS>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.FEE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.FEE_VALUE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.ROWID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.PERCENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.FREQUENCY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.VAT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEE_SETUP_VALUES>()
        //        .Property(e => e.VAT_PERCENT)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FEE_TRANSACTION>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Surname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Fisrtname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Othername)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Login_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Password11)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Department)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Role_Ad)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.success)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.fail)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.First)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Change)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.Password)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_log>()
        //        .Property(e => e.email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Surname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Fisrtname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Othername)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Login_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Password11)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Department)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Role_Ad)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.success)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.fail)
        //        .HasPrecision(1, 0);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.First)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Change)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.Password)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_Login>()
        //        .Property(e => e.email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_partial>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_partial>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_partial>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fidelity_partial>()
        //        .Property(e => e.ER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_States>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Fidelity_States>()
        //        .Property(e => e.ZONE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.TFC_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.STAFF_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.EMPLOYER_CONTRIBUTION)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.EMPLOYEE_CONTRIBUTION)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.VOLUNTARY_CONTRIBUTION)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.TOTAL_CONTRIBUTION)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.PENCOM_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.UPLOAD_DATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.UPLOAD_MONTH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.UPLOAD_YEAR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.TOTAL_UNIT)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.PERIOD_COVERD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.ID)
        //        .HasPrecision(30, 0);

        //    modelBuilder.Entity<FIDELITY_TCF_d66a2a9b>()
        //        .Property(e => e.PFA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.TFC_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.STAFF_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.EMPLOYEE_CONTRIBUTION)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.VOLUNTARY_CONTRIBUTION)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.TOTAL_CONTRIBUTION)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.PENCOM_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.UPLOAD_DATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.UNIT_PRICE)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.UPLOAD_MONTH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.UPLOAD_YEAR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.TOTAL_UNIT)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.PERIOD_COVERD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.ID)
        //        .HasPrecision(30, 0);

        //    modelBuilder.Entity<FIDELITY_TCF_dcaf21ce>()
        //        .Property(e => e.PFA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.TFC_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.STAFF_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.FLAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.PENCOM_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.UPLOAD_DATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.UPLOAD_MONTH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.UPLOAD_YEAR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.LOCATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.TOTAL_UNIT)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.DESIGNATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.PERIOD_COVERD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.ID)
        //        .HasPrecision(30, 0);

        //    modelBuilder.Entity<FIDELITY_TCF_OLD>()
        //        .Property(e => e.PFA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.s_no)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.title)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.surname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.othernames)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.gender)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.dob)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.dofa)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.employer_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.lga)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.state)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FidPen_EmployeesRD_Dec2016>()
        //        .Property(e => e.reg_date)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM_BATCH>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM_BATCH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM_BATCH>()
        //        .Property(e => e.RECEIVED_FROM)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FORM_BATCH>()
        //        .Property(e => e.RECEIVED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FORM_BATCH>()
        //        .Property(e => e.TOTAL_RECEIVED)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<FORM_BATCH>()
        //        .Property(e => e.TOTAL_CHECKED)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<FORM_BATCH>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<FORM_BATCH>()
        //        .Property(e => e.COMMENTS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.FORM_REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.BRANCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.EMPLOYER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.OTHERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FORM>()
        //        .Property(e => e.FORMS_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<fpml_staff_fidalert_test>()
        //        .Property(e => e.surname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fpml_staff_fidalert_test>()
        //        .Property(e => e.firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fpml_staff_fidalert_test>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fpml_staff_fidalert_test>()
        //        .Property(e => e.email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<fpml_staff_fidalert_test>()
        //        .Property(e => e.mobile_phone)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FUND_PERFORMANCE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FUND_PERFORMANCE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<GRADUATED_MGMT_FEES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<GRADUATED_MGMT_FEES>()
        //        .Property(e => e.FEE_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<GRADUATED_MGMT_FEES>()
        //        .Property(e => e.SEQNO)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<GRADUATED_MGMT_FEES>()
        //        .Property(e => e.PERCENTAGE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<GRADUATED_MGMT_FEES>()
        //        .Property(e => e.DAYS_IN_PERIOD)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<ID_TYPE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<ID_TYPE>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INCENTIVE_FEES>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INCENTIVE_FEES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INCENTIVE_FEES>()
        //        .Property(e => e.TARGET_RETURN)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<INCENTIVE_FEES>()
        //        .Property(e => e.ACTUAL_RETURN)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<INCENTIVE_FEES>()
        //        .Property(e => e.EXCESS_RETURN_PERCENTAGE)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<INCENTIVE_FEES>()
        //        .Property(e => e.INCENTIVE_FEE_PERCENTAGE)
        //        .HasPrecision(6, 2);

        //    modelBuilder.Entity<INCENTIVE_FEES>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INCENTIVE_FEES>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<INSTR_CHARGE_SETUP_VALUES>()
        //        .Property(e => e.TEMPLATE_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTR_CHARGE_SETUP_VALUES>()
        //        .Property(e => e.INSTRUMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTR_CHARGE_SETUP_VALUES>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTR_CHARGE_SETUP_VALUES>()
        //        .Property(e => e.RATE)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<INSTR_CHARGE_SETUP_VALUES>()
        //        .Property(e => e.CHARGE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTR_CHARGE_SETUP_VALUES>()
        //        .Property(e => e.ROWID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INSTR_CHARGE_SETUP_VALUES>()
        //        .Property(e => e.BOND_CHARGE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTR_CHARGE_SETUP_VALUES>()
        //        .Property(e => e.REAL_CHARGE_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.INSTRUMENT_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.MONEY_MARKET_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.Rowid)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.BENCHMARK)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.INSTITUTION_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.FUND_BENCHMARK)
        //        .HasPrecision(8, 2);

        //    modelBuilder.Entity<INSTRUMENT>()
        //        .Property(e => e.VALUATION_METHOD)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INTEREST_RATES>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INTEREST_RATES>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<INTEREST_RATES>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.OFFER_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.BID_PRICE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.TRANS_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.SALES_PERCENT)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.REP_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.TRANS_STAT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.UPLOADED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.CERTIFICATE_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.FLAGGED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.CERTIFICATE_UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.FLAG_NARATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.INVESTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.PFA_SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.SCHEME_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.PAYMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<inv>()
        //        .Property(e => e.SBATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTMENT_RPT>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<INVESTMENT_RPT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INVESTMENT_RPT>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INVESTMENT_RPT>()
        //        .Property(e => e.MARKET_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTMENT_RPT>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_BENEFICIARIES>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<INVESTOR_BENEFICIARIES>()
        //        .Property(e => e.BRANCH_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_BENEFICIARIES>()
        //        .Property(e => e.FULLNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_BENEFICIARIES>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_BENEFICIARIES>()
        //        .Property(e => e.RELATIONSHIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<INVESTOR_BENEFICIARIES>()
        //        .Property(e => e.PERCENTAGE)
        //        .HasPrecision(15, 2);

        //    modelBuilder.Entity<INVESTOR_BENEFICIARIES>()
        //        .Property(e => e.SERIAL_NO)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MILITARY_EE_ER>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.surname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.othernames)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.employee_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.ssn)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.mobile_phone)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.employer_rcno)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<military_outstanding>()
        //        .Property(e => e.employer_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.TENOR)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.REMAIN_TENOR)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.TERMINATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.TRANS_CHECK)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.ORIGINAL_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.CURRENT_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.COUNTER_PARTY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.REFERENCE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.CONTROL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.INITIATING_REPO)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.COUPON_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.REPO_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.REPO_FLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.TRANS_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.CHARGE_FEE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.CAJOURNAL_TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.COUNTER_PARTY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.CHECKED2)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.OLD_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.TERMINATED_TO_RECEIVABLE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.RECEIVABLE_TRANSID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.RECEIVABLE_TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.TRANSFERRED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET>()
        //        .Property(e => e.FROM_SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.NEW_SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.INSTRUMENT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.TENOR)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.REMAIN_TENOR)
        //        .HasPrecision(6, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.TERMINATED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.TRANS_CHECK)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CURRENCY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.ORIGINAL_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CURRENT_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.COUNTER_PARTY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.REFERENCE_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CONTROL)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.INITIATING_REPO)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.COUPON_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.REPO_RATE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.REPO_FLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.TRANS_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CHARGE_FEE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CAJOURNAL_TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.COUNTER_PARTY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CHECKED2)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.DISCOUNT_RATE)
        //        .HasPrecision(10, 6);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.CURRENT_PRICE)
        //        .HasPrecision(20, 15);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.TERMINATED_TO_RECEIVABLE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.RECEIVABLE_TRANSID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.RECEIVABLE_TYPE_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MONEY_MARKET_TRANSFER>()
        //        .Property(e => e.POSTED_NEWFUND)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_DETAILS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<NEW_EXIT_DETAILS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_DETAILS>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_DETAILS>()
        //        .Property(e => e.CLIENT_STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_DETAILS>()
        //        .Property(e => e.ACCOUNT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_DETAILS>()
        //        .Property(e => e.ACCOUNT_NUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_DETAILS>()
        //        .Property(e => e.BANK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_ERRORLOG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<NEW_EXIT_ERRORLOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_ERRORLOG>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_ERRORLOG>()
        //        .Property(e => e.BATCH_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.NAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.SECTOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.RETIREMENTTYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.EMPLOYERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.EMPLOYEE_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<NEW_EXIT_RETIREEDETAILS>()
        //        .Property(e => e.PROCESSINGSTATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<nigerstate>()
        //        .Property(e => e.SYB_IDENTITY_COL)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<nigerstate>()
        //        .Property(e => e.EMPLOYER_RNCO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<nigerstate>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<nigerstate>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PARTLY_FUNDED>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PARTLY_FUNDED>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PARTLY_FUNDED>()
        //        .Property(e => e.MAX_MONTH)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PARTLY_FUNDED_ER>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PARTLY_FUNDED_ER>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PARTLY_FUNDED_ER>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PARTLY_FUNDED_ER>()
        //        .Property(e => e.ER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PARTLY_FUNDED_ER>()
        //        .Property(e => e.OUTSTANDING_MONTH)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PARTLY_FUNDED_ER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_tnam)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_ownr)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_cnam)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_labl)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_hdr)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_mask)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_ptrn)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_bmap)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_init)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_cmnt)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_edit)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatcol>()
        //        .Property(e => e.pbc_tag)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatedt>()
        //        .Property(e => e.pbe_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatedt>()
        //        .Property(e => e.pbe_edit)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatedt>()
        //        .Property(e => e.pbe_work)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatfmt>()
        //        .Property(e => e.pbf_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatfmt>()
        //        .Property(e => e.pbf_frmt)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbt_tnam)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbt_ownr)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbd_fitl)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbd_funl)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbd_ffce)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbh_fitl)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbh_funl)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbh_ffce)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbl_fitl)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbl_funl)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbl_ffce)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcattbl>()
        //        .Property(e => e.pbt_cmnt)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatvld>()
        //        .Property(e => e.pbv_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatvld>()
        //        .Property(e => e.pbv_vald)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pbcatvld>()
        //        .Property(e => e.pbv_msg)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOMEMPLOYER>()
        //        .Property(e => e.SYB_IDENTITY_COL)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PENCOMEMPLOYER>()
        //        .Property(e => e.EMPLOYER_RNCO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOMEMPLOYER>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PENCOMEMPLOYER>()
        //        .Property(e => e.EMPLOYER_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR1000>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAAWBR1000>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR1000>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR1000>()
        //        .Property(e => e.scheme_desc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR1000>()
        //        .Property(e => e.legacy_amount_received)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR1000>()
        //        .Property(e => e.amount_payable)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR200>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAAWBR200>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR200>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR200>()
        //        .Property(e => e.amount_paid_under_pra)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR200>()
        //        .Property(e => e.amount_recieved_to_rsa)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR200>()
        //        .Property(e => e.amount_requested_from_rsa)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR300>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAAWBR300>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR300>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR300>()
        //        .Property(e => e.enbloc_payment)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.insurance_company_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.annual_total_emolument)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.rsa_balance)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.premium)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.lumpsum)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.monthly_annuity)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR700>()
        //        .Property(e => e.employer_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR800>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAAWBR800>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR800>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWBR800>()
        //        .Property(e => e.total_voluntary_contribution)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR800>()
        //        .Property(e => e.total_amount)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR800>()
        //        .Property(e => e.amount_requested)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR800>()
        //        .Property(e => e.tax_deducted)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWBR800>()
        //        .Property(e => e.amount_payable_net_tax)
        //        .HasPrecision(30, 2);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.fraud_code)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.fraud_status)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.action_taken)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.fullname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.gender)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.origin_code_state)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.permanent_home_address)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.staff)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.nationality)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAAWCR200>()
        //        .Property(e => e.passport_number)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR1001>()
        //        .Property(e => e.transid)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMFR1001>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR1001>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR1001>()
        //        .Property(e => e.unknown_employee)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR1600>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR1600>()
        //        .Property(e => e.PAYMENT_INSTRUMENT_REFERENCE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR1600>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMFR2000>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2000>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2000>()
        //        .Property(e => e.nsitf_membership_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2000>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMFR2100>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2100>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2100>()
        //        .Property(e => e.contributor_pfa)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2100>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMFR2200>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2200>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2200>()
        //        .Property(e => e.contributor_pfa)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2200>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMFR2500>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2500>()
        //        .Property(e => e.insurance_company_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2500>()
        //        .Property(e => e.no_of_rsas)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<PFAMFR2500>()
        //        .Property(e => e.no_of_employees)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<PFAMFR2500>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMFR2600>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2600>()
        //        .Property(e => e.no_of_rsas)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<PFAMFR2600>()
        //        .Property(e => e.no_of_employees)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<PFAMFR2600>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMFR2700>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMFR2700>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2700>()
        //        .Property(e => e.employer_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMFR2700>()
        //        .Property(e => e.remark_reasons)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMMR200>()
        //        .Property(e => e.ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<PFAMMR200>()
        //        .Property(e => e.employee_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMMR200>()
        //        .Property(e => e.employee_id_file_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMMR200>()
        //        .Property(e => e.gender)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMMR200>()
        //        .Property(e => e.membership_status)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PFAMMR200>()
        //        .Property(e => e.scheme_id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<pin_invalidation>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_invalidation>()
        //        .Property(e => e.INVALID_PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_invalidation>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_invalidation>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_invalidation>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_invalidation>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_invalidation>()
        //        .Property(e => e.EMPLOYER_RCNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<pin_invalidation>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINDELETE>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PINDELETE>()
        //        .Property(e => e.INVESTOR_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RE_TENANCY_AGREEMENTS>()
        //        .Property(e => e.AGREEMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RE_TENANCY_AGREEMENTS>()
        //        .Property(e => e.TENANT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RE_TENANCY_AGREEMENTS>()
        //        .Property(e => e.TERM_MONTHS)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<RE_TENANCY_AGREEMENTS>()
        //        .Property(e => e.COMMISSION_RATE)
        //        .HasPrecision(14, 4);

        //    modelBuilder.Entity<RE_TENANCY_AGREEMENTS>()
        //        .Property(e => e.AGENT_ID)
        //        .HasPrecision(3, 0);

        //    modelBuilder.Entity<RE_TENANCY_AGREEMENTS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.TENANT_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.AGREEMENT_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RE_TENANCY_PAYMENTS>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RE_TENANTS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RE_TENANTS>()
        //        .Property(e => e.TENANT_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RE_TENANTS>()
        //        .Property(e => e.TENANT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RE_TENANTS>()
        //        .Property(e => e.PROPERTY_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RE_TENANTS>()
        //        .Property(e => e.APARTMENT_DESC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RE_TENANTS>()
        //        .Property(e => e.CONTACT_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE_MAINTENANCE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<REAL_ESTATE_MAINTENANCE>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<REAL_ESTATE_MAINTENANCE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REAL_ESTATE_MAINTENANCE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REAL_ESTATE_MAINTENANCE>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REAL_ESTATE_MAINTENANCE>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.IDNO)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(8, 4);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.UNITS)
        //        .HasPrecision(18, 4);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REMITTANCE>()
        //        .Property(e => e.REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.RENTID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RENT>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.INITIATING_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.COMPANY_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RENT_RECEIVED>()
        //        .Property(e => e.POST_USER)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REP_AGENTS>()
        //        .Property(e => e.REP_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<REP_AGENTS>()
        //        .Property(e => e.REP_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REP_AGENTS>()
        //        .Property(e => e.REP_ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REP_AGENTS>()
        //        .Property(e => e.REP_EMAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REP_AGENTS>()
        //        .Property(e => e.REP_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REP_AGENTS>()
        //        .Property(e => e.GROUP_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<REP_AGENTS>()
        //        .Property(e => e.REPORT_ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_BALANCE>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_BALANCE>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.MSGID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.FROMNUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.FROMALPHA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.TEL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.HEADER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.MSG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS>()
        //        .Property(e => e.CONTENTFRIENDTEL)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.FIRSTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.OTHERNAMES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.MSGID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.FROMNUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.FROMALPHA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.TEL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.HEADER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.MSG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RPT_NOTIFICATION_SMS_LOG>()
        //        .Property(e => e.CONTENTFRIENDTEL)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<RSA_SECTOR>()
        //        .Property(e => e.SECTOR)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<RSA_SECTOR>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_PASSWORDLOG>()
        //        .Property(e => e.USER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_PASSWORDLOG>()
        //        .Property(e => e.PASSWORD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_PASSWORDLOG>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_POLICY>()
        //        .Property(e => e.PASS_FORMAT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_POLICY>()
        //        .Property(e => e.AUTO_RESET_EXPIRY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_POLICY>()
        //        .Property(e => e.EXPIRED_PRIVILEGES)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_POLICY>()
        //        .Property(e => e.ENFORCE_POLICY)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_POLICY>()
        //        .Property(e => e.DEFAULT_PASSWORD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_POLICY>()
        //        .Property(e => e.TRANS_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_USER_FUNDS>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_USER_FUNDS>()
        //        .Property(e => e.SCHEMEID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<S_WEBUSERLOG>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<S_WEBUSERLOG>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(20, 0);

        //    modelBuilder.Entity<S_WEBUSERLOG>()
        //        .Property(e => e.USERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSERLOG>()
        //        .Property(e => e.REMOTE_ADDR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSERLOG>()
        //        .Property(e => e.ACTIVITY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<S_WEBUSERLOG>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.SCHEDULE_ID)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.TRANS_TYPE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE_TRANSFER>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.IDNO)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.SCHEDULE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.POSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.PROCESSED_BY)
        //        .HasPrecision(15, 0);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.COMMENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.IDNO2)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.CLEARED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.VPOSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.VPOSTED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.FUND_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.RETURNED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.SCHEDULE_STATUS)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.REVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.VREVERSAL_POSTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEDULE>()
        //        .Property(e => e.REFNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME_SETUP>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<SCHEME_SETUP>()
        //        .Property(e => e.SCHEME_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME_SETUP>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SCHEME_SETUP>()
        //        .Property(e => e.PFC_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.SYMBOL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.PREV_CLOSE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.OPEN_PRICE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.HIGH_PRICE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.LOW_PRICE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.CLOSE_PRICE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.CHANGE)
        //        .HasPrecision(12, 4);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.TRADES)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.VOLUME)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<STOCK_PRICES>()
        //        .Property(e => e.TRADE_VALUE)
        //        .HasPrecision(20, 2);

        //    modelBuilder.Entity<tbl_formRefNOTEMP>()
        //        .Property(e => e.Form_refno)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_pinxxx>()
        //        .Property(e => e.pin)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_pre_multifund_units>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_pre_multifund_units>()
        //        .Property(e => e.UNITS)
        //        .HasPrecision(38, 4);

        //    modelBuilder.Entity<tbl_tempsms>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_tempsms>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_tempsms>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_tempsms_03082017>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_tempsms_03082017>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_tempsms_03082017>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_tempsms2>()
        //        .Property(e => e.SURNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_tempsms2>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_tempsms2>()
        //        .Property(e => e.MOBILE_PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.id)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.title)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.surname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.middleName)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.gender)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.maritalStatus)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.nationality)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.stateOfOrigin)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.lga_code)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.sectorClass)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.lga_residence)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.state_residence)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.zipCode)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<tbl_transitional_pin_result>()
        //        .Property(e => e.designation)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TROI_COMPUTATION_HEADER>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TROI_COMPUTATION_HEADER>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<TROI_COMPUTATION_HEADER>()
        //        .Property(e => e.TOTAL_DAYS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<TROI_COMPUTATION_HEADER>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TROI_COMPUTATION_HEADER>()
        //        .Property(e => e.WATBR)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<TROI_COMPUTATION_HEADER>()
        //        .Property(e => e.WATBR_USED)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<TROI_COMPUTATION_HEADER>()
        //        .Property(e => e.ADDED_PERCENTAGE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<TROI_COMPUTATIONS>()
        //        .Property(e => e.INTEREST_RATE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<TROI_COMPUTATIONS>()
        //        .Property(e => e.NO_OF_DAYS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<TROI_COMPUTATIONS>()
        //        .Property(e => e.TOTAL_DAYS)
        //        .HasPrecision(5, 0);

        //    modelBuilder.Entity<TROI_COMPUTATIONS>()
        //        .Property(e => e.WEIGHTED_RATE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<TROI_COMPUTATIONS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TROI_COMPUTATIONS>()
        //        .Property(e => e.SCHEME_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<TROI_GROWTHS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TROI_GROWTHS>()
        //        .Property(e => e.TROI_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TROI_GROWTHS>()
        //        .Property(e => e.GROWTH_RATE)
        //        .HasPrecision(16, 4);

        //    modelBuilder.Entity<TROI_PERIODS>()
        //        .Property(e => e.NO_OF_DAYS)
        //        .HasPrecision(4, 0);

        //    modelBuilder.Entity<TROI_PERIODS>()
        //        .Property(e => e.WEIGHTED_RATE)
        //        .HasPrecision(10, 4);

        //    modelBuilder.Entity<TROI_PERIODS>()
        //        .Property(e => e.TRANSID)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<TROI_PERIODS>()
        //        .Property(e => e.TROI_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Welcome>()
        //        .Property(e => e.Title)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Welcome>()
        //        .Property(e => e.Contents)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Welcome>()
        //        .Property(e => e.pr1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Welcome>()
        //        .Property(e => e.pr2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Welcome>()
        //        .Property(e => e.pr3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Welcome>()
        //        .Property(e => e.pr4)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Welcome>()
        //        .Property(e => e.pr5)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL>()
        //        .Property(e => e.PIN)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL>()
        //        .Property(e => e.PFA_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL>()
        //        .Property(e => e.CHECKED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WITHDRAWAL>()
        //        .Property(e => e.CHECKED_BY)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<WITHDRAWAL>()
        //        .Property(e => e.WITHDRAWAL_ID)
        //        .HasPrecision(10, 0);

        //    modelBuilder.Entity<XML_EMPLOYER_DETAILS_RMAS>()
        //        .Property(e => e.EMPLOYER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<XML_EMPLOYER_DETAILS_RMAS>()
        //        .Property(e => e.EMPLOYER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<YouTubeVideo>()
        //        .Property(e => e.url)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<YouTubeVideo>()
        //        .Property(e => e.description)
        //        .IsUnicode(false);


        // }

        //public DbQuery<T> Query<T>() where T : class
        //{
        //    return Set<T>().AsNoTracking();
        //}
        #endregion

    }
}