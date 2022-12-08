using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WiFi_Antennas.ValidationAttributes
{
    public class IpValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            bool result = false;

            foreach (var item in (byte[])value)
            {
                if (item.GetType() == typeof(byte))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            
            
            return result;
        }
    }
}
