using System.Windows;
using WpfApp2.Model;
using WpfApp2.ViewModel;
namespace WpfApp2.Helper
{
    public class FindRole
    {
        int id;
        public FindRole(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Role role)
        {
            return role.Id == id;
        }
    }
}