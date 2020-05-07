using LIBCrudDATA.Models;
using LIBCrudREPOSITORIES.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBCrudAPPLICATIONS.Controllers
{
    public class UsersController
    {
        public Exception Exception { get; set; }
        private UsersRepository UsersRepository;

        public UsersController()
        {
            UsersRepository = new UsersRepository();
        }

        public bool Add(Users user)
        {
            try
            {
                if (user == null)
                {
                    Exception = new Exception("Ingrese los datos");
                    return false;
                }
                if (!UsersRepository.Add(user))
                {
                    Exception = UsersRepository.Exception;
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Exception = ex;
                return false;
            }
            
        }

        public List<Users> List()
        {
            try
            {
                var response = UsersRepository.List();
                if (response == null)
                {
                    Exception = UsersRepository.Exception;
                    return null;
                }
                return response;
            }
            catch (Exception ex)
            {
                Exception = ex;
                return null;
            }
            
        }

        public List<Users> GetUser(string idSelected)
        {
            try
            {
                var selection = UsersRepository.GetUser(idSelected);
                if (selection == null)
                {
                    Exception = UsersRepository.Exception;
                    return null;
                }
                return selection;
            }
            catch(Exception ex)
            {
                Exception = ex;
                return null;
            }
            
        }

        public bool Update(Users user)
        {
            try
            {
                if (user == null)
                {
                    Exception = new Exception("Ingrese los datos");
                    return false;
                }
                if (!UsersRepository.Update(user))
                {
                    Exception = UsersRepository.Exception;
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                Exception = ex;
                return false;
            }
        }

        public bool Delete(string userId)
        {
            try
            {
                if (userId == null)
                {
                    Exception = new Exception("Seleccione un usuario");
                    return false;
                }
                if (!UsersRepository.Delete(userId))
                {
                    Exception = UsersRepository.Exception;
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                Exception = ex;
                return false;
            }
        }
    }
}
