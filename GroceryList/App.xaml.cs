using Microsoft.IdentityModel.JsonWebTokens;

namespace GroceryList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var Configuration = new Org.OpenAPITools.Client.Configuration();
            Configuration.UserAgent = "PAKnSAVEApp/4.26.2 (Arefu)";

            State.UsersApi = new Org.OpenAPITools.Api.UsersApi(Configuration);
            var Token = State.UsersApi.GetRefreshToken(new Org.OpenAPITools.Model.GetRefreshTokenRequest(Org.OpenAPITools.Model.GetRefreshTokenRequest.RefreshTokenEnum.Bf37fdc9638846afB7f12b09a0766608));

            State._RefreshToken = Guid.Parse(Token.RefreshToken);
            State._AccessToken = new JsonWebToken(Token.AccessToken);

            Configuration = new Org.OpenAPITools.Client.Configuration()
            {
                AccessToken = Token.AccessToken,
            };

            State.ShopApi = new Org.OpenAPITools.Api.ShopApi(Configuration);
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}