using ShoppingP6_JorgeRocha.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using ShoppingP6_JorgeRocha.Models;
using System.Threading.Tasks;

namespace ShoppingP6_JorgeRocha.Views
{
    public class UserViewModel: BaseViewModel
    {
        public UserRole myUserRole { get; set; }
        public User myUser { get; set; }
  
        public UserViewModel()
        {
            myUserRole = new UserRole();
            myUser = new User();

        }

        public async Task<List<UserRole>> GetUserRolesList()
        {
            try
            {
                List<UserRole> list = new List<UserRole>();

                list = await myUserRole.getUserRoles();

                if (list != null) {
                    return list;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<bool> addNewUser(string name, string email, string password, string backUpEmail, string phoneNumber, int userRole = 1, int country = 2) {

            if (IsBusy)  return false;
            IsBusy = true;

            try
            {
                myUser.Name = name;
                myUser.Email = email;
                myUser.UserPassword = password;
                myUser.BackUpEmail = backUpEmail;
                myUser.PhoneNumber = phoneNumber;
                myUser.IduserRole = userRole;
                myUser.Idcountry = country;

                bool response = await myUser.addUser();

                return response;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
