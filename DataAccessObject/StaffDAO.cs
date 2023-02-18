﻿using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();

        private StaffDAO() { }

        public static StaffDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<StaffAccount> GetStaffAccountList()
        {
            List<StaffAccount> staffAccounts;
            try
            {
                var context = new CarRentalSystemDBContext();
                staffAccounts = context.StaffAccounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffAccounts;
        }

        public StaffAccount GetSatffAccountByID(String StaffID)
        {
            StaffAccount staffAccount = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                staffAccount = context.StaffAccounts.SingleOrDefault(s => s.StaffId == StaffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffAccount;
        }

        public void AddNew(StaffAccount staffAccount)
        {
            try
            {
                StaffAccount _staffAccount = GetSatffAccountByID(staffAccount.StaffId);
                if (_staffAccount == null)
                {
                    var context = new CarRentalSystemDBContext();
                    context.StaffAccounts.Add(staffAccount);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The staff account is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void Update(StaffAccount staffAccount)
        {
            try
            {
                StaffAccount _staffAccount = GetSatffAccountByID(staffAccount.StaffId);
                if (_staffAccount != null)
                {
                    var context = new CarRentalSystemDBContext();
                    context.Entry<StaffAccount>(staffAccount).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The staff account does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void Remove(StaffAccount staffAccount)
        {
            try
            {
                StaffAccount _staffAccount = GetSatffAccountByID(staffAccount.StaffId);
                if (_staffAccount != null)
                {
                    var context = new CarRentalSystemDBContext();
                    context.StaffAccounts.Remove(_staffAccount);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The staff account does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public List<StaffAccount> SearchStaffAccount(String staffName)
        {
            List<StaffAccount> staffAccounts;
            try
            {
                var context = new CarRentalSystemDBContext();
                staffAccounts = context.StaffAccounts.Where(s => s.FullName.Contains(staffName)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return staffAccounts;
        }

        public StaffAccount LoginByStaffAccount(String email, String password)
        {
            StaffAccount staffAccount = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                staffAccount = context.StaffAccounts.SingleOrDefault(s => s.Email == email && s.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffAccount;
        }
    }
}
