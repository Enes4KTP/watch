
namespace watchWebSite.Utilities
{
	public static class SessionHelper
	{

		public static void SetUserSession(HttpContext httpContext, string userEmail)
		{
			httpContext.Session.SetString("UserEmail", userEmail);
		}

		public static string GetUserSession(HttpContext httpContext)
		{
			return httpContext.Session.GetString("UserEmail");
		}

	}
}
