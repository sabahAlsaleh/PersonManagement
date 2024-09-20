using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonManagement.Polymorfism
{
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {

            string message = "You tried to use a numeric input in a text only field.This fired an error!";
            return message;

        }


    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {


            string message = "You tried to use a text input in a numeric only field. This fired an error!";
            return message;

        }
    }


    public class FileNotFoundError : UserError
    {
        public override string UEMessage()
        {
            return "The file you are trying to access does not exist. This fired an error!";
        }
    }

    public class PermissionDeniedError : UserError
    {
        public override string UEMessage()
        {
            return "You do not have permission to access this resource. This fired an error!";
        }
    }

    public class InvalidLoginError : UserError
    {
        public override string UEMessage()
        {
            return "Invalid login credentials provided. This fired an error!";
        }
    }






}



