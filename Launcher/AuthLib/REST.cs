using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Main;
using NetworkTypes;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;

namespace AuthLib
{
	// Token: 0x02000014 RID: 20
	public class REST
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x0000C0FC File Offset: 0x0000A2FC
		public object Company()
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Company", 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				Console.WriteLine("Returned Version from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<company>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000C304 File Offset: 0x0000A504
		public object Themes()
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Themes", 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				Console.WriteLine("Returned Version from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<List<theme>>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000C50C File Offset: 0x0000A70C
		public object Version()
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Version", 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				Console.WriteLine("Returned Version from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<string>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000C714 File Offset: 0x0000A914
		public object OnlineCount()
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "OnlineCount", 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				Console.WriteLine("Returned OnlineCount from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<int>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000C924 File Offset: 0x0000AB24
		public object Update(string Type)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Update", 1, 2),
				new RestParameter("Type", Type, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				Console.WriteLine("Returned Update from Rest API - " + response.Content);
				result = response.RawBytes;
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000CB3C File Offset: 0x0000AD3C
		public object Login(string Username, string Password, string HWID, hwid_info hwid_info)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 5, 2),
				new RestParameter("Request", "Login", 5, 2),
				new RestParameter("Username", HttpUtility.UrlEncode(Username), 5, 2),
				new RestParameter("Password", HttpUtility.UrlEncode(Password), 5, 2),
				new RestParameter("HWID", HttpUtility.UrlEncode(HWID), 5, 2)
			};
			this.RestRequest.AddJsonBody(hwid_info);
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				response.RawBytes = REST.DeCrypt(response.RawBytes);
				response.Content = Encoding.Default.GetString(response.RawBytes);
				Console.WriteLine("Returned Login from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<token>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		public object OAuth_Setup(string Code)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "OAuth", 1, 2),
				new RestParameter("Command", "Setup", 1, 2),
				new RestParameter("Code", Code, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				response.RawBytes = REST.DeCrypt(response.RawBytes);
				response.Content = Encoding.Default.GetString(response.RawBytes);
				Console.WriteLine("Returned AccessToken from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<string>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000D028 File Offset: 0x0000B228
		public object OAuth_Auth(string AccessToken)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "OAuth", 1, 2),
				new RestParameter("Command", "Auth", 1, 2),
				new RestParameter("AccessToken", AccessToken, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				response.RawBytes = REST.DeCrypt(response.RawBytes);
				response.Content = Encoding.Default.GetString(response.RawBytes);
				Console.WriteLine("Returned Token from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<token>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000D288 File Offset: 0x0000B488
		public object Groups(token token)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Groups", 1, 2),
				new RestParameter("Token", token.authtoken, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				response.RawBytes = REST.DeCrypt(response.RawBytes);
				response.Content = Encoding.Default.GetString(response.RawBytes);
				Console.WriteLine("Returned Groups from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<List<group>>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000D4D4 File Offset: 0x0000B6D4
		public object Products(token token)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Products", 1, 2),
				new RestParameter("Token", token.authtoken, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				response.RawBytes = REST.DeCrypt(response.RawBytes);
				response.Content = Encoding.Default.GetString(response.RawBytes);
				Console.WriteLine("Returned Products from Rest API - " + response.Content);
				result = JsonConvert.DeserializeObject<List<product>>(response.Content);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000D720 File Offset: 0x0000B920
		public object Download(string Type, product product, token token)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Download", 1, 2),
				new RestParameter("Type", Type, 1, 2),
				new RestParameter("UID", product.uid.ToString(), 1, 2),
				new RestParameter("Token", token.authtoken, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				Console.WriteLine("Returned Download from Rest API - " + response.Content);
				result = REST.DeCrypt(response.RawBytes);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000D978 File Offset: 0x0000BB78
		public object Authenticate(string token)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Authenticate", 1, 2),
				new RestParameter("Token", token, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				response.RawBytes = REST.DeCrypt(response.RawBytes);
				response.Content = Encoding.Default.GetString(response.RawBytes);
				Console.WriteLine("Returned Authenticate from Rest API - " + response.Content);
				result = new JsonDeserializer().Deserialize<string>(response);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = new JsonDeserializer().Deserialize<error>(response);
			}
			return result;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		public object Log(string Exception, string Log)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Log", 1, 2),
				new RestParameter("Exception", Exception, 1, 2),
				new RestParameter("Log", Log, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				Console.WriteLine("Returned Download from Rest API - " + response.Content);
				result = REST.DeCrypt(response.RawBytes);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
		public object Log(token token, string Exception, string Log)
		{
			this.RestRequest = new RestRequest("", 1);
			Console.WriteLine("------Rest Init Complete------");
			List<RestParameter> Parameters = new List<RestParameter>
			{
				new RestParameter("AppID", Brand.AppID, 1, 2),
				new RestParameter("Request", "Log", 1, 2),
				new RestParameter("Token", token.authtoken, 1, 2),
				new RestParameter("Exception", Exception, 1, 2),
				new RestParameter("Log", Log, 1, 2)
			};
			Dictionary<string, string> UrlSegments = new Dictionary<string, string>();
			Console.WriteLine("------Rest Request Starting------");
			foreach (RestParameter parameter in Parameters)
			{
				this.RestRequest.AddParameter(parameter.Key, parameter.Value, parameter.Type);
			}
			foreach (KeyValuePair<string, string> KeyValuePair in UrlSegments)
			{
				this.RestRequest.AddUrlSegment(KeyValuePair.Key, KeyValuePair.Value);
			}
			this.RestRequest.RootElement = "";
			Console.WriteLine("------Rest Request Execute------");
			IRestResponse response = this.RestClient.Execute(this.RestRequest);
			Console.WriteLine(response.Content);
			Console.WriteLine("------Rest Request Status Check------");
			HttpStatusCode statusCode = response.StatusCode;
			string str = "Rest API returned status code: ";
			int num = (int)statusCode;
			Console.WriteLine(str + num.ToString());
			bool flag = statusCode == HttpStatusCode.OK;
			object result;
			if (flag)
			{
				Console.WriteLine("Returned Download from Rest API - " + response.Content);
				result = REST.DeCrypt(response.RawBytes);
			}
			else
			{
				string str2 = "Exception: ";
				Exception errorException = response.ErrorException;
				Console.WriteLine(str2 + ((errorException != null) ? errorException.ToString() : null));
				Console.WriteLine("Message: " + response.ErrorMessage);
				result = JsonConvert.DeserializeObject<error>(response.Content);
			}
			return result;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000E03C File Offset: 0x0000C23C
		public static byte[] Encrypt(byte[] Bytes)
		{
			List<byte> temp_bytes = new List<byte>();
			int i = 0;
			foreach (byte encrypt in Bytes)
			{
				bool flag = i + 1 < Bytes.Length;
				if (flag)
				{
					temp_bytes.Add(encrypt ^ Bytes[i + 1]);
				}
				else
				{
					temp_bytes.Add(encrypt ^ Bytes[0]);
					temp_bytes.Add(Bytes[i]);
				}
				i++;
			}
			Bytes = temp_bytes.ToArray();
			temp_bytes.Clear();
			return Bytes;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000E0C0 File Offset: 0x0000C2C0
		public static byte[] DeCrypt(byte[] Bytes)
		{
			List<byte> encrypted_bytes = new List<byte>(Bytes);
			List<byte> temp_bytes = new List<byte>();
			byte xor_key = encrypted_bytes.Last<byte>() ^ encrypted_bytes.ElementAt(encrypted_bytes.Count - 2);
			temp_bytes.Add(xor_key);
			for (int i = 0; i < encrypted_bytes.Count - 1; i++)
			{
				bool is_end = i == encrypted_bytes.Count - 2;
				xor_key = (encrypted_bytes.ElementAt(i) ^ xor_key);
				bool flag = !is_end;
				if (flag)
				{
					temp_bytes.Add(xor_key);
				}
			}
			Bytes = temp_bytes.ToArray();
			temp_bytes.Clear();
			return Bytes;
		}

		// Token: 0x0400007D RID: 125
		public RestClient RestClient = new RestClient("https://api.maverickcheats.net/");

		// Token: 0x0400007E RID: 126
		public RestRequest RestRequest;
	}
}
