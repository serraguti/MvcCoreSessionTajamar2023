namespace MvcCoreSession.Helpers
{
    public class Class1
    {
        private IHttpContextAccessor contextAccessor;

        public Class1(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        public void MetodoSession()
        {
            this.contextAccessor.HttpContext.Session.SetString("KEY", "VALUE");
        }
    }
}
