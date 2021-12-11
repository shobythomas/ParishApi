using ParishApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Interface
{
    public interface IUserLoginData
    {
        UserLogin AddUserLogin(UserLogin model);

        UserLogin EditUserLogin(UserLogin model);

        string DeleteUserLogin(string userCode);

        List<UserLogin> GetAllUserLogin();

        UserLogin FetchSingleUserLogin(string userCode);

        UserLogin FetchUserWithNameAndPwd(string username, string pwd);

        bool UpdateLastLogin(UserLogin model);

        
    }
}
