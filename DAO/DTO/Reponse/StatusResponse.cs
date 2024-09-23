﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Reponse
{
    public class StatusResponse<T>
    {
        public T Data { get; set; }
        public HttpStatusCode statusCode { get; set; }
        public string Message { get; set; }
        public object? bonusData { get; set; }
    }
}