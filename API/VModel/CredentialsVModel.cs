using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.VModel
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsVModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
