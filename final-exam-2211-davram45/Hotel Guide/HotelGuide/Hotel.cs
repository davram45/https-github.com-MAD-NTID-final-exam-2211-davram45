using System;
using System.Collections.Generic;
using System.Text;

namespace HotelGuide
{
    class Hotel
    {

        public string HotelName
        {
            get; set;
        }
        public string HotelCity
        {
            get; set;
        }
        public string HotelState
        {
            get; set;
        }
        public double HighlyRate
        {
            get; set;
        }

        public Hotel(string _hotelName, string _hotelcity, string _hotelState, double _highlyRate)
        {
            HotelName = _hotelName;
            HotelCity = _hotelcity;
            HotelState = _hotelState;
            HighlyRate = _highlyRate;
        }
        public override string ToString()
        {
            return ($" Name : {HotelName} \n City: {HotelCity}\n State{HotelState} \n Rate{HighlyRate}");
        }

    }
}





