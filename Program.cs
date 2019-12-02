﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBike_calculator
{
    class Program
    {
        private static double Voltage;
        private static double Amperage;
        private static double WattHours;
        private static double range;
        private static double percentage;
        private static double WattHoursPerMile;
        private static double yn1;
        private static double MotorWatts;
        private static double ChargerAmps;
        private static double ChargingTime;
        private static double BatteryPercent;
        private static double PowerUsed;
        private static double PowerRemaining;
        private static double RangeRemaining;
        private static double RangeUsed;
        private static double AfterMenu;
        private static double ChargingMinutes;
        private static double GainedPower;
        private static double NewPower;
        private static double AmpPerPercent;
        private static double NewPercentage;
        private static double AfterLoss;
        private static double TimeLeft;
        static void Main(string[] args)
        {
            Console.Write("Enter your battery voltage ");
            Voltage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your battery Amp Hours ");
            Amperage = Convert.ToDouble(Console.ReadLine());
            WattHours = Voltage * Amperage;
            Console.WriteLine("Battery Watt Hours: " + WattHours);
            Console.Write("Do you know your battery's Wh/Mile rate? (1 for yes, 0 for no) ");
            yn1 = Convert.ToDouble(Console.ReadLine());
            if (yn1 == 1)
            {
                Console.Write("Please enter it ");
                WattHoursPerMile = Convert.ToDouble(Console.ReadLine());
                range = (WattHours / WattHoursPerMile);
            };
            if (yn1 == 0)
            {
                Console.Write("Please enter your range (miles) ");
                range = Convert.ToDouble(Console.ReadLine());
                WattHoursPerMile = (WattHours / range);
                Console.WriteLine("Your Wh/Mi rate is " + WattHoursPerMile);
            };
            Console.Write("Enter your charger's amperage ");
            ChargerAmps = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your battery % remaining ");
            BatteryPercent = Convert.ToDouble(Console.ReadLine());
            ChargingTime = ((Amperage - ((Amperage / 100) * BatteryPercent)) / ChargerAmps);
            PowerUsed = (Amperage - ((Amperage / 100) * BatteryPercent));
            PowerRemaining = ((Amperage / 100) * BatteryPercent);
            RangeRemaining = ((range / 100) * BatteryPercent);
            RangeUsed = (range - ((range / 100) * BatteryPercent));
            Console.Clear();
            Console.WriteLine("Battery Voltage: " + Voltage + "V");
            Console.WriteLine("Battery Amp Hours: " + Amperage + "A");
            Console.WriteLine("Battery Watt Hours: " + WattHours + "Wh");
            Console.WriteLine("Bike Watt Hours/mi: " + WattHoursPerMile + "Wh/Mi");
            Console.WriteLine("Bike Range: " + range + "Mi");
            Console.WriteLine("Remaining Battery: " + BatteryPercent + "%");
            Console.WriteLine("Charger amperage: " + ChargerAmps + "A");
            Console.WriteLine("Time to fully charge: " + ChargingTime + "H (" + (ChargingTime * 60) + "M)");
            Console.WriteLine("Power used: " + PowerUsed + "A");
            Console.WriteLine("Power remaining: " + PowerRemaining + "Ah");
            Console.WriteLine("Est. traveled distance: " + RangeUsed + "Mi");
            Console.WriteLine("Range remaining: " + RangeRemaining + "Mi");
            Console.WriteLine("");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1) Recharging calculator");
            AfterMenu = Convert.ToDouble(Console.ReadLine());
            if (AfterMenu == 1) 
            {
                Console.Write("How many minutes are you charging for? ");
                ChargingMinutes = Convert.ToDouble(Console.ReadLine());
                GainedPower = ((ChargerAmps / 60) * ChargingMinutes);
                NewPower = (PowerRemaining + GainedPower);
                // This line is for efficiency loss, if you don't wanna include that, remove the line and change all instances of AfterLoss below to NewPower
                AfterLoss = (NewPower * 0.95);
                AmpPerPercent = (Amperage / 100);
                NewPercentage = (AfterLoss / AmpPerPercent);
                TimeLeft = ((Amperage - ((Amperage / 100) * NewPercentage)) / ChargerAmps);
                Console.WriteLine("After charging for " + ChargingMinutes + "M:");
                Console.WriteLine(BatteryPercent + "% -> " + NewPercentage + "%");
                Console.WriteLine(PowerRemaining + "A -> " + AfterLoss + "A");
                Console.WriteLine("Time left to fully charge: " + TimeLeft + "H (" + (TimeLeft * 60) + "M)");
                Console.ReadLine();

            }



        }
    }
}
