﻿using System;

namespace EncoreTickets.SDK.Utilities
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// Return in encore string format
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToEncoreDate(this DateTime dt)
        {
            return dt.ToString("yyyyMMdd");
        }

        /// <summary>
        /// Return the time
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToEncoreTime(this DateTime dt)
        {
            return dt.ToString("HHmm");
        }
    }
}