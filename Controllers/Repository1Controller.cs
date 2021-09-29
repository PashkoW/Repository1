using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Repository1.Controllers
{
    [ApiController]
    [Route("/admin")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("/admin/MoneyTake")]
        public string MoneyTake(string str)
        {
            return "принятие оплаты";
        }
        [HttpGet]
        [Route("/admin/SetStatus")]
        public string SetStatus(string str)
        {
            return "установка статуса автомобиля";
        }
        [HttpGet]
        [Route("/admin/LetWatchCam")]
        public string LetWatchCam(string str)
        {
            return "обеспечивает доступ к камерам с производства";
        }
        [HttpGet]
        [Route("/admin/TypeAnswer")]
        public string TypeAnswer(string str)
        {
            return "отвечает на вопросы заказчика";
        }
        [HttpGet]
        [Route("/admin/PostNews")]
        public string PostNews(string str)
        {
            return "Размещение объявления";
        }
    }

    [ApiController]
    [Route("/buyer")]
    public class WeatherForecastController2 : ControllerBase
    {
        [HttpGet]
        [Route("/buyer/CheckReview")]
        public string CheckReview(string str)
        {
            return "просмотр отзывов";
        }
        [HttpGet]
        [Route("/buyer/MakeOrder")]
        public string MakeOrder(string str)
        {
            return "покупатель оставляет заказ на производство автомобиля";
        }
        [HttpGet]
        [Route("/buyer/Pay")]
        public string Pay(string str)
        {
            return "Покупатель оплачивает заказ";
        }
    }
        // ЗАКАЗЧИК
        [ApiController]
        [Route("/client")]
        public class WeatherForecastController3 : ControllerBase
        {
            [HttpGet]
            [Route("/client/TypeQuestion")]
            public string TypeQuestion(string str)
            {
                return "заказчик задает вопрос";
            }
            [HttpGet]
            [Route("/client/TrackCar")]
            public string TrackCar(string str)
            {
                return "просмотр статуса автомобиля";
            }
            [HttpGet]
            [Route("/client/MakeReview")]
            public string MakeReview(string str)
            {
                return "заказчик оставляет отзыв";
            }
            [HttpGet]
            [Route("/client/CheckReviewByClient")]
            public string CheckReviewByClient(string str)
            {
                return "просмотр отзывов";
            }
        }
    }
