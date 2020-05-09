using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartTimeJob.Models;
using System.Data;
using PartTimeJob.Controllers;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PartTimeJob.Controllers
{
    public class CompanyController : Controller
    {
        // GET: /<controller>/
        /// <summary>
        /// 显示公司信息管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Companyinfo(string cname, string cindustry, string caddress, string cremark, string csize, string ctel)
        {
            using (parttimejobContext db = new parttimejobContext())
            {
                Companyinfo cinfo = db.Companyinfo.FirstOrDefault(x => x.CId == common.key);
                if (cinfo == null)
                {
                    Companyinfo cinfor = new Companyinfo();
                    cinfor.CId = common.key;
                    cinfor.CIndustry = cindustry;
                    cinfor.CName = cname;
                    cinfor.CAddress = caddress;
                    cinfor.CRemark = cremark;
                    cinfor.CSize = csize;
                    cinfor.CTel = ctel;
                    if (cinfor.CName == null)
                    {
                        var script = String.Format("<script>alert('Save failed,fill in blanks');location.href = '{0}'</script>", Url.Action("Companys"));
                        return Content(script, "text/html");
                    }
                    db.Add(cinfor);
                    db.SaveChanges();
                    var script1 = String.Format("<script>alert('Save successfully!!!');location.href = '{0}'</script>", Url.Action("Companys"));
                    return Content(script1, "text/html");
                }
                else
                {
                    cinfo.CIndustry = cindustry;
                    cinfo.CName = cname;
                    cinfo.CAddress = caddress;
                    cinfo.CRemark = cremark;
                    cinfo.CSize = csize;
                    cinfo.CTel = ctel;
                    db.SaveChanges();
                    var script1 = String.Format("<script>alert('Change successfully!!!');location.href = '{0}'</script>", Url.Action("Companys"));
                    return Content(script1, "text/html");
                }
            }
        }      
        /// <summary>
        /// 发布招聘信息
        /// </summary>
        /// <returns></returns>      
        public IActionResult Recruit( DateTime rstartdate, DateTime renddate, string raddress, string rtype, string rsalary, string rpeople, string rtel, string rrequire, string rdescribe)
        {
            using (parttimejobContext db = new parttimejobContext())
            {
                int randomnumber = new Random().Next();
                string b = randomnumber.ToString();
                Recruit rinfo = new Recruit();
                rinfo.RId = b;
                rinfo.CId = common.key;
                rinfo.PId = "";
                rinfo.RStartDate = rstartdate;
                rinfo.REndDate = renddate;
                rinfo.RAddress = raddress;
                rinfo.RType = rtype;
                rinfo.RSalary = rsalary;
                rinfo.RPeople = rpeople;
                rinfo.RTel = rtel;
                rinfo.RDescribe = rdescribe;
                rinfo.RRequire = rrequire;
                System.DateTime dt = new System.DateTime();
                dt = System.DateTime.Now;
                rinfo.RCreatTime = dt;
                if (rinfo.RAddress == null)
                {
                    var script = String.Format("<script>alert('Publish failed,fill in blanks');location.href = '{0}'</script>", Url.Action("Companys"));
                    return Content(script, "text/html");
                }
                db.Add(rinfo);
                db.SaveChanges();
                var script1 = String.Format("<script>alert('Publish successfully!!!');location.href = '{0}'</script>", Url.Action("Companys"));
                return Content(script1, "text/html");
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public IActionResult ChangePwd(string old, string new1, string new2)
        {
            using (var db = new parttimejobContext())
            {
                var cp = db.Company.Single(b => b.CId == common.key);
                if (old == cp.CPassword)
                {
                    if (new1 == new2 && new1 != null)
                    {
                        cp.CPassword = new1;
                        db.SaveChanges();
                        var script = String.Format("<script>alert('Successfully!');location.href = '{0}'</script>", Url.Action("Companys"));
                        return Content(script, "text/html");
                    }
                    else
                    {
                        //ViewData["error"] = "警告：两次密码输入不一致，请重新输入";
                        var script = String.Format("<script>alert('Failed!');location.href = '{0}'</script>", Url.Action("Companys"));
                        return Content(script, "text/html");
                    }
                }
                else
                {
                    //ViewData["error"] = "警告：旧密码不正确，请重新输入";
                    //return View("Companypw", "Company");
                    var script = String.Format("<script>alert('Failed!');location.href = '{0}'</script>", Url.Action("Companys"));
                    return Content(script, "text/html");
                }
            }
        }
        public IActionResult Companys(string flag, IFormCollection coll)
        {
            using (parttimejobContext db = new parttimejobContext())
            {
                var x = db.Recruit.Where(b => b.CId == common.key).ToList();
                ViewBag.a = x;
                string id = coll["RId"];
                if (flag == "no")
                {
                    var rinfo = db.Recruit.FirstOrDefault(b => b.RId == id);
                    db.Remove(rinfo);
                    db.SaveChanges();
                    var script = String.Format("<script>alert('Successfully!');location.href = '{0}'</script>", Url.Action("Companys"));
                    return Content(script, "text/html");

                }
                else {

                }                                     
                var cinfo = db.Companyinfo.FirstOrDefault(b => b.CId == common.key);
                if (cinfo == null)
                {
                    ViewData["error"] = "提示：您还没有完善信息，请点击公司信息编辑完善";
                    return View("Companys");
                }
                else
                {
                    ViewData["cname"] = cinfo.CName;
                    ViewData["cindustry"] = cinfo.CIndustry;
                    ViewData["caddress"] = cinfo.CAddress;
                    ViewData["csize"] = cinfo.CSize;
                    ViewData["cremark"] = cinfo.CRemark;
                    ViewData["ctel"] = cinfo.CTel;
                    return View("Companys");
                }
            }
        }
    

        /// <summary>
        /// 招聘信息管理
        /// </summary>
        /// <returns></returns>
    //    public IActionResult RecruitManage(string flag, IFormCollection coll)
    //    {
    //        using (parttimejobContext db = new parttimejobContext())
    //        {
    //            var x = db.Recruit.Where(b => b.CId == common.key).ToList();
    //            ViewBag.a = x;
    //            string id = coll["RId"];
    //            if (flag == "no")
    //            {
    //                var rinfo = db.Recruit.FirstOrDefault(b => b.RId == id);
    //                db.Remove(rinfo);
    //                db.SaveChanges();
    //                return RedirectToAction("RecruitManage");

    //}
    //            else { }
    //            return View();
    //        }
    //    }

   }
}
