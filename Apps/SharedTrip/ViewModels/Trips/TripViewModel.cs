﻿using System;
using System.Globalization;

namespace SharedTrip.ViewModels.Trips
{
    public class TripViewModel
    {
        public string Id { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public DateTime DepartureTime { get; set; }

        public string DepartureTimeString => this.DepartureTime.ToString(CultureInfo.GetCultureInfo("bg-BG"));

        public int AvailableSeats { get; set; }
    }
}
