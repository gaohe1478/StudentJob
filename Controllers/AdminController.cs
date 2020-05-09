using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartTimeJob.Models;


namespace PartTimeJob.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult IndexAdmin()
        {
            return View();
        }
        public IActionResult WelcomeAdmin()
        {
            return View();
        }

        public IActionResult ALogin(string ausername, string apassword)
        {

            using (var db = new parttimejobContext())
            {
                var admin = db.Admin.FirstOrDefault(b => b.DId == ausername);
                if (admin == null)
                {
                    ViewData["error"] = "提示：不存在此用户名，请重新输入";
                    return View("IndexAdmin", "Admin");
                }
                else
                if (apassword == admin.DPassword)
                {
                    common.key = ausername;
                    return View("WelcomeAdmin", "Admin");
                }
                else
                {
                    ViewData["error"] = "提示：密码错误，请重新输入";
                    return View("IndexAdmin", "Admin");
                }
            }
        }
        /// <summary>
        /// huo
        /// </summary>
        /// <returns></returns>
        public IActionResult Welcome()
        {
            return View("WelcomeAdmin", "Admin");
        }

        public IActionResult ChangeP()
        {
            return View("changepassword", "Admin");
        }
        public IActionResult ApplicantInfo(string str)
        {
            var AList = ApplicantList();
            List<Applicantinfo> AIList = new List<Applicantinfo>();
            using (var db = new parttimejobContext())
            {
                foreach(var a in AList)
                {
                    AIList.Add(db.Applicantinfo.FirstOrDefault(e => e.AId == a.AId));
                }
            }
            ViewBag.Info = AIList;
            return View("ApplicantInfo", AList);
        }
        public IActionResult CompanyInfo()
        {
            var AList = CompanyList();
            List<Companyinfo> AIList = new List<Companyinfo>();
            using (var db = new parttimejobContext())
            {
                foreach (var a in AList)
                {
                    AIList.Add(db.Companyinfo.FirstOrDefault(e => e.CId == a.CId));
                }
            }
            ViewBag.Info = AIList;
            return View("CompanyInfo", AList);
        }
        public IActionResult PersonInfo()
        {
            var AList = PersonList();
            List<Personinfo> AIList = new List<Personinfo>();
            using (var db = new parttimejobContext())
            {
                foreach (var a in AList)
                {
                    AIList.Add(db.Personinfo.FirstOrDefault(e => e.PId == a.PId));
                }
            }
            ViewBag.Info = AIList;
            return View("PersonInfo", AList);
        }

        public IActionResult changePwd(String DPassword, String NewDPassword, String NewDPassword1)
        {
            if (NewDPassword != NewDPassword1)
            {
                ViewData["error"] = "两次密码不相同";
                return View("ChangePassword");
            }
            using (var context = new parttimejobContext())
            {
                Admin ad = context.Admin.FirstOrDefault(m => m.DId == common.key);
                if (ad == null)
                {
                    ViewData["error"] = "用户名不存在";
                    return View("ChangePassword");
                }
                if (ad.DPassword == DPassword && NewDPassword != null && NewDPassword != "")
                {
                    ad.DPassword = NewDPassword;
                    context.Admin.Update(ad);
                    context.SaveChanges();

                    ViewData["error"] = "修改成功";
                    return View("ChangePassword");
                }
                else
                {
                    ViewData["error"] = "密码不对";
                    return View("ChangePassword");
                }
            }

        }

        /// <summary>
        /// 应聘者列表
        /// </summary>
        /// <returns></returns>
        public List<Applicant> ApplicantList()
        {
            List<Applicant> applicant;
            using (var dbContext = new parttimejobContext())
            {
                applicant = dbContext.Applicant.ToList();
                return applicant;
                //applicant = (from a in dbContext.Applicant.ToList() where a.AId.Contains(str) select new Applicant() { AId = a.AId,APassword = a.APassword,AStatus = a.AStatus}).ToList();
            }
        }

        public IActionResult FindApplicant(string AId,string AName, int AStatus)
        {
            List<Applicant> applicant = ApplicantList();
            if (AId != null) { applicant = (from a in applicant where a.AId.Contains(AId) select new Applicant() { AId = a.AId, APassword = a.APassword, AStatus = a.AStatus }).ToList(); }
            if (AStatus != 2) { applicant = (from a in applicant where a.AStatus == AStatus select new Applicant() { AId = a.AId, APassword = a.APassword, AStatus = a.AStatus }).ToList(); }
            List<Applicantinfo> AIList = new List<Applicantinfo>();
            using (var db = new parttimejobContext())
            {
                foreach(var a in applicant)
                {
                    AIList.Add(db.Applicantinfo.FirstOrDefault(e => e.AId == a.AId));
                }
            }
            if (AName!=null)
            {
                AIList = (from b in AIList where b != null && b.AName.Contains(AName) select b).ToList();
                applicant = (from a in applicant from b in AIList where a.AId.Equals(b.AId) select a).ToList();
            }
            ViewBag.Info = AIList;
            return View("ApplicantInfo", applicant);
        }

        /// <summary>
        /// 公司列表
        /// </summary>
        /// <returns></returns>
        public List<Company> CompanyList()
        {
            using (var dbContext = new parttimejobContext())
            {
                var company = dbContext.Company.ToList();
                return company;
            }
        }

        public IActionResult FindCompany(string CId, string CName,int CStatus)
        {
            List<Company> company = CompanyList();
            if (CId != null) { company = (from a in company where a.CId.Contains(CId) select new Company() { CId = a.CId, CPassword = a.CPassword, CStatus = a.CStatus }).ToList(); }
            if (CStatus != 2) { company = (from a in company where a.CStatus == CStatus select new Company() { CId = a.CId, CPassword = a.CPassword, CStatus = a.CStatus }).ToList(); }
            List<Companyinfo> IList = new List<Companyinfo>();
            using (var db = new parttimejobContext())
            {
                foreach (var a in company)
                {
                    IList.Add(db.Companyinfo.FirstOrDefault(e => e.CId == a.CId));
                }
            }
            if (CName != null)
            {
                IList = (from b in IList where b != null && b.CName.Contains(CName) select b).ToList();
                company = (from a in company from b in IList where a.CId.Equals(b.CId) select a).ToList();
            }
            ViewBag.Info = IList;
            return View("CompanyInfo", company);
        }

        /// <summary>
        /// 个人列表
        /// </summary>
        /// <returns></returns>
        public List<Person> PersonList()
        {
            using (var dbContext = new parttimejobContext())
            {
                var person = dbContext.Person.ToList();
                return person;
            }
        }

        public IActionResult FindPerson(string PId, string PName ,int PStatus)
        {
            List<Person> person = PersonList();
            if (PId != null) { person = (from a in person where a.PId.Contains(PId) select new Person() { PId = a.PId, PPassword = a.PPassword, PStatus = a.PStatus }).ToList(); }
            if (PStatus != 2) { person = (from a in person where a.PStatus == PStatus select new Person() { PId = a.PId, PPassword = a.PPassword, PStatus = a.PStatus }).ToList(); }
            List<Personinfo> IList = new List<Personinfo>();
            using (var db = new parttimejobContext())
            {
                foreach (var a in person)
                {
                    IList.Add(db.Personinfo.FirstOrDefault(e => e.PId == a.PId));
                }
            }
            if (PName != null)
            {
                IList = (from b in IList where b != null && b.PName.Contains(PName) select b).ToList();
                person = (from a in person from b in IList where a.PId.Equals(b.PId) select a).ToList();
            }
            ViewBag.Info = IList;
            return View("PersonInfo", person);
        }

        /// <summary>
        /// 删除应聘者
        /// </summary>
        /// <param name="AId"></param>
        /// <returns></returns>
        public IActionResult DeleteApplicant(string AId)
        {
            string aid = System.Web.HttpUtility.UrlDecode(AId);
            using (var dbContext = new parttimejobContext())
            {
                var applicant = dbContext.Applicant.FirstOrDefault(m => m.AId == aid);
                List<Intention> intentions = dbContext.Intention.ToList();
                intentions = (from a in intentions where a.AId == applicant.AId select a).ToList();
                foreach (Intention i in intentions)
                {
                    dbContext.Intention.Remove(i);
                }
                dbContext.SaveChanges();
                var info = dbContext.Applicantinfo.FirstOrDefault(e => e.AId == applicant.AId);
                if (info != null)
                {
                    dbContext.Applicantinfo.Remove(info);
                    dbContext.SaveChanges();
                }
                dbContext.Applicant.Remove(applicant);
                dbContext.SaveChanges();
                return View("ApplicantInfo", ApplicantList());
            }
        }

        /// <summary>
        /// 删除公司
        /// </summary>
        /// <param name="CId"></param>
        /// <returns></returns>
        public IActionResult DeleteCompany(string CId)
        {
            string cid = System.Web.HttpUtility.UrlDecode(CId);
            using (var dbContext = new parttimejobContext())
            {
                var company = dbContext.Company.FirstOrDefault(m => m.CId == cid);
                List<Recruit> recruits = dbContext.Recruit.ToList();
                recruits = (from a in recruits where a.CId == company.CId select a).ToList();
                foreach (Recruit i in recruits)
                {
                    dbContext.Recruit.Remove(i);
                }
                dbContext.SaveChanges();
                var info = dbContext.Companyinfo.FirstOrDefault(e => e.CId == company.CId);
                if (info != null)
                {
                    dbContext.Companyinfo.Remove(info);
                    dbContext.SaveChanges();
                }
                dbContext.Company.Remove(company);
                dbContext.SaveChanges();
                return View("CompanyInfo", CompanyList());
            }
        }

        /// <summary>
        /// 删除个人
        /// </summary>
        /// <param name="PId"></param>
        /// <returns></returns>
        public IActionResult DeletePerson(string PId)
        {
            string pid = System.Web.HttpUtility.UrlDecode(PId);
            using (var dbContext = new parttimejobContext())
            {
                var person = dbContext.Person.FirstOrDefault(m => m.PId == pid);
                List<Recruit> recruits = dbContext.Recruit.ToList();
                recruits = (from a in recruits where a.PId == person.PId select a).ToList();
                foreach (Recruit i in recruits)
                {
                    dbContext.Recruit.Remove(i);
                }
                dbContext.SaveChanges();
                var info = dbContext.Personinfo.FirstOrDefault(e => e.PId == person.PId);
                if (info != null)
                {
                    dbContext.Personinfo.Remove(info);
                    dbContext.SaveChanges();
                }
                dbContext.Person.Remove(person);
                dbContext.SaveChanges();
                var script = String.Format("<script>alert('success');location.href = '{0}'</script>", Url.Action("PersonInfo"));
                return Content(script, "text/html");
                //return View("PersonInfo", PersonList());
            }
        }

        /// <summary>
        /// 封禁/解封应聘者
        /// </summary>
        /// <param name="AId"></param>
        /// <returns></returns>
        public IActionResult UpdateAStatus(string AId)
        {
            string aid = System.Web.HttpUtility.UrlDecode(AId);
            using (var dbContext = new parttimejobContext())
            {
                var applicant = dbContext.Applicant.FirstOrDefault(m => m.AId == aid);
                if (applicant != null)
                {
                    if (applicant.AStatus == 0)
                    {
                        applicant.AStatus = 1;
                    }
                    else if (applicant.AStatus == 1)
                    {
                        applicant.AStatus = 0;
                    }
                    dbContext.Applicant.Update(applicant);
                    dbContext.SaveChanges();
                    var script = String.Format("<script>alert('success');location.href = '{0}'</script>", Url.Action("ApplicantInfo"));
                    return Content(script, "text/html");
                    //return View("ApplicantInfo", ApplicantList());
                }
                else
                {
                    var script = String.Format("<script>alert('fail');location.href = '{0}'</script>", Url.Action("ApplicantInfo"));
                    return Content(script, "text/html");
                }
            }

        }

        /// <summary>
        /// 封禁/解封公司
        /// </summary>
        /// <param name="CId"></param>
        /// <returns></returns>
        public IActionResult UpdateCStatus(string CId)
        {
            string cid = System.Web.HttpUtility.UrlDecode(CId);
            using (var dbContext = new parttimejobContext())
            {
                var company = dbContext.Company.FirstOrDefault(m => m.CId == cid);
                if (company != null)
                {
                    if (company.CStatus == 0)
                    {
                        company.CStatus = 1;
                    } else if (company.CStatus == 1)
                    {
                        company.CStatus = 0;
                    }
                    dbContext.Company.Update(company);
                    dbContext.SaveChanges();

                    var script = String.Format("<script>alert('success');location.href = '{0}'</script>", Url.Action("CompanyInfo"));
                    return Content(script, "text/html");
                    //return View("CompanyInfo", CompanyList());
                }
                else
                {
                    var script = String.Format("<script>alert('fail');location.href = '{0}'</script>", Url.Action("CompanyInfo"));
                    return Content(script, "text/html");
                }
            }
        }

        /// <summary>
        /// 解封/封禁个人
        /// </summary>
        /// <param name="PId"></param>
        /// <returns></returns>
        public IActionResult UpdatePStatus(string PId)
        {
            string pid = System.Web.HttpUtility.UrlDecode(PId);
            using (var dbContext = new parttimejobContext())
            {
                var person = dbContext.Person.FirstOrDefault(m => m.PId == pid);
                if(person != null)
                {
                    if (person.PStatus == 0)
                    {
                        person.PStatus = 1;                    
                    }else if (person.PStatus == 1)
                    {
                        person.PStatus = 0;   
                    }
                    dbContext.Person.Update(person);
                    dbContext.SaveChanges();

                    var script = String.Format("<script>alert('success');location.href = '{0}'</script>", Url.Action("PersonInfo"));
                    return Content(script, "text/html");
                    //return View("PersonInfo", PersonList());
                }else {
                    var script = String.Format("<script>alert('fail');location.href = '{0}'</script>", Url.Action("PersonInfo"));
                    return Content(script, "text/html");
                }
                
            }
        }

        public IActionResult ApplicantInfoView(string AId)
        {
            string id = System.Web.HttpUtility.UrlDecode(AId);
            using (var dbContext = new parttimejobContext())
            {
                var info = dbContext.Applicantinfo.FirstOrDefault(e => e.AId == id);
                var item = dbContext.Applicant.FirstOrDefault(e => e.AId == id);
                ViewData["status"] = item.AStatus;
                if(info != null) {return View("ApplicantInfoView",info);}
                return View("NullInfo", "Admin");
                
            }
        }

        public IActionResult CompanyInfoView(string CId)
        {
            string id = System.Web.HttpUtility.UrlDecode(CId);
            using (var dbContext = new parttimejobContext())
            {
                var info = dbContext.Companyinfo.FirstOrDefault(e => e.CId == id);

                var item = dbContext.Company.FirstOrDefault(e => e.CId == id);
                ViewData["status"] = item.CStatus;
                if (info != null) { return View("CompanyInfoView", info); }
                return View("NullInfo", "Admin");
            }
        }

        public IActionResult PersonInfoView(string PId)
        {
            string id = System.Web.HttpUtility.UrlDecode(PId);
            using (var dbContext = new parttimejobContext())
            {
                var info = dbContext.Personinfo.FirstOrDefault(e => e.PId == id);

                var item = dbContext.Person.FirstOrDefault(e => e.PId == id);
                ViewData["status"] = item.PStatus;
                if (info != null) { return View("PersonInfoView", info);}
                return View("NullInfo", "Admin");
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// 显示求职信息
        /// </summary>
        /// <param name="AId"></param>
        /// <returns></returns>
        public IActionResult IntentionList(string AId)
        {
            string aid = System.Web.HttpUtility.UrlDecode(AId);
            using (var dbContext = new parttimejobContext())
            {

                var intention1 = dbContext.Intention.ToList();
                List<Intention> intention2 = new List<Intention>();
                foreach (Intention i in intention1)
                {
                    if (i.AId == aid)
                        intention2.Add(i);
                }
                return View("Intention", intention2);
            }
        }

        /// <summary>
        /// 显示公司招聘信息
        /// </summary>
        /// <param name="CId"></param>
        /// <returns></returns>
        public IActionResult CRecruitList(string CId)
        {
            string cid = System.Web.HttpUtility.UrlDecode(CId);
            using (var dbContext = new parttimejobContext())
            {

                var recruit1 = dbContext.Recruit.ToList();
                List<Recruit> recruit2 = new List<Recruit>();
                foreach (Recruit c in recruit1)
                {
                    if (c.CId == cid)
                        recruit2.Add(c);
                }
                return View("CRecruit", recruit2);
            }
        }



        /// <summary>
        /// 显示个人招聘信息
        /// </summary>
        /// <param name="PId"></param>
        /// <returns></returns>
        public IActionResult PRecruitList(string PId)
        {
            string pid = System.Web.HttpUtility.UrlDecode(PId);
            using (var dbContext = new parttimejobContext())
            {

                var recruit1 = dbContext.Recruit.ToList();
                List<Recruit> recruit2 = new List<Recruit>();
                foreach (Recruit p in recruit1)
                {
                    if (p.PId == pid)
                        recruit2.Add(p);
                }
                return View("PRecruit", recruit2);
            }
        }

        /// <summary>
        /// 公司删除招聘信息
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public IActionResult CDelete(string RId)
        {
            using (var db = new parttimejobContext())
            {
                //var id = System.Web.HttpUtility.UrlDecode(RId);
                //var id = Request.Form["RId"].ToString();
                //var id = request["id"];
                string id = System.Web.HttpUtility.UrlDecode(RId);
                List<Intention> intentions = db.Intention.ToList();
                intentions = (from a in intentions where a.RId == id select a).ToList();
                foreach(var i in intentions)
                {
                    db.Intention.Remove(i);
                }
                var Res = db.Recruit.FirstOrDefault(b => b.RId == id);
                db.Remove(Res);
                db.SaveChanges();
                var script = String.Format("<script>alert('success');location.href = '{0}'</script>", Url.Action("CRecruitList")+"?CId="+System.Web.HttpUtility.UrlEncode(Res.CId));
                return Content(script, "text/html");
                
                //return RedirectToAction("CRecruit");
            }
        }

        /// <summary>
        /// 个人删除招聘信息
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public IActionResult PDelete(string RId)
        {
            using (var db = new parttimejobContext())
            {
                //var id = System.Web.HttpUtility.UrlDecode(RId);
                //var id = Request.Form["RId"].ToString();
                //var id = request["id"];
                string id = System.Web.HttpUtility.UrlDecode(RId);
                List<Intention> intentions = db.Intention.ToList();
                intentions = (from a in intentions where a.RId == id select a).ToList();
                foreach (var i in intentions)
                {
                    db.Intention.Remove(i);
                }
                var Res = db.Recruit.FirstOrDefault(b => b.RId == id);
                db.Remove(Res);
                db.SaveChanges();
                var script = String.Format("<script>alert('success');location.href = '{0}'</script>", Url.Action("PRecruitList") + "?PId=" + System.Web.HttpUtility.UrlEncode(Res.PId));
                return Content(script, "text/html");
                //return RedirectToAction("PRecruit");
            }
        }
    }
}
