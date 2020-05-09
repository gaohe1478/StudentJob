using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartTimeJob.Models;

namespace PartTimeJob.Controllers
{
    public class ViewBodyController : Controller
    {

        public IActionResult ViewBodyPerson()
        {
            return View();
        }
        public IActionResult Viewc()
        {
            using (var db = new parttimejobContext())
            {
                var Result = db.Recruit.ToList();

                ViewBag.Result = Result;

                return View();
            }


        }
        public IActionResult Viewp()
        {
            using (var db = new parttimejobContext())
            {
                var Result = db.Recruit.ToList();

                ViewBag.Result = Result;

                return View();
            }


        }
        public IActionResult ViewBodySearch(DateTime StartTime, string Salary, string Job)
        {
            using (var db = new parttimejobContext())
            {


                DateTime dt;
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy-MM-dd";
                dt = Convert.ToDateTime("2000-01-01", dtFormat);
                //var Res = db.Recruit.Where(b => b.RStartDate < StartTime ).ToList();
                if (Job == null && StartTime == dt && Salary == null)
                {
                    return View("Index","Home");
                }

                if (Job != "其他")
                {
                    var Res = db.Recruit.ToList();
                    if (Job != null)
                    {
                        Res = Res.Where(b => b.RType == Job).ToList();
                    }
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }


                    if (StartTime != dt)
                    {
                        Res = Res.Where(b => (DateTime.Compare(b.REndDate.Value, StartTime) > 0 || DateTime.Compare(b.REndDate.Value, StartTime) == 0) && (DateTime.Compare(b.RStartDate.Value, StartTime) < 0 || DateTime.Compare(b.RStartDate.Value, StartTime) == 0)).ToList();
                    }
                    //var Res = db.Recruit.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                    //var Res1 = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    //var Res2 = Res1.Where(b => b.RType == Job).ToList();
                    //var Res3 = Res2.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();

                    ViewBag.Result = Res;
                    return View();
                }
                else
                {
                    var Res = db.Recruit.ToList();
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }
                    if (StartTime != null)
                    {
                        Res = Res.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();
                    }

                    //var Res3 = Res1.Where(b => b.REndDate > StartTime).ToList();
                    //var Res4 = Res3.Where(b => b.RStartDate < StartTime).ToList();
                    ViewBag.Result = Res;
                    return View();
                }


            }


        }
        public IActionResult ViewBodySearchp(DateTime StartTime, string Salary, string Job)
        {
            using (var db = new parttimejobContext())
            {


                DateTime dt;
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy-MM-dd";
                dt = Convert.ToDateTime("2000-01-01", dtFormat);
                //var Res = db.Recruit.Where(b => b.RStartDate < StartTime ).ToList();
                if (Job == null && StartTime == dt && Salary == null)
                {
                    return RedirectToAction("Viewp");
                }

                if (Job != "其他")
                {
                    var Res = db.Recruit.ToList();
                    if (Job != null)
                    {
                        Res = Res.Where(b => b.RType == Job).ToList();
                    }
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }


                    if (StartTime != dt)
                    {
                        Res = Res.Where(b => (DateTime.Compare(b.REndDate.Value, StartTime) > 0 || DateTime.Compare(b.REndDate.Value, StartTime) == 0) && (DateTime.Compare(b.RStartDate.Value, StartTime) < 0 || DateTime.Compare(b.RStartDate.Value, StartTime) == 0)).ToList();
                    }
                    //var Res = db.Recruit.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                    //var Res1 = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    //var Res2 = Res1.Where(b => b.RType == Job).ToList();
                    //var Res3 = Res2.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();

                    ViewBag.Result = Res;
                    return View();
                }
                else
                {
                    var Res = db.Recruit.ToList();
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }
                    if (StartTime != null)
                    {
                        Res = Res.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();
                    }

                    //var Res3 = Res1.Where(b => b.REndDate > StartTime).ToList();
                    //var Res4 = Res3.Where(b => b.RStartDate < StartTime).ToList();
                    ViewBag.Result = Res;
                    return View();
                }


            }


        }
        public IActionResult ViewBodySearchc(DateTime StartTime, string Salary, string Job)
        {
            using (var db = new parttimejobContext())
            {


                DateTime dt;
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy-MM-dd";
                dt = Convert.ToDateTime("2000-01-01", dtFormat);
                //var Res = db.Recruit.Where(b => b.RStartDate < StartTime ).ToList();
                if (Job == null && StartTime == dt && Salary == null)
                {
                    return RedirectToAction("Viewc");
                }

                if (Job != "其他")
                {
                    var Res = db.Recruit.ToList();
                    if (Job != null)
                    {
                        Res = Res.Where(b => b.RType == Job).ToList();
                    }
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }


                    if (StartTime != dt)
                    {
                        Res = Res.Where(b => (DateTime.Compare(b.REndDate.Value, StartTime) > 0 || DateTime.Compare(b.REndDate.Value, StartTime) == 0) && (DateTime.Compare(b.RStartDate.Value, StartTime) < 0 || DateTime.Compare(b.RStartDate.Value, StartTime) == 0)).ToList();
                    }
                    //var Res = db.Recruit.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                    //var Res1 = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    //var Res2 = Res1.Where(b => b.RType == Job).ToList();
                    //var Res3 = Res2.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();

                    ViewBag.Result = Res;
                    return View();
                }
                else
                {
                    var Res = db.Recruit.ToList();
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }
                    if (StartTime != null)
                    {
                        Res = Res.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();
                    }

                    //var Res3 = Res1.Where(b => b.REndDate > StartTime).ToList();
                    //var Res4 = Res3.Where(b => b.RStartDate < StartTime).ToList();
                    ViewBag.Result = Res;
                    return View();
                }


            }


        }
        public static Match GetValueAnd(string text)
        {
            string regex = @"(\d+)\D+(\d+.)";
            Match mstr = Regex.Match(text, regex);
            Console.WriteLine(mstr.Groups[1].Value + " " + mstr.Groups[2].Value);
            return mstr;
        }
        public IActionResult ViewApplicant()
        {
            using (var db = new parttimejobContext())
            {
                var Res = db.Recruit.ToList();
                for (int i = 0; i < Res.Count; i++)
                {
                    var temp1 = db.Intention.Where(a => a.RId == Res[i].RId).ToList();
                    for (int j = 0; j < temp1.Count; j++)
                    {
                        if (common.key == temp1[j].AId)
                        {
                            Res.Remove(Res[i]);
                        }
                    }
                }
                ViewBag.Result = Res;
                return View();
            }

        }
        public IActionResult ViewAdmin()
        {
            using (var db = new parttimejobContext())
            {
                var Res = db.Recruit.ToList();
                ViewBag.Result = Res;
                return View();
            }

        }

        public IActionResult ViewAdminDelete(IFormCollection collection)
        {
            using (var db = new parttimejobContext())
            {
                //var id = System.Web.HttpUtility.UrlDecode(RId);
                //var id = Request.Form["RId"].ToString();
                //var id = request["id"];
                string id = collection["RId"];
                var Res = db.Recruit.FirstOrDefault(b => b.RId == id);
                db.Remove(Res);
                db.SaveChanges();
                var script = String.Format("<script>alert('Delete Successful!');location.href = '{0}'</script>", Url.Action("ViewAdmin"));
                return Content(script, "text/html");
                
            }

        }

        public IActionResult ViewApplicantSend(IFormCollection collection)
        {
            using (var db = new parttimejobContext())
            {
                var appinfo = db.Applicantinfo.FirstOrDefault(a => a.AId == common.key);
                if (appinfo == null)
                {
                    var script = String.Format("<script>alert('Your information is not found!');location.href = '{0}'</script>", Url.Action("ViewApplicant"));
                    return Content(script, "text/html");

                    //return RedirectToAction("ViewApplicant");
                }
                else
                {
                    string id = collection["RId"];
                    var Res = db.Recruit.FirstOrDefault(b => b.RId == id);
                    var ApplicantId = db.Applicant.FirstOrDefault(b => b.AId == common.key);
                    var TempIntention = new Intention();
                    TempIntention.AId = ApplicantId.AId;
                    TempIntention.RId = Res.RId;
                    TempIntention.IStatus =  "确认中";
                    string date = DateTime.Now.ToLocalTime().ToString();
                    DateTime date1 = Convert.ToDateTime(date);
                    TempIntention.ICreateTime = date1;
                    db.Intention.Add(TempIntention);
                    db.SaveChanges();
                    var script = String.Format("<script>alert('Your application has been sent!');location.href = '{0}'</script>", Url.Action("ViewApplicant"));
                    return Content(script, "text/html");



                    
                }

                
            }

        }
        public IActionResult ViewAdminSearch(DateTime StartTime, string Salary, string Job)
        {
            using (var db = new parttimejobContext())
            {


                DateTime dt;
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy-MM-dd";
                dt = Convert.ToDateTime("2000-01-01", dtFormat);
                //var Res = db.Recruit.Where(b => b.RStartDate < StartTime ).ToList();
                if (Job == null && StartTime == dt && Salary == null)
                {
                    return RedirectToAction("ViewAdmin");
                }

                if (Job != "其他")
                {
                    var Res = db.Recruit.ToList();
                    if (Job != null)
                    {
                        Res = Res.Where(b => b.RType == Job).ToList();
                    }
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }


                    if (StartTime != dt)
                    {
                        Res = Res.Where(b => (DateTime.Compare(b.REndDate.Value, StartTime) > 0 || DateTime.Compare(b.REndDate.Value, StartTime) == 0) && (DateTime.Compare(b.RStartDate.Value, StartTime) < 0 || DateTime.Compare(b.RStartDate.Value, StartTime) == 0)).ToList();
                    }
                    //var Res = db.Recruit.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                    //var Res1 = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    //var Res2 = Res1.Where(b => b.RType == Job).ToList();
                    //var Res3 = Res2.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();

                    ViewBag.Result = Res;
                    return View();
                }
                else
                {
                    var Res = db.Recruit.ToList();
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }
                    if (StartTime != null)
                    {
                        Res = Res.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();
                    }

                    //var Res3 = Res1.Where(b => b.REndDate > StartTime).ToList();
                    //var Res4 = Res3.Where(b => b.RStartDate < StartTime).ToList();
                    ViewBag.Result = Res;
                    return View();
                }


            }

        }
        public IActionResult ViewApplicantSearch(DateTime StartTime, string Salary, string Job)
            {
                using (var db = new parttimejobContext())
                {


                DateTime dt;
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy-MM-dd";
                dt = Convert.ToDateTime("2000-01-01", dtFormat);
                //var Res = db.Recruit.Where(b => b.RStartDate < StartTime ).ToList();
                if (Job == null && StartTime == dt && Salary == null)
                {
                    return RedirectToAction("ViewApplicant");
                }

                if (Job != "其他")
                {
                    var Res = db.Recruit.ToList();
                    if (Job != null)
                    {
                        Res = Res.Where(b => b.RType == Job).ToList();
                    }
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }


                    if (StartTime != dt)
                    {
                        Res = Res.Where(b => (DateTime.Compare(b.REndDate.Value, StartTime) > 0 || DateTime.Compare(b.REndDate.Value, StartTime) == 0) && (DateTime.Compare(b.RStartDate.Value, StartTime) < 0 || DateTime.Compare(b.RStartDate.Value, StartTime) == 0)).ToList();
                    }
                    //var Res = db.Recruit.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                    //var Res1 = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    //var Res2 = Res1.Where(b => b.RType == Job).ToList();
                    //var Res3 = Res2.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();

                    for (int i = 0; i < Res.Count; i++)
                    {
                        var temp1 = db.Intention.Where(a => a.RId == Res[i].RId).ToList();
                        for (int j = 0; j < temp1.Count; j++) {
                            if (common.key == temp1[j].AId) {
                                Res.Remove(Res[i]);
                            }
                        }
                    }
                    //foreach (var temp in Res) {
                    //    var temp1 =db.Intention.Where(a=>a.RId==temp.RId).ToList();
                    //    foreach (var temp2 in temp1) {
                    //        if (common.key == temp2.AId) {
                    //            Res.Remove(temp);
                    //        }
                    //    }
                    //}

                    ViewBag.Result = Res;
                    return View();
                }
                else
                {
                    var Res = db.Recruit.ToList();
                    if (Salary != null)
                    {
                        Match temp = GetValueAnd(Salary);
                        var low = temp.Groups[1].Value;
                        var high = temp.Groups[2].Value;
                        Res = Res.Where(b => int.Parse(b.RSalary) >= int.Parse(low)).ToList();
                        Res = Res.Where(b => int.Parse(b.RSalary) < int.Parse(high)).ToList();
                    }
                    if (StartTime != null)
                    {
                        Res = Res.Where(b => DateTime.Compare(b.REndDate.Value, StartTime) > 0 && DateTime.Compare(b.RStartDate.Value, StartTime) < 0).ToList();
                    }

                    for (int i = 0; i < Res.Count; i++)
                    {
                        var temp1 = db.Intention.Where(a => a.RId == Res[i].RId).ToList();
                        for (int j = 0; j < temp1.Count; j++)
                        {
                            if (common.key == temp1[j].AId)
                            {
                                Res.Remove(Res[i]);
                            }
                        }
                    }

                    //var Res3 = Res1.Where(b => b.REndDate > StartTime).ToList();
                    //var Res4 = Res3.Where(b => b.RStartDate < StartTime).ToList();
                    ViewBag.Result = Res;
                    return View();
                }


            }


            }


        }
   }


