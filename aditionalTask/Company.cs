using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aditionalTask
{
    class Company
    {
        public static bool EnterForLowAccessSection(Employee emp)
        {
            if (emp != null)
            {
                return true;
            }
            return false;
        }
        public static bool EnterForAverageAccessSection(Employee emp)
        {
            if (EnterForLowAccessSection(emp))
            {
                Type type = emp.GetType();
                object[] attributes = type.GetCustomAttributes(typeof(AccessLevelAttribute), false);

                if (attributes.Length == 1)
                {
                    AccessLevelAttribute attribute = attributes[0] as AccessLevelAttribute;
                    if (attribute != null)
                    {
                        if (attribute.Access == AccessLevel.average || attribute.Access == AccessLevel.high)
                            return true;
                    }
                }
            }
            return false;
        }
        public static bool EnterForHighAccessSection(Employee emp)
        {
            if (EnterForLowAccessSection(emp))
            {
                Type type = emp.GetType();
                object[] attributes = type.GetCustomAttributes(typeof(AccessLevelAttribute), false);

                if (attributes.Length == 1)
                {
                    AccessLevelAttribute attribute = attributes[0] as AccessLevelAttribute;
                    if (attribute != null)
                    {
                        if (attribute.Access == AccessLevel.high)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
