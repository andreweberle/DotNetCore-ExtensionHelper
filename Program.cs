﻿using System;
using System.Collections.Generic;
using System.Text;
using EbbsSoft.ExtensionHelpers;
using System.Linq;
using EbbsSoft.ExtensionHelpers.T_Helpers;

namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            //EbbsSoft.ExtensionHelper.RemoveProcessedOrders()
            //EbbsSoft.ExtensionHelper.ExtractTextFromPDF("C:\\Users\\andrew.eberle\\Downloads\\imposition_documentation_2018-11-19_1758.pdf");
            
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.TryGetInnerExceptionsErrors().Select(x=> x.Message));
            }
            Console.ReadKey();
        }
    }
}
