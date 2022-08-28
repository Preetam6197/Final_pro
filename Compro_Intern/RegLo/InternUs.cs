using Compro_Intern.CustExceptions;
using Compro_Intern.Daaataaa;
using Compro_Intern.Models;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.RegLo
{
    public class InternUs
    {

        private readonly IntContext _ic;

        private readonly ILog log;


        public InternUs(IntContext context)
        {
            _ic = context;
            log = LogManager.GetLogger(typeof(InternUs));



        }

        public async Task<bool> A_Login(LoginInt n)
        {

            try
            {
                if (n != null)
                {

                    //var ua = _context.Users.Where(u => u.Email == login.Email && u.Password == login.Password).FirstOrDefault();

                    //if (ua != null)
                    //{
                    //    _context.Logins.Add(login);
                    //    await _context.SaveChangesAsync();
                    //    return true;
                    //}

                    //return false;
                    var ua = _ic.Regs.Where(u => u.IntEmail == n.LogEmail && u.IntPas == n.LogPas).FirstOrDefault();

                    if (ua != null)
                    {
                        log.Info("The Log4Net is  Wirting some information about logging");

                        LoginInt l = new LoginInt()
                        {
                            LogEmail = n.LogEmail,
                            LogPas = n.LogPas,

                        };

                        log.Info("The Log4Net:::::: Writing an logg details:::: " + JsonConvert.SerializeObject(l));

                        return true;
                    }

                    return false;
                    //return ua;
                }
                else
                {
                    throw new ExceptCustom("Invalid Login");
                }
            }
            catch (Exception)
            {
                throw;
            }
            


        }

        public async Task<string> B_Register(RegInt r)
        {
           // RespoInt p = new RespoInt();

            try
            {
                if (r != null)
                {
                    //var ua = _ic.Regs.FirstOrDefault(u => u.IntEmail == n.LogEmail && u.IntPas == n.LogPas).ToString();


                    _ic.Regs.Add(r);
                    await _ic.SaveChangesAsync();
                    
                    //p.ToString();

                    return "Added Successfully";

                   
                }
                else
                {
                    throw new ExceptCustom("Registration Failed");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }



        }






    }
}
