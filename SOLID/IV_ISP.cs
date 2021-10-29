using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    //interface IFormatter
    //{
    //    void ToExcel();
    //    void ToPdf();
    //}
    interface IExcelFormatter
    {
        void ToExcel();
    }
    interface IPdfFormatter
    {
        void ToPdf();
    }

    class Report : IExcelFormatter, IPdfFormatter //IFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IPdfFormatter //IFormatter
    {
        //public void ToExcel()
        //{
        //    throw new NotImplementedException();
        //}

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }
}
