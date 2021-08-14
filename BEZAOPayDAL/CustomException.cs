using System;
using System.Collections.Generic;
using System.Text;

namespace BEZAOPayDAL
{
    public class CustomException : Exception
    {
        public CustomException()
        {

        }

        public CustomException(string input)
            : base($"Invalid Id: {input}")
        {

        }
    }
}
