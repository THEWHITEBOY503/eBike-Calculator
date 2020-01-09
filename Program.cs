using System;
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
        private static double AddedPercent;
        private static double RangeAdded;
        private static double RangePerPercent;
        private static double NewRange;
        private static double RangePerAmp;
        private static double MilesPerHourCharging;
        private static double NewChargerAmps;
        private static double NewChargingTime;
        private static double NewChargingSpeed;
        private static double TripDistance;
        private static double TripChargingTime;
        private static double TripMilesDifference;
        private static double AvgSpeed;
        private static double TimeElapsed1;
        private static double Hours1;
        private static double PricePerkWh;
        private static double ChargingCost;
        private static double FullChargingCost;
        private static double WattHoursRemaining;
        private static double WattHoursUsed;
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
            Console.Write("Enter your home/charging location's $/kWh: ");
            PricePerkWh = Convert.ToDouble(Console.ReadLine());
            ChargingTime = ((Amperage - ((Amperage / 100) * BatteryPercent)) / ChargerAmps);
            PowerUsed = (Amperage - ((Amperage / 100) * BatteryPercent));
            PowerRemaining = ((Amperage / 100) * BatteryPercent);
            RangeRemaining = ((range / 100) * BatteryPercent);
            RangeUsed = (range - ((range / 100) * BatteryPercent));
            MilesPerHourCharging = Math.Round(((range / Amperage) * ChargerAmps), 2);
            WattHoursRemaining = (PowerRemaining * Voltage);
            WattHoursUsed = (PowerUsed * Voltage);
            ChargingCost = Math.Round(((WattHoursUsed / 1000) * PricePerkWh), 3);
            FullChargingCost = Math.Round(((WattHours / 1000) * PricePerkWh), 3);
            Console.Clear();
            Console.WriteLine("Battery Voltage: " + Voltage + "V");
            Console.WriteLine("Battery Amp Hours: " + Amperage + "A");
            Console.WriteLine("Battery Watt Hours: " + WattHours + "Wh");
            Console.WriteLine("Bike Watt Hours/mi: " + WattHoursPerMile + "Wh/Mi");
            Console.WriteLine("Bike Range: " + range + "Mi");
            Console.WriteLine("Remaining Battery: " + BatteryPercent + "%");
            Console.WriteLine("Charger amperage: " + ChargerAmps + "A");
            Console.WriteLine("Time to fully charge: " + ChargingTime + "H (" + (ChargingTime * 60) + "M)");
            Console.WriteLine("Charging at " + MilesPerHourCharging + "MPH");
            Console.WriteLine("Power used: " + PowerUsed + "A");
            Console.WriteLine("Power remaining: " + PowerRemaining + "Ah");
            Console.WriteLine("Est. traveled distance: " + RangeUsed + "Mi");
            Console.WriteLine("Range remaining: " + RangeRemaining + "Mi");
            Console.WriteLine("Cost to charge: $" + ChargingCost);
            Console.WriteLine("Cost to fully charge: $" + FullChargingCost);
            if (BatteryPercent <= 100 && BatteryPercent > 95)
            {
                Console.WriteLine("╔════════════════════╗");
                Console.WriteLine("║████████████████████╚╗");
                Console.WriteLine("║████████████████████ ║");
                Console.WriteLine("║████████████████████╔╝");
                Console.WriteLine("╚════════════════════╝");
            }
            else
            {
                if (BatteryPercent <= 95 && BatteryPercent > 90)
                {
                    Console.WriteLine("╔════════════════════╗");
                    Console.WriteLine("║███████████████████ ╚╗");
                    Console.WriteLine("║███████████████████  ║");
                    Console.WriteLine("║███████████████████ ╔╝");
                    Console.WriteLine("╚════════════════════╝");
                }
                else
                {
                    if (BatteryPercent <= 90 && BatteryPercent > 85)
                    {
                        Console.WriteLine("╔════════════════════╗");
                        Console.WriteLine("║██████████████████  ╚╗");
                        Console.WriteLine("║██████████████████   ║");
                        Console.WriteLine("║██████████████████  ╔╝");
                        Console.WriteLine("╚════════════════════╝");
                    }
                    else
                    {
                        if (BatteryPercent <= 85 && BatteryPercent > 80)
                        {
                            Console.WriteLine("╔════════════════════╗");
                            Console.WriteLine("║█████████████████   ╚╗");
                            Console.WriteLine("║█████████████████    ║");
                            Console.WriteLine("║█████████████████   ╔╝");
                            Console.WriteLine("╚════════════════════╝");
                        }
                        else
                        {
                            if (BatteryPercent <= 80 && BatteryPercent > 75)
                            {
                                Console.WriteLine("╔════════════════════╗");
                                Console.WriteLine("║████████████████    ╚╗");
                                Console.WriteLine("║████████████████     ║");
                                Console.WriteLine("║████████████████    ╔╝");
                                Console.WriteLine("╚════════════════════╝");
                            }
                            else
                            {
                                if (BatteryPercent <= 75 && BatteryPercent > 70)
                                {
                                    Console.WriteLine("╔════════════════════╗");
                                    Console.WriteLine("║███████████████     ╚╗");
                                    Console.WriteLine("║███████████████      ║");
                                    Console.WriteLine("║███████████████     ╔╝");
                                    Console.WriteLine("╚════════════════════╝");
                                }
                                else
                                {


                                    if (BatteryPercent <= 70 && BatteryPercent > 65)
                                    {
                                        Console.WriteLine("╔════════════════════╗");
                                        Console.WriteLine("║██████████████      ╚╗");
                                        Console.WriteLine("║██████████████       ║");
                                        Console.WriteLine("║██████████████      ╔╝");
                                        Console.WriteLine("╚════════════════════╝");
                                    }
                                    else
                                    {
                                        if (BatteryPercent <= 65 && BatteryPercent > 60)
                                        {
                                            Console.WriteLine("╔════════════════════╗");
                                            Console.WriteLine("║█████████████       ╚╗");
                                            Console.WriteLine("║█████████████        ║");
                                            Console.WriteLine("║█████████████       ╔╝");
                                            Console.WriteLine("╚════════════════════╝");
                                        }
                                        else
                                        {
                                            if (BatteryPercent <= 60 && BatteryPercent > 55)
                                            {
                                                Console.WriteLine("╔════════════════════╗");
                                                Console.WriteLine("║████████████        ╚╗");
                                                Console.WriteLine("║████████████         ║");
                                                Console.WriteLine("║████████████        ╔╝");
                                                Console.WriteLine("╚════════════════════╝");
                                            }
                                            else
                                            {
                                                if (BatteryPercent <= 55 && BatteryPercent > 550)
                                                {
                                                    Console.WriteLine("╔════════════════════╗");
                                                    Console.WriteLine("║███████████         ╚╗");
                                                    Console.WriteLine("║███████████          ║");
                                                    Console.WriteLine("║███████████         ╔╝");
                                                    Console.WriteLine("╚════════════════════╝");
                                                }
                                                else
                                                {


                                                    {
                                                        if (BatteryPercent <= 50 && BatteryPercent > 45)
                                                        {
                                                            Console.WriteLine("╔════════════════════╗");
                                                            Console.WriteLine("║██████████          ╚╗");
                                                            Console.WriteLine("║██████████           ║");
                                                            Console.WriteLine("║██████████          ╔╝");
                                                            Console.WriteLine("╚════════════════════╝");
                                                        }
                                                        else
                                                        {
                                                            if (BatteryPercent <= 45 && BatteryPercent > 40)
                                                            {
                                                                Console.WriteLine("╔════════════════════╗");
                                                                Console.WriteLine("║█████████           ╚╗");
                                                                Console.WriteLine("║█████████            ║");
                                                                Console.WriteLine("║█████████           ╔╝");
                                                                Console.WriteLine("╚════════════════════╝");
                                                            }
                                                            else
                                                            {
                                                                if (BatteryPercent <= 40 && BatteryPercent > 35)
                                                                {
                                                                    Console.WriteLine("╔════════════════════╗");
                                                                    Console.WriteLine("║████████            ╚╗");
                                                                    Console.WriteLine("║████████            ║");
                                                                    Console.WriteLine("║████████            ╔╝");
                                                                    Console.WriteLine("╚════════════════════╝");
                                                                }
                                                                else
                                                                {
                                                                    if (BatteryPercent <= 35 && BatteryPercent > 30)
                                                                    {
                                                                        Console.WriteLine("╔════════════════════╗");
                                                                        Console.WriteLine("║███████             ╚╗");
                                                                        Console.WriteLine("║███████              ║");
                                                                        Console.WriteLine("║███████             ╔╝");
                                                                        Console.WriteLine("╚════════════════════╝");
                                                                    }
                                                                    else
                                                                    {
                                                                        if (BatteryPercent <= 30 && BatteryPercent > 25)
                                                                        {
                                                                            Console.WriteLine("╔════════════════════╗");
                                                                            Console.WriteLine("║██████              ╚╗");
                                                                            Console.WriteLine("║██████               ║");
                                                                            Console.WriteLine("║██████              ╔╝");
                                                                            Console.WriteLine("╚════════════════════╝");
                                                                        }
                                                                        else
                                                                        {
                                                                            if (BatteryPercent <= 25 && BatteryPercent > 20)
                                                                            {
                                                                                Console.WriteLine("╔════════════════════╗");
                                                                                Console.WriteLine("║█████               ╚╗");
                                                                                Console.WriteLine("║█████                ║");
                                                                                Console.WriteLine("║█████               ╔╝");
                                                                                Console.WriteLine("╚════════════════════╝");
                                                                            }
                                                                            else
                                                                            {
                                                                                if (BatteryPercent <= 20 && BatteryPercent > 15)
                                                                                {
                                                                                    Console.WriteLine("╔════════════════════╗");
                                                                                    Console.WriteLine("║████                ╚╗");
                                                                                    Console.WriteLine("║████                 ║");
                                                                                    Console.WriteLine("║████                ╔╝");
                                                                                    Console.WriteLine("╚════════════════════╝");
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (BatteryPercent <= 15 && BatteryPercent > 10)
                                                                                    {
                                                                                        Console.WriteLine("╔════════════════════╗");
                                                                                        Console.WriteLine("║███                 ╚╗");
                                                                                        Console.WriteLine("║███                  ║");
                                                                                        Console.WriteLine("║███                 ╔╝");
                                                                                        Console.WriteLine("╚════════════════════╝");
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (BatteryPercent <= 10 && BatteryPercent > 5)
                                                                                        {
                                                                                            Console.WriteLine("╔════════════════════╗");
                                                                                            Console.WriteLine("║██                  ╚╗");
                                                                                            Console.WriteLine("║██                   ║");
                                                                                            Console.WriteLine("║██                  ╔╝");
                                                                                            Console.WriteLine("╚════════════════════╝");
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (BatteryPercent <= 5 && BatteryPercent > 1)
                                                                                            {
                                                                                                Console.WriteLine("╔════════════════════╗");
                                                                                                Console.WriteLine("║█                   ╚╗");
                                                                                                Console.WriteLine("║█                    ║ ");
                                                                                                Console.WriteLine("║█                   ╔╝");
                                                                                                Console.WriteLine("╚════════════════════╝");
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Select an option:");
            Console.WriteLine("1) Recharging calculator");
            Console.WriteLine("2) Compare charging rates");
            Console.WriteLine("3) Trip/Distance planner");
            Console.WriteLine("Hit any other number to exit");
            AfterMenu = Convert.ToDouble(Console.ReadLine());
            if (AfterMenu == 1) 
            {
                Console.Write("How many minutes are you charging for? ");
                ChargingMinutes = Convert.ToDouble(Console.ReadLine());
                GainedPower = ((ChargerAmps / 60) * ChargingMinutes);
                NewPower = (PowerRemaining + GainedPower);
                // This line is for efficiency loss, if you don't wanna include that, remove the line and change all instances of AfterLoss below to NewPower
                AfterLoss = (NewPower * 0.999);
                AmpPerPercent = (Amperage / 100);
                NewPercentage = (AfterLoss / AmpPerPercent);
                AddedPercent = (NewPercentage - (BatteryPercent));
                TimeLeft = ((Amperage - ((Amperage / 100) * NewPercentage)) / ChargerAmps);
                RangePerAmp = (range / Amperage);
                RangeAdded = (RangePerAmp * GainedPower);
                NewRange = (RangePerAmp * NewPower);
                Console.WriteLine("After charging for " + ChargingMinutes + "M:");
                Console.WriteLine(BatteryPercent + "% -> " + NewPercentage + "% (+" + AddedPercent + "%)");
                Console.WriteLine(PowerRemaining + "A -> " + AfterLoss + "A (+" + GainedPower + "A) ");
                Console.WriteLine("Time left to fully charge: " + TimeLeft + "H (" + (TimeLeft * 60) + "M)  (-" + ((ChargingTime*60) - (TimeLeft*60)) + "M)");
                Console.WriteLine("Range: " + NewRange + "Mi (+" + RangeAdded + "Mi)");
                Console.ReadLine();

            }
            if (AfterMenu == 2)
            {
                Console.Write("Enter how many amps the charger you want to compare supplies: ");
                NewChargerAmps = Convert.ToDouble(Console.ReadLine());
                NewChargingTime = ((Amperage - ((Amperage / 100) * BatteryPercent)) / NewChargerAmps);
                NewChargingSpeed = ((range / Amperage) * NewChargerAmps);
                Console.WriteLine("Time to fully charge: " + ChargingTime + "H (" + (ChargingTime * 60) + "M) -> " + NewChargingTime + "H (" + (NewChargingTime * 60) + "M)");
                Console.WriteLine("Time difference: " +  (ChargingTime - NewChargingTime) + "H (" + ((ChargingTime - NewChargingTime)*60) + "M)");
                Console.WriteLine("Charging speed: " + MilesPerHourCharging + "MPH -> " + NewChargingSpeed + "MPH");
                Console.WriteLine("Speed difference: " + (NewChargingSpeed - MilesPerHourCharging + "MPH"));
                Console.ReadLine();
            }
            if (AfterMenu == 3)
            {
                Console.Write("Enter the total distance of your trip (mi): ");
                TripDistance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your average speed (mph): ");
                AvgSpeed = Convert.ToDouble(Console.ReadLine());
                TimeElapsed1 = Math.Round((((range * 2.23) / AvgSpeed)*60), 0);
                while (TimeElapsed1 > 60)
                {
                    Hours1++;
                    TimeElapsed1 = (TimeElapsed1 - 60);
                }
                TripMilesDifference = (TripDistance - RangeRemaining);
                if (TripDistance > RangeRemaining)
                {
                    TripChargingTime = Math.Round((TripMilesDifference / MilesPerHourCharging), 3);
                    Console.WriteLine("Driving time on 1 full charge: " + Hours1 + ":" + TimeElapsed1);
                    Console.WriteLine("You will need to charge for " + TripChargingTime + "H (" + Math.Round((TripChargingTime * 60), 0) + "M) to get to your destination.");
                    Console.WriteLine("Round Trip: " + Math.Round((((TripDistance * 2) - RangeRemaining) / MilesPerHourCharging), 2) + "H (" + Math.Round(((((TripDistance * 2) - RangeRemaining) / MilesPerHourCharging)*60), 0) + "M) charging needed");
                    
                }
                if (TripDistance < RangeRemaining)
                {
                    Console.WriteLine("You should have enough range to get to your destination.");
                    if ((TripDistance*2) > RangeRemaining)
                    {
                        Console.WriteLine("Round Trip: " + Math.Round((((TripDistance * 2) - RangeRemaining) / MilesPerHourCharging), 2) + "H (" + Math.Round(((((TripDistance * 2) - RangeRemaining) / MilesPerHourCharging) * 60), 0) + "M) charging needed");
                    }
                    if ((TripDistance*2) < RangeRemaining)
                    {
                        Console.WriteLine("You should have enough range to get back to make a round trip.");
                    }
                }
                Console.ReadLine();
            }



        }
    }
}
