using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartTimeJob.Models;
using PartTimeJob.Controllers;

namespace PartTimeJob.Controllers
{
    public class ApplicantController : Controller
    {
        /// <summary>
        /// 显示应聘方投递状态信息
        /// </summary>
        /// <returns></returns>
        //public IActionResult TDstatus()
        //{
        //    using (parttimejobContext db = new parttimejobContext())
        //    {
               
        //        var re = db.Intention.Join(db.Recruit, a => a.RId, o => o.RId, (a, o) => new { a.AId, a.IStatus, o.RAddress, o.RDescribe, o.REndDate, o.RRequire, o.RSalary, o.RStartDate, o.RTel, o.RType });
        //        //var list = re.Where(u => u.End == textBox1.Text && u.Start == textBox2.Text).ToList();
        //        var list1 = re.Where(x => x.AId == common.key).ToList();
        //        Object ob = (object)list1;
        //        List<Recruit1> list2 = (List<Recruit1>) ob;
        //        ViewBag.list = list2;
        //        return View();
        //    }
        //}
        /// <summary>
        /// 显示个人信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Applicants()
        {
            using (var db = new parttimejobContext())
            {
                var re = db.Intention.Join(db.Recruit, a => a.RId, o => o.RId, (a, o) => new Recruit1 (a.AId, a.IStatus, o.RAddress, o.RDescribe, o.REndDate, o.RRequire, o.RSalary, o.RStartDate, o.RTel, o.RType));
                //var list = re.Where(u => u.End == textBox1.Text && u.Start == textBox2.Text).ToList();
                var list1 = re.Where(x => x.AId == common.key).ToList();     
                ViewBag.list = list1;
                var ainfo = db.Applicantinfo.FirstOrDefault(b => b.AId == common.key);
                if (ainfo == null)
                {
                    ViewData["error"] = "提示：您还没有完善个人信息，请点击个人信息编辑完善";
                    return View();
                }
                else
                {
                    ViewData["aname"] = ainfo.AName;
                    ViewData["asex"] = ainfo.ASex;
                    ViewData["anumber"] = ainfo.ANumber;
                    ViewData["acollege"] = ainfo.ACollege;
                    ViewData["amajor"] = ainfo.AMajor;
                    ViewData["atel"] = ainfo.ATel;
                    ViewData["aaddress"] = ainfo.AAddress;
                    ViewData["aemail"] = ainfo.AEmail;
                    ViewData["ahobby"] = ainfo.AHobby;
                    ViewData["askill"] = ainfo.ASkill;
                    ViewData["aremark"] = ainfo.ARemark;
                    ViewData["aexper"] = ainfo.AExper;
                    ViewData["alanguage"] = ainfo.ALanguage;   
                    return View();
                }   
            }
        }
                                                             

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Applicantpw()
        {
            return View();
        }
        public IActionResult Applicantpwf(string old, string new1, string new2)
        {
            using (var db = new parttimejobContext())
            {
                var App = db.Applicant.FirstOrDefault(b => b.AId == common.key);
                if (old == App.APassword)
                {
                    if (new1 == new2 && new1 != null)
                    {
                        App.APassword = new1;
                        db.SaveChanges();
                        var script = String.Format("<script>alert('Successfully!');location.href = '{0}'</script>", Url.Action("Applicants"));
                        return Content(script, "text/html");
                    }
                    else
                    {
                        //ViewData["error1"] = "警告：两次密码输入不一致或为空，请重新输入";
                        var script = String.Format("<script>alert('Failed!');location.href = '{0}'</script>", Url.Action("Applicants"));
                        return Content(script, "text/html");
                    }    
                }
                else
                {
                    //ViewData["error1"] = "警告：旧密码不正确，请重新输入";
                    var script = String.Format("<script>alert('Failed!');location.href = '{0}'</script>", Url.Action("Applicants"));
                    return Content(script, "text/html");
                }
            }
        }
        /// <summary>
        /// 编辑应聘方信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Applicanti(string aname, string asex, string anumber, string acollege, string amajor, string askill, string ahobby, string atel, string aaddress, string aemail, string aexper, string aremark, string alanguage)
        {
            using (parttimejobContext db = new parttimejobContext())
            {
                Applicantinfo ainfo = db.Applicantinfo.FirstOrDefault(x => x.AId == common.key);
                if (ainfo == null)
                {
                    Applicantinfo ainfo1 = new Applicantinfo();
                    ainfo1.AId = common.key;
                    ainfo1.AName = aname;
                    ainfo1.ASex = asex;
                    ainfo1.ANumber = anumber;
                    ainfo1.ACollege = acollege;
                    ainfo1.AMajor = amajor;
                    ainfo1.ATel = atel;
                    ainfo1.AAddress = aaddress;
                    ainfo1.AEmail = aemail;
                    ainfo1.AHobby = ahobby;
                    ainfo1.ASkill = askill;
                    ainfo1.ARemark = aremark;
                    ainfo1.AExper = aexper;
                    ainfo1.ALanguage = alanguage;
                    if (ainfo1.AName == null)
                    {
                        var script = String.Format("<script>alert('Save failed,fill in blanks!!!');location.href = '{0}'</script>", Url.Action("Applicants"));
                        return Content(script, "text/html");
                    }
                    db.Add(ainfo1);
                    db.SaveChanges();
                    var script1 = String.Format("<script>alert('Save successfully!!!');location.href = '{0}'</script>", Url.Action("Applicants"));
                    return Content(script1, "text/html");
                    //ViewData["error"] = "提示：修改成功";
                }
                else
                {
                    ainfo.AName = aname;
                    ainfo.ASex = asex;
                    ainfo.ANumber = anumber;
                    ainfo.ACollege = acollege;
                    ainfo.AMajor = amajor;
                    ainfo.ATel = atel;
                    ainfo.AAddress = aaddress;
                    ainfo.AEmail = aemail;
                    ainfo.AHobby = ahobby;
                    ainfo.ASkill = askill;
                    ainfo.ARemark = aremark;
                    ainfo.AExper = aexper;
                    ainfo.ALanguage = alanguage;
                    db.SaveChanges();
                    var script = String.Format("<script>alert('Change successfully!!!');location.href = '{0}'</script>", Url.Action("Applicants"));
                    return Content(script, "text/html");
                    //ViewData["error"] = "提示：修改成功";
                }
            }
        }
    }
}


