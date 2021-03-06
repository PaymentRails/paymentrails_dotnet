﻿using System;
using System.Runtime.Serialization;

namespace PaymentRails.Exceptions
{
    public class InvalidCredentialsException : ArgumentException
    {
        /// <summary>

        /// Default constructor

        /// </summary>

        public InvalidCredentialsException() : base()

        {

        }


        public InvalidCredentialsException(string message) : base(message)

        {

        }


        public InvalidCredentialsException(string message, Exception innerException) : base(message, innerException)

        {

        }



        protected InvalidCredentialsException(SerializationInfo info, StreamingContext context) : base(info, context)

        {

        }
    }
}


