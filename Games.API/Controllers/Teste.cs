using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Games.API.Controllers
{
    public class TesteController : Controller
    {
        //[Authorize]
        //[Authorize(AuthenticationSchemes = HmacAuthenticationDefaults.AuthenticationScheme)]
        //[HttpGet("teste")]
        //public async Task<ActionResult> Index()
        //{
        //    HttpRequestMessage request = new HttpRequestMessage();

        //    var requestContentBase64String = string.Empty;

        //    var appId = "ABCDE123456789";
        //    var apiKey = "ABCDEFG789456123";

        //    var requestUri = WebUtility.UrlEncode(request.RequestUri.AbsoluteUri.ToLower());

        //    var requestHttpMethod = request.Method.Method;

        //    // Calculate UNIX time
        //    var epochStart = new DateTime(1970, 01, 01, 0, 0, 0, 0, DateTimeKind.Utc);
        //    var timeSpan = DateTime.UtcNow - epochStart;
        //    var requestTimeStamp = Convert.ToUInt64(timeSpan.TotalSeconds).ToString();

        //    // create random nonce for each request
        //    var nonce = Guid.NewGuid().ToString("N");

        //    // Checking if the request contains body, usually will be null wiht HTTP GET and DELETE
        //    if (request.Content != null)
        //    {
        //        var content = await request.Content.ReadAsByteArrayAsync();
        //        var md5 = MD5.Create();

        //        // Hashing the request body, any change in request body will result in different hash, we'll incure message integrity
        //        var requestContentHash = md5.ComputeHash(content);
        //        requestContentBase64String = Convert.ToBase64String(requestContentHash);
        //    }

        //    // Creating the raw signature string
        //    var signatureRawData = $"{appId}{requestHttpMethod}{requestUri}{requestTimeStamp}{nonce}{requestContentBase64String}";

        //    var apiKeyBytes = Convert.FromBase64String(apiKey);
        //    var signature = Encoding.UTF8.GetBytes(signatureRawData);

        //    using (var hmac = new HMACSHA256(apiKeyBytes))
        //    {
        //        var signatureBytes = hmac.ComputeHash(signature);
        //        var requestSignatureBase64String = Convert.ToBase64String(signatureBytes);

        //        // Setting the values in the Authorization header using custom scheme (Hmac)
        //        request.Headers.Authorization = new AuthenticationHeaderValue(
        //            "Hmac",
        //            $"{appId}:{requestSignatureBase64String}:{nonce}:{requestTimeStamp}");
        //    }

        //    var response = await SendAsync(request, CancellationToken);

        //    return response;


        //    HttpContext.Request.Headers.Add("x-api-content", "value");
        //    HttpContext.Response.Headers.Add("x-api-content", "value");


        //    return Ok(HttpContext.Request.Headers);
        //}
    }
}
