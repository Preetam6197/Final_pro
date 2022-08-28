using Compro_Intern.CustExceptions;
using Compro_Intern.Daaataaa;
using Compro_Intern.Models;
using Compro_Intern.RegLo;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternRLController : ControllerBase
    {

        private readonly IntContext _ic;
        private readonly InternUs us;

        //private readonly ILog log;


        public InternRLController(IntContext context, InternUs mod)
        {
            _ic = context;
            us = mod;
            //log = LogManager.GetLogger(typeof(InternRLController));


        }

        [HttpPost]

        
        public async Task<ActionResult<bool>> Login(LoginInt li)
        {

            

            //try
            //{
            //    int a = 0, b = 0;
            //    int c = b / a;
            //}
            //catch (Exception ex)
            //{
            //   
            //}

            try
            {

                bool a = await us.A_Login(li);
                if (a)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch(Exception e)
            {
                return NotFound(e.Message);
            }
            
        }

        [HttpPost]

        [Route("Registr")]
        public async Task<ActionResult<RespoInt>> Register(RegInt rt)
        {
            

            try
            {

                var b = await us.B_Register(rt);
                if (b != null)
                {
                    return Ok(b);
                }
                else
                {
                    throw new ExceptCustom("Registeration is failed");
                }

            }

            catch (Exception e)
            {
                return NotFound(e.Message);
            }

        }



        //About LOG4NET
        //private readonly Context _context;
        //private readonly ILog log;


        //public LoginsController(Context context)
        //{
        //    _context = context;
        //    log = LogManager.GetLogger(typeof(LoginsController));

        //}


        //private void WriteLogs()
        //{
        //    log.Info("");

        //    Login l = new Login()
        //    {
        //        

        //    };
        //    log.Info( + JsonConvert.SerializeObject(l));

        //    try
        //    {
        //        int a / a;
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error(", ex);
        //    }
        //}





    }
}
