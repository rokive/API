using API.Validations;


namespace API.VModel
{
    //[ Validatora(typeof(CredentialsVModelValidator))]
    public class CredentialsVModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
