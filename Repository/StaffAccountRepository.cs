using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StaffAccountRepository : IStaffAccountRepository
    {
        public void DeleteStaffAccount(StaffAccount staffAccount)
        {
            StaffDAO.Instance.Remove(staffAccount);
        }

        public StaffAccount GetSatffAccountByID(string staffID)
        {
            return StaffDAO.Instance.GetSatffAccountByID(staffID);
        }

        public IEnumerable<StaffAccount> GetStaffAccountList()
        {
            return StaffDAO.Instance.GetStaffAccountList();
        }

        public void InsertStaffAccount(StaffAccount staffAccount)
        {
            StaffDAO.Instance.AddNew(staffAccount);
        }

        public StaffAccount LoginByStaffAccount(string email, string password)
        {
            return StaffDAO.Instance.LoginByStaffAccount(email, password);
        }

        public IEnumerable<StaffAccount> SearchStaffAccount(string search)
        {
            return StaffDAO.Instance.SearchStaffAccount(search);
        }

        public void UpdateStaffAccount(StaffAccount staffAccount)
        {
            StaffDAO.Instance.Update(staffAccount);
        }
    }
}
