using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DA.DomainModel;
using System.ComponentModel.DataAnnotations;
using DesignAccelerator.Controllers;
using DA.BusinessLayer;

namespace DesignAccelerator.Models.ViewModel
{
    public class UserClientMappingViewModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int MappedStatus { get; set; }

        public IList<tbl_UserData> lstUserData { get; set; }

        public IList<tbl_Clients> lstClientData { get; set; }
        
        public IList<tbl_UserClientMapping> lstUserClientMapping { get; set; }

        public IList<UserClientMappingViewModel> lstClientMappedDetails { get; set; }

        public void GetUserDetails()
        {
            try
            {
                tbl_UserData currentloggedinuserdata = (tbl_UserData)HttpContext.Current.Session["CurrentLoggedInUserDetails"];
                int currentloggedinuserID = currentloggedinuserdata.UserID;
                UserManager userManager = new UserManager();
                ClientManager clientManager = new ClientManager();
                lstUserData = new List<tbl_UserData>();
                lstClientData = new List<tbl_Clients>();
                lstUserData = userManager.GetUserDetails();
                lstClientData = clientManager.GetClientDetails();

                List<UserClientMappingViewModel> lstUserClientMappingViewModel = new List<UserClientMappingViewModel>();

                foreach (var item in lstClientData)
                {
                    UserClientMappingViewModel userClientMappingViewModel = new UserClientMappingViewModel();
                    userClientMappingViewModel.ClientID = item.ClientID;
                    userClientMappingViewModel.ClientName = item.ClientName;
                    userClientMappingViewModel.MappedStatus = 0;               

                    lstUserClientMappingViewModel.Add(userClientMappingViewModel);
                }
                lstClientMappedDetails = lstUserClientMappingViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GetSingleUserDetails(int? userID)
        {
            try
            {
                //tbl_UserData currentloggedinuserdata = (tbl_UserData)HttpContext.Current.Session["CurrentLoggedInUserDetails"];
                //int currentloggedinuserID = currentloggedinuserdata.UserID;
                UserManager userManager = new UserManager();
                ClientManager clientManager = new ClientManager();
                lstUserData = new List<tbl_UserData>();
                lstClientData = new List<tbl_Clients>();
                lstClientData = clientManager.GetClientDetails();
                lstUserData = userManager.GetUserDetails();
                lstUserClientMapping = clientManager.GetMappedClientDetails(userID);

                List<UserClientMappingViewModel> lstUserClientMappingViewModel = new List<UserClientMappingViewModel>();

                foreach (var item in lstClientData)
                {
                    UserClientMappingViewModel userClientMappingViewModel = new UserClientMappingViewModel();
                    userClientMappingViewModel.ClientID = item.ClientID;
                    userClientMappingViewModel.ClientName = item.ClientName;

                    foreach (var mappeditem in lstUserClientMapping)
                    {
                        if (item.ClientID == mappeditem.ClientID)
                        {
                            userClientMappingViewModel.MappedStatus = 1;
                        }
                        else
                        {
                            userClientMappingViewModel.MappedStatus = 0;
                        }
                    }

                    lstUserClientMappingViewModel.Add(userClientMappingViewModel);
                }

                lstClientMappedDetails = lstUserClientMappingViewModel;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}