using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AgtechEConnect
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			var jsonFormatterSettings = config.Formatters.JsonFormatter.SerializerSettings;
			jsonFormatterSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
			jsonFormatterSettings.Formatting = Formatting.Indented;

			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
