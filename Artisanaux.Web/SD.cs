﻿namespace Artisanaux.Web
{
    //Static Domain
    public static class SD
    {
        public static string ProductAPIBase { get; set; }
        public enum APIType { 
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
