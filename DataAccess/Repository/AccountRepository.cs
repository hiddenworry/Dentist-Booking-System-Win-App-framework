using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class AccountRepository : IAccountRepository
    {

     
        public List<Account> GetActiveDentistList() => AccountDAO.Instance.GetActiveDentistList();

        public List<Account> GetDentistList() => AccountDAO.Instance.GetALLDentistList();

        Account IAccountRepository.CheckLogin(string username, string password) => AccountDAO.Instance.CheckLogin(username, password);

        public Account GetAccountById(int id) => AccountDAO.Instance.GetAccountById(id);

        public void UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);   

        public void AddAccount(Account account) => AccountDAO.Instance.AddAccount(account);

        public List<Account> GetALLDentistList() => AccountDAO.Instance.GetALLDentistList();


        public void UpdateDentistAccount(Account account) => AccountDAO.Instance.UpdateDentistAccount(account);

        public List<Account> filterDentist(Account account) => AccountDAO.Instance.filterDentist(account);

        public List<Account> GetAccounts() => AccountDAO.Instance.GetAccounts();


    }
}
