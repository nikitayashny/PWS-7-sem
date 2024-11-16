using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using System.Text;

namespace PWS_Lab3.Controllers
{
    [RoutePrefix("api/error")]
    public class ErrorController : ApiController
    {
        [Route("{code:int}/{id:int}.{format}")]
        [HttpGet]
        public IHttpActionResult Error(int code, int id, string format)
        {
            string message = string.Empty;

            switch (id)
            {
                default:
                case 1:
                    message = $"Ошибка {code}/{id}. Записи с заданным вами идентификатором не существует. Введите корректный идентификатор.";
                    break;
                case 2:
                    message = $"Ошибка {code}/{id}. Неподдерживаемый формат данных. Поддерживаемые форматы: JSON и XML.";
                    break;
                case 3:
                    message = $"Ошибка {code}/{id}. Вы пытаетесь добавить запись, но введенные вами данные не прошли проверку на корректность. Убедитесь в корректности вводимых значений и попробуйте снова.";
                    break;
                case 4:
                    message = $"Ошибка {code}/{id}. Поля limit, offset, minId, и maxId должны быть положительными числами.";
                    break;
                case 5:
                    message = $"Ошибка {code}/{id}. minId должен быть меньше maxId.";
                    break;
            }

            if (format.ToLower() == "json")
            {
                return Content(HttpStatusCode.OK, new { error = message });
            }
            else if (format.ToLower() == "xml")
            {
                var xmlResponse = new XElement("error",
                    new XAttribute("code", code),
                    new XAttribute("id", id),
                    new XElement("message", message)
                );

                var xmlString = xmlResponse.ToString(SaveOptions.DisableFormatting);
                var content = new StringContent(xmlString, Encoding.UTF8, "application/xml");

                return ResponseMessage(new HttpResponseMessage(HttpStatusCode.OK) { Content = content });
            }
            else
            {
                return Content(HttpStatusCode.UnsupportedMediaType, new { error = "Unsupported format. Please use json or xml." });
            }
        }
    }
}

/*using System;
using System.Web.Http;

namespace PWS_Lab3.Controllers
{
    [RoutePrefix("api/error")]
    public class ErrorController : ApiController
    {
        [Route("{code:int}/{id:int}")]
        [HttpGet]
        public IHttpActionResult Error(int code, int id)
        {
            switch (id)
            {
                default:
                case 1:
                    {
                        return Ok($"Ошибка {code}/{id}. Записи с заданным вами идентификатором не существует. Введите корректный идентификатор");
                    }
                case 2:
                    {
                        return Ok($"Ошибка {code}/{id}. Неподдерживаемый формат данных. Поддерживаемые форматы: JSON и XML.");
                    }
                case 3:
                    {
                        return Ok($"Ошибка {code}/{id}. Вы пытаетесь добавить запись, но введенные вами данные не прошли проверку на корректность. Убедитесь в корректности вводимых значений и попробуйте снова.");
                    }
                case 4:
                    {
                        return Ok($"Ошибка {code}/{id}. Поля limit, offset, minId, и maxId должны быть положительными числами.");
                    }
                case 5:
                    {
                        return Ok($"Ошибка {code}/{id}. minId должен быть меньше maxId.");
                    }
            }
        }
    }
}*/