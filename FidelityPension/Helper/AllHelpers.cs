using FidelityPension.Models;
using FidelityPension.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FidelityPension.Helper
{
    public class AllHelpers
    {
        public static IEnumerable<SelectListItem> Gender()
        {
            var list = new List<SelectListItem>()
            {

                //new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Male", Value = "Male"},
                new SelectListItem {Text = "Female", Value = "Female"}
            };
            return list;
        }



        public static IEnumerable<SelectListItem> MaritalStatus()
        {
            var list = new List<SelectListItem>()
            {
               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Married", Value = "MD"},
                new SelectListItem {Text = "Single", Value = "SG"},
                new SelectListItem {Text = "Divorced", Value = "DV"},
                new SelectListItem {Text = "Widowed", Value = "WD"},
                new SelectListItem {Text = "Separated", Value = "SP"}
            };
            return list;
        }

        public static IEnumerable<SelectListItem> Title()
        {
            var list = new List<SelectListItem>()
            {

               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Mr", Value = "Mr"},
                new SelectListItem {Text = "Mrs", Value = "Mrs"},
                new SelectListItem {Text = "Miss", Value = "Miss"},
                new SelectListItem {Text = "Ms", Value = "Ms"}
            };
            return list;
        }

        public static IEnumerable<SelectListItem> Sector()
        {
            var list = new List<SelectListItem>()
            {

               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "01 Public", Value = "01"},
                new SelectListItem {Text = "02 Private", Value = "02"},
                new SelectListItem {Text = "03 Micro Pension", Value = "03"},
                new SelectListItem {Text = "04 Cross Border", Value = "04"}
            };
            return list;
        }

        public static IEnumerable<SelectListItem> EmployerUnderIPPIS()
        {
            var list = new List<SelectListItem>()
            {

               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Yes", Value = "true"},

                new SelectListItem {Text = "No", Value = "false"}
            };
            return list;
        }

        public static IEnumerable<SelectListItem> Location()
        {
            var list = new List<SelectListItem>()
            {

               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Nigeria", Value = "Nigeria"},

                new SelectListItem {Text = "Abroad", Value = "Abroad"}
            };
            return list;
        }

        public static IEnumerable<SelectListItem> RsaStatus()
        {
            var list = new List<SelectListItem>()
            {

               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Active", Value = "1"},

                new SelectListItem {Text = "Retiree", Value = "2"}
            };
            return list;
        }
        public static IEnumerable<SelectListItem> Frequency()
        {
            var list = new List<SelectListItem>()
            {

               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Monthly", Value = "1"},

                new SelectListItem {Text = "Quarterly", Value = "2"},
                 new SelectListItem {Text = "Bi-Annual", Value = "3"},
                new SelectListItem {Text = "Annual", Value = "4"}
            };
            return list;
        }

        //public static IEnumerable<SelectListItem> GetState()
        //{
        //    var list = new List<SelectListItem>()
        //    {

        //       // new SelectListItem {Text = "-- Select Option --", Value = ""},
        //        new SelectListItem {Text = "Abuja", Value = "1"},

        //        new SelectListItem {Text = "Lagos", Value = "2"}
        //    };
        //    return list;
        //}


        public static List<SelectListItem> GetAllState(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.States
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            }

            return items;

        }

        public static List<SelectListItem> GetAllLGAs(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.LGAs
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            }

            return items;

        }


        public static List<SelectListItem> GetState(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.States
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            //foreach (var ts in classlists)
            //{
            //    items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            //}

            return items;

        }

        public static List<SelectListItem> GetLGAs(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.LGAs
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            //foreach (var ts in classlists)
            //{
            //    items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            //}

            return items;

        }

        public static IEnumerable<SelectListItem> Relationship()
        {
            var list = new List<SelectListItem>()
            {

               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Husband", Value = "Husband"},
                 new SelectListItem {Text = "Wife", Value = "Wife"},
                new SelectListItem {Text = "Brother", Value = "Brother"},
                new SelectListItem {Text = "Sister", Value = "Sister"},
                new SelectListItem {Text = "Nephrew", Value = "Nephrew"},
                new SelectListItem {Text = "Niece", Value = "Niece"},
                new SelectListItem {Text = "Uncle", Value = "Uncle"},
                new SelectListItem {Text = "Aunthy", Value = "Aunthy"}
            };
            return list;
        }

        public static List<SelectListItem> GetTitle(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.Titles
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            }

            return items;

        }

        public static List<SelectListItem> GetSectorClassification(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.SectorClassifications
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            }

            return items;

        }

        public static List<SelectListItem> GetMaritalStatus(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.MaritalStatus
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            }

            return items;

        }

        public static List<SelectListItem> GetGender(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.Genders
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            }

            return items;

        }

        public static List<SelectListItem> GetRelationship(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.Relationships
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            }

            return items;

        }

        public static List<SelectListItem> GetCountries(object value = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var classlists = from cs in db.Countries
                             select cs;



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.Value.ToString(), Value = (ts.Id).ToString() });
            }

            return items;

        }

        public static List<SelectListItem> GetEmployers(object value = null)
        {
         PfaDbContext1 db = new PfaDbContext1();

        var classlists = (from cs in db.EMPLOYER_DETAILS
                             select cs).Take(1000);



            List<SelectListItem> items = new List<SelectListItem>();
            // items.Add(new SelectListItem { Text = "- Select Country -", Value = "" });

            foreach (var ts in classlists)
            {
                items.Add(new SelectListItem { Text = ts.NAME.ToString(), Value = (ts.NAME).ToString() });
            }

            return items;

        }
    }
}