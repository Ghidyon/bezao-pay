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

        public CustomException(string name)
            : base($"Invalid {nameof(name)}: {name}")
        {

        }

        public CustomException(int id)
            : base($"Invalid {nameof(id)}: {id}")
        {

        }
    }
}
