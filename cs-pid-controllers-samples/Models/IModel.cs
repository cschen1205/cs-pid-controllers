using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIDControllers.Models
{
    public interface IModel
    {
        double getValue(double x);
        double MaxOutput
        {
            get; 
        }

        double MinOutput
        {
            get;
        }

        
    }
}
