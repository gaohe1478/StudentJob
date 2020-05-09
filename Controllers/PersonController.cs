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
    public class PersonController : Controller
    {
        // GET: /<controller>/
        /// <summary>
        /// 显示公司信息管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Personinfo(string pname, string psex, string paddress, string premark, string pnumber, string ptel)
        {
            using (parttimejobContext db = new parttimejobContext())
            {
                Personinfo cinfo = db.Personinfo.FirstOrDefault(x => x.PId == common.key);
                if (cinfo == null)
                {
                    Personinfo cinfor = new Personinfo();
                    cinfor.PId = common.key;
                    cinfor.PSex = psex;
                    cinfor.PName = pname;
                    cinfor.PAddress = paddress;
                    cinfor.CRemark = premark;
                    cinfor.PNumber = pnumber;
                    cinfor.PTel = ptel;
                    if (cinfor.PName == null)
                    {
                        var script = String.Format("<script>alert('Save failed,fill in blanks');location.href = '{0}'</script>", Url.Action("Persons"));
                        return Content(script, "text/html");
                    }
                    db.Add(cinfor);
                    db.SaveChanges();
                    var script1 = String.Format("<script>alert('Save successfully!!!');location.href = '{0}'</script>", Url.Action("Persons"));
                    return Content(script1, "text/html");
                }
                else
                {
                    cinfo.PSex = psex;
                    cinfo.PName = pname;
                    cinfo.PAddress = paddress;
                    cinfo.CRemark = premark;
                    cinfo.PNumber = pnumber;
                    cinfo.PTel = ptel;
                    db.SaveChanges();
                    var script1 = String.Format("<script>alert('Change successfully!!!');location.href = '{0}'</script>", Url.Action("Persons"));
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
                rinfo.CId = "";
                rinfo.PId = common.key;
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
                    var script = String.Format("<script>alert('Publish failed,fill in blanks');location.href = '{0}'</script>", Url.Action("Persons"));
                    return Content(script, "text/html");
                }
                db.Add(rinfo);
                db.SaveChanges();
                var script1 = String.Format("<script>alert('Publish successfully');location.href = '{0}'</script>", Url.Action("Persons"));
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
                var cp = db.Person.Single(b => b.PId == common.key);
                if (old == cp.PPassword)
                {
                    if (new1 == new2 && new1 != null)
                    {
                        cp.PPassword = new1;
                        db.SaveChanges();
                        var script = String.Format("<script>alert('Successfully!');location.href = '{0}'</script>", Url.Action("Persons"));
                        return Content(script, "text/html");
                    }
                    else
                    {
                        var script = String.Format("<script>alert('Failed!');location.href = '{0}'</script>", Url.Action("Persons"));
                        return Content(script, "text/html");
                    }
                }
                else
                {
                    var script = String.Format("<script>alert('Failed!');location.href = '{0}'</script>", Url.Action("Persons"));
                    return Content(script, "text/html");
                }
            }
        }
        public IActionResult Companypw()
        {
            return View();
        }
        public IActionResult Persons(string flag, IFormCollection coll)
        {
            using (parttimejobContext db = new parttimejobContext())
            {
                var x = db.Recruit.Where(b => b.PId == common.key).ToList();
                ViewBag.a = x;
                string id = coll["RId"];
                if (flag == "no")
                {
                    var rinfo = db.Recruit.FirstOrDefault(b => b.RId == id);
                    db.Remove(rinfo);
                    db.SaveChanges();
                    var script = String.Format("<script>alert('Successfully!');location.href = '{0}'</script>", Url.Action("Persons"));
                    return Content(script, "text/html");
                }
                else {

                }                                     
                var cinfo = db.Personinfo.FirstOrDefault(b => b.PId == common.key);
                if (cinfo == null)
                {
                    ViewData["error"] = "提示：您还没有完善信息，请点击个人信息编辑完善";
                    return View();
                }
                else
                {
                    ViewData["pname"] = cinfo.PName;
                    ViewData["psex"] = cinfo.PSex;
                    ViewData["paddress"] = cinfo.PAddress;
                    ViewData["pnumber"] = cinfo.PNumber;
                    ViewData["premark"] = cinfo.CRemark;
                    ViewData["ptel"] = cinfo.PTel;
                    return View();
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
