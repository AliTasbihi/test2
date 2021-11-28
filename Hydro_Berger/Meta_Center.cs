using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydro_Berger
{
    class Meta_Center
    {
        public List<string> Y_ship { get; set; } = new List<string>();
        public List<string> Simpson { get; set; } = new List<string>();
        public double D { get; set; }
        public double S_Ship { get; set; }
        public List<string> I_ship { get; set; } = new List<string>();
        public double Moman_ship { get; set; }
        public double Mete_ceter { get; set; }
        public Meta_Center(string simpson,string y_ship,string d,string i)
 
        {
            Y_ship.AddRange(y_ship.Trim().Split(" "));
            Simpson.AddRange(simpson.Trim().Split(" "));
            I_ship.AddRange(i.Trim().Split(" "));
            D = Convert.ToDouble(d);
            S_Ship = Calculate_S(Y_ship, Simpson, D);
            Moman_ship = Calculate_Moman(Y_ship, Simpson, D,I_ship);
            //به دست اوردن مرکز سطح
            Mete_ceter = Moman_ship / S_Ship;
        }
        //به دست اوردن ممان اول
        private double Calculate_Moman(List<string> y_ship, List<string> simpson, double d,List<string>I_ship)
        {
            double number_section = simpson.Count - 1;
            double d_section = d / number_section;
            double sum_center = 0;
            for (int i = 0; i < simpson.Count; i++)
            {
                sum_center += (1.0 / 3.0) * d_section*( Convert.ToDouble(y_ship[i])*Convert.ToDouble(I_ship[i]) * Convert.ToDouble(simpson[i]));
            }
            return sum_center;
        }
        //به دست اوردن مساحت
        private double Calculate_S(List<string> y_ship, List<string> simpson, double d)
        {
            
            double number_section = simpson.Count - 1;
            double d_section = d / number_section;
            double sum_center = 0;
            for (int i = 0; i <simpson.Count; i++)
            {
                sum_center += (1.0 /3.0) * d_section*( Convert.ToDouble(y_ship[i]) * Convert.ToDouble(simpson[i]));
            }
            return 2* sum_center;
        }
    }
}
