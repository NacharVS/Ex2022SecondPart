using Ex2022Timurshin320.Data.DB;
using Ex2022Timurshin320.Data.Users;
using System.Security.Cryptography;
using System.Text;

namespace Ex2022Timurshin320.Services
{
    public class UserService
    {
        static UsersContext _context = new UsersContext();
        static AppUser CurrentUser;

        public AppUser? GetUser(string id)
        {
            if (id != "") return _context.GetUser(id);
            return null;
        }

        public List<AppUser> GetUsersByRole(string role)
        {
            return _context.GetUsersByRole(role);
        }

        public string GetEmail()
        {
            if (CurrentUser != null) return CurrentUser.Email;
            else return "";
        }
        
        public string Authorization(string email, string password)
        {
            email = email.Trim();
            password = password.Trim();
            if (email == "" || password == "")
            {
                return "Поля не должны быть пустыми!";
            }
            password = sha256_hash(password);
            var res = _context.Authenticate(email, password);
            if (res != null)
            {
                _context.UpdateUser(res);
                CurrentUser = res;
                return "";
            } 
            return "Неверный логин или пароль";
        }

        public string Registration(string firstname, string lastname, string email, string password, string repassword, string photoid)
        {
            firstname = firstname.Trim();
            lastname = lastname.Trim();
            email = email.Trim();
            password = password.Trim();
            repassword = repassword.Trim();
            if (firstname == "" || lastname == "" || password == "" || email == "" || repassword == "")
            {
                return "Поля не должны быть пустыми!";
            }
            if (password != repassword)
            {
                return "Пароли не совпадают";
            }
            password = sha256_hash(password);
            AppUser newUser = new AppUser();
            newUser.Password = password;
            newUser.Email = email;
            newUser.FirstName = firstname;
            newUser.LastName = lastname;
            if (photoid != "")
            {
                newUser.PhotoId = photoid;
            }
            try
            {
                _context.AddUser(newUser);
                CurrentUser = newUser;
                _context.UpdateUser(newUser);
                return "";
            } catch
            {
                return "Такой пользователь уже существует!";
            }
        }

        public AppUser GetCurrentUser()
        {
            return CurrentUser;
        }

        public void Logout()
        {
            _context.UpdateUser(CurrentUser);
            CurrentUser = null;
        }

        public string GetId()
        {
            if (CurrentUser != null)
            {
                return CurrentUser.Id;
            }
            return "";
        }

        public string UpdateUser(AppUser user)
        {
            string error = user.IsValid();
            if (error == "")
            {
                _context.UpdateUser(user);
                return "";
            }
            return error;
        }

        public string UpdatePassword(AppUser user, string newPassword, string renewPassword)
        {
            newPassword = newPassword.Trim();
            renewPassword = renewPassword.Trim();
            if (newPassword == "")
            {
                return "Пароль не должен быть пустым!";
            }
            if (newPassword != renewPassword)
            {
                return "Пароли не совпадают";
            }
            newPassword = sha256_hash(newPassword);
            user.Password = newPassword;
            _context.UpdateUser(user);
            return "";
        }

        public string UpdatePassword(AppUser user, string oldPassword, string newPassword, string renewPassword)
        {
            newPassword = newPassword.Trim();
            renewPassword = renewPassword.Trim();
            if (newPassword == "")
            {
                return "Пароль не должен быть пустым!";
            }
            if (newPassword != renewPassword)
            {
                return "Пароли не совпадают";
            }
            newPassword = sha256_hash(newPassword);
            oldPassword = sha256_hash(oldPassword);
            if (oldPassword != user.Password)
            {
                return "Неверный пароль";
            }
            user.Password = newPassword;
            _context.UpdateUser(user);
            return "";
        }
        
        public static string GetPhotoId()
        {
            if (CurrentUser != null)
            {
                return CurrentUser.PhotoId;
            }
            return "";
        }
        
        public static String sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
