using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartTimeJob.Models;

namespace PartTimeJob.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            common.key = null;
            return View();
        }
        public IActionResult Index()
        {
            using (var db = new parttimejobContext())
            {
                var Result = db.Recruit.ToList();

                ViewBag.Result = Result;

                return View();
            }
        }

        public IActionResult Login1(string username, string password, string status)
        {
            if (status == "student")
            {
                using (var db = new parttimejobContext())
                {
                    var applicant = db.Applicant.FirstOrDefault(b => b.AId == username);
                    if (applicant == null)
                    {
                        ViewData["error"] = "提示：不存在此用户名，请重新输入";
                        return View("Login", "Home");
                    }
                    else
                    if (password == applicant.APassword)
                    {
                        common.key = username;
                        return RedirectToAction("Applicants", "Applicant");
                    }
                    else 
                    {
                        ViewData["error"] = "提示：密码错误，请重新输入";
                        return View("Login", "Home");
                    }

                }
            }
            else if (status == "company")
            {
                using (var db = new parttimejobContext())
                {
                    var company = db.Company.FirstOrDefault(b => b.CId == username);
                     if (company == null)
                     {
                        ViewData["error"] = "提示：不存在此用户名，请重新输入";
                        return View("Login", "home");
                     }
                    else
                    if (password == company.CPassword)
                    {
                        common.key = username;
                        return RedirectToAction("Companys", "company");
                    }
                    else
                    {
                        ViewData["error"] = "提示：密码错误，请重新输入";
                        return View("Login", "home");
                    }

                }
            }
            else if(status=="person")
            {
                using (var db = new parttimejobContext())
                {
                    var person = db.Person.FirstOrDefault(b => b.PId == username);
                     if (person == null)
                     {
                        ViewData["error"] = "提示：不存在此用户名，请重新输入";
                        return View("Login", "home");
                     }
                    else
                    if (password == person.PPassword)
                    {
                        common.key = username;
                        return RedirectToAction("Persons", "person");
                    }
                    else
                    {
                        ViewData["error"] = "提示：密码错误，请重新输入";
                        return View("Login", "home");
                    }
                }
            }
            else
            {
                ViewData["error"] = "提示：请选择登陆人员类别";
                return View("Login", "home");
            }
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Register1(string username, string password1, string password2, string status)
        {
            if (password1==password2) { 
              if (status == "student")
              {
                using (var db = new parttimejobContext())
                {
                    var applicant = db.Applicant.FirstOrDefault(b => b.AId == username);
                    if (applicant == null)
                    {
                        using (parttimejobContext app = new parttimejobContext())
                        {
                            Applicant ainfo = new Applicant();
                            ainfo.AId = username;
                            ainfo.APassword = password1;
                            ainfo.AStatus = 0;
                            db.Add(ainfo);
                            db.SaveChanges();
                        }
                        return View("Login", "Home");
                    }
                    else
                    {
                        ViewData["error"] = "提示：此用户名已存在，请重新输入";
                        return View("register", "Home");
                    }
                }
              }
              else if (status == "company")
              {
                using (var db = new parttimejobContext())
                {
                    var company = db.Company.FirstOrDefault(b => b.CId == username);
                    if (company == null)
                    {
                        using (parttimejobContext app = new parttimejobContext())
                        {
                            Company ainfo = new Company();
                            ainfo.CId = username;
                            ainfo.CPassword = password1;
                            ainfo.CStatus = 0;
                            db.Add(ainfo);
                            db.SaveChanges();
                        }
                        return View("Login", "home");
                    }
                    else
                    {
                        ViewData["error"] = "提示：此用户名已存在，请重新输入";
                        return View("register", "home");
                    }

                }
              }
              else if(status=="person")
              {
                using (var db = new parttimejobContext())
                {
                    var person = db.Person.FirstOrDefault(b => b.PId == username);
                    if (person == null)
                    {
                        using (parttimejobContext app = new parttimejobContext())
                        {
                            Person ainfo = new Person();
                            ainfo.PId = username;
                            ainfo.PPassword = password1;
                            ainfo.PStatus = 0;
                            db.Add(ainfo);
                            db.SaveChanges();
                        }
                        return View("Login", "home");
                    }
                    else
                    {
                        ViewData["error"] = "提示：此用户名已存在，请重新输入";
                        return View("register", "home");
                    }
                }
              }
              else
              {
                ViewData["error"] = "提示：请选择注册人员类别";
                return View("register", "home");
              }
            }
            else
            {
                ViewData["error"] = "提示：两次密码输入不一致";
                return View("register", "home");
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
    }
}
