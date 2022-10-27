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
  
        public UserViewModel()
        {
            myUserRole = new UserRole();

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
    }
}
