﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Review
{
    public class Salutation
    {
        private string _Greeting;
        private string _Farewell;

        public Salutation(String greetingMessage, String farewellMessage)
        {
            _Greeting = greetingMessage;
            _Farewell = farewellMessage;
        }
        public string Greet()
        {
            return _Greeting;
        }
        public string SayFarewell()
        {
            return _Farewell;
        }
    }
}
