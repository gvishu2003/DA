using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignAccelerator.Models.ViewModel;

namespace DesignAccelerator.Controllers
{
    public class UserClientMappingController : Controller
    {
        ErrorLogViewModel errorlogviewmodel;
        UserClientMappingViewModel userclientmappingViewModel;

        // GET: AuthUser
        [NoDirectAccess]
        public ActionResult Index()
        {
            try
            {
                userclientmappingViewModel = new UserClientMappingViewModel();
                // List<AuthUserViewModel> lstauthuserViewModel = new List<AuthUserViewModel>();

                userclientmappingViewModel.GetUserDetails();

               // ViewBag.Numberofauthusers = myauthuserViewModel.lstauthusers.Count;

                return View(userclientmappingViewModel);
            }
            catch (Exception ex)
            {
                errorlogviewmodel = new ErrorLogViewModel();
                errorlogviewmodel.LogError(ex);
                return View("Error");

            }
        }



        [HttpGet]
        public PartialViewResult Userchanged(int CurUserID)
        {
            try
            {
                userclientmappingViewModel = new UserClientMappingViewModel();

                userclientmappingViewModel.GetSingleUserDetails(CurUserID);

                //userclientmappingViewModel.lstClientMappedDetails = (IList<UserClientMappingViewModel>)from u in userclientmappingViewModel.lstClientData
                //                                                                  join b in userclientmappingViewModel.lstUserClientMapping on u.ClientID equals b.ClientID into c
                //                                                                  from d in c.DefaultIfEmpty()
                //                                                                  //join bp in applicationViewModel.BankTypeList on u.BankType equals bp.Value
                //                                                                  select new UserClientMappingViewModel { ClientID = u.ClientID, ClientName = u.ClientName, MappedStatus =  (d.UserClientMapID is null)? 0:1 };


                //MyDBDataContext sqlObj = new MyDBDataContext();
                //var employees = from emps in sqlObj.tblEmployees
                //                join de in sqlObj.tblDepartments on emps.DepartmentID equals de.DepartmentID into dep
                //                from dept in dep.DefaultIfEmpty()
                //                select new
                //                {
                //                    emps.EmployeeID,emps.EmployeeName,emps.Salary, dept.DepartmentName
                //                };
                //gvemployees.DataSource = employees;
                //gvemployees.DataBind();


                //MyDBDataContext sqlObj = new MyDBDataContext();
                //var employees = from emps in sqlObj.tblEmployees
                //                join depts in sqlObj.tblDepartments on emps.DepartmentID equals depts.DepartmentID
                //                select new
                //                {
                //                    emps.EmployeeID,
                //                    emps.EmployeeName,
                //                    emps.Salary,
                //                    depts.DepartmentName
                //                };
                //gvemployees.DataSource = employees;
                //gvemployees.DataBind();

                return PartialView("_UserClientMappingPartial", userclientmappingViewModel);
            }
            catch (Exception ex)
            {
                errorlogviewmodel = new ErrorLogViewModel();
                errorlogviewmodel.LogError(ex);
                return PartialView("_UserClientMappingPartial", userclientmappingViewModel);
                // return View("Error");
            }
        }


        //[HttpGet]        
        //public ActionResult Userchanged(int CurUserID)
        //{
        //    try
        //    {
        //        userclientmappingViewModel = new UserClientMappingViewModel();

        //        //if (ModelState.IsValid)
        //        //{
        //        //    var chckedValues = form.GetValues("chkStatus");

        //        //    foreach (var id in chckedValues)
        //        //    {
        //        //        int id1 = Convert.ToInt32(id);
        //        //        myauthuserViewModel.UpdateUserActive(id1);
        //        //    }

        //        //    myauthuserViewModel.getAuthUsersFrmDB();

        //        //    ViewBag.Numberofauthusers = myauthuserViewModel.lstauthusers.Count;

        //        //}
        //        return View(userclientmappingViewModel);
        //    }
        //    catch (Exception ex)
        //    {
        //        errorlogviewmodel = new ErrorLogViewModel();
        //        errorlogviewmodel.LogError(ex);
        //        return View("Error");
        //    }
        //}
    }
}