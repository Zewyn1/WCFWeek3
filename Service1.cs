using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDani
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public string GetDays(int day,int month,int year)
        {
            ClassLibDani1.SampleFunctions service=new ClassLibDani1.SampleFunctions();
            string days = service.CalculateDays(day, month, year);
            return days;
            //DateTime dt = new DateTime(year, month, day);
            //int daysSince = DateTime.Now.Subtract(dt).Days;
            //return daysSince.ToString();
        }
        public string GetNames(string fname, string lname,string bday)
        {
            ClassLibDani1.SampleFunctions service = new ClassLibDani1.SampleFunctions();
            string fullnames=service.GetFullNames(fname, lname, bday);
            return fullnames;
        }
    }
}
