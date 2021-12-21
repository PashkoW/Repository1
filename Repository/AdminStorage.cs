using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class AdminStorage
    {
        private readonly Dictionary<int, Admin> _Admins = new();

        public Admin Create(Admin admin)
        {

            _Admins.Add(admin.Id, admin);
            return admin;

        }

        public Admin Read(int Id)
        {
            return _Admins[Id];
        }

        public Admin Update(int Id, Admin newAdmin)
        {
            _Admins[Id] = newAdmin;
            return _Admins[Id];
        }

        public bool Delete(int Id)
        {
            return _Admins.Remove(Id);
        }
    }
}