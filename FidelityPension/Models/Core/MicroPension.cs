using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FidelityPension.Models.Core
{
    public class MicroPension : BaseEntity
    {
        public string AppId { get; set; }
        public string PIN { get; set; }
        public string Passport { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string MaidenName { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DOB { get; set; }
        public string PlaceOfBirth { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Phone]
        public string MobileNo { get; set; }
        public string NIN { get; set; }
        public int BVN { get; set; }
        public int IPN { get; set; }
        public int NATIONALITY_ID { get; set; }
        public virtual Country Country { get; set; }
        public int STATE_OF_ORIGIN_ID { get; set; }
        public virtual State State { get; set; }
        public int LGA_ID { get; set; }
        public virtual City LGA { get; set; }
        public string Signature_Url { get; set; }
        public string SectorCode { get; set; }
        public string Employer_RC_No { get; set; }
        public string Employer_Name { get; set; }
        public string Employer_Office_Address { get; set; }
        public string Employer_State { get; set; }
        public string Designation { get; set; }
        public int? SecurityCode { get; set; }
        public int NotificationSetup { get; set; }
        public int Identification_Docx_Presented { get; set; }
        public string Identification_Docx_Presented_Url { get; set; }
        public bool HasAcceptedTnC { get; set; }

        public string Left_Thumb { get; set; }
        public string Right_Thumb { get; set; }
        public string Left_Index { get; set; }
        public string Right_Index { get; set; }
        public string Left_MiddleFinger { get; set; }
        public string Right_MiddleFinger { get; set; }
        public string Left_RingFinger { get; set; }
        public string Right_RingFinger { get; set; }
        public string Left_LittleFinger { get; set; }
        public string Right_LittleFinger { get; set; }
        public string AgentCode { get; set; }
        public bool HasExistingPensionAdministrator { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}