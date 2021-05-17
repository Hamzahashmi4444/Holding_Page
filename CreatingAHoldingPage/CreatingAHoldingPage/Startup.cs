using Microsoft.AspNetCore.Builder;

namespace CreatingAHoldingPage
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseWelcomePage();
            app.UseWelcomePage();
            app.UseAuthentication();


        }
     
    }
}
