using ParishApi.Entity;
using ParishApi.Interface;
using ParishApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.ParishData
{
    public class UserLoginData : IUserLoginData
    {
        private ParishContext _parishContext;

        public UserLoginData(ParishContext parishContext)
        {
            _parishContext = parishContext;
        }
        public UserLogin AddUserLogin(UserLogin model)
        {
            _parishContext.UserLogin.Add(model);
            _parishContext.SaveChanges();
            return model;
        }

        public string DeleteUserLogin(string userCode)
        {
            string msg = string.Empty;
            var existingUserLogin = _parishContext.UserLogin.Find(userCode);
            if (existingUserLogin != null)
            {
                _parishContext.UserLogin.Remove(existingUserLogin);
                _parishContext.SaveChanges();
                msg = "Deleted Successfully";
                return msg;
            }
            else
            {
                msg = "No such family member exist!";
                return msg;
            }
        }

        public UserLogin EditUserLogin(UserLogin model)
        {
            var existingDoc = _parishContext.UserLogin.Find(model.usercode);
            if (existingDoc != null)
            {
                _parishContext.UserLogin.Update(model);
                _parishContext.SaveChanges();
            }
            return model;
        }


        public UserLogin FetchSingleUserLogin(string userCode) => _parishContext.UserLogin.Find(userCode);

        public UserLogin FetchUserWithNameAndPwd(string username, string pwd)
        {
            return _parishContext.UserLogin.Where(p => p.username == username && p.password == pwd).FirstOrDefault();
        }

        public List<UserLogin> GetAllUserLogin() => _parishContext.UserLogin.ToList();

        public bool UpdateLastLogin(UserLogin model)
        {
            var existingDoc = _parishContext.UserLogin.Find(model.username);
            if (existingDoc != null)
            {
                _parishContext.UserLogin.Update(model);
                _parishContext.SaveChanges();
            }
            return true;
        }

        
    }
}
