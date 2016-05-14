using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAManager
{
    static class Settings
    {

        public static void Initialize()
        { }

        public static string ChangePassword(string oldPass, string newPass)
        {
            if ((oldPass == "123") && (newPass.Length > 3))
            {
                return "Пароль изменен";
            }
            else
            {
                new ErrorWindow("Ошибка смены пароля","Ошибка").ShowDialog();
                return "Error";
            }

        }
    }
}
