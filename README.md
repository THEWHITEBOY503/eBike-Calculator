# eBike-Calculator
A simple C# Console app for calculating range and charging time for an electric bike (or other BEV)

Here is the information you will need to know about your bike and battery:
- Battery Voltage
- Battery Amp Hours
- Wh/Mi rate (if you don't know this but you do know the range it's ok, the program will find the Wh/Mi rate for you)
- The battery charge level in % (0-100)
- How many amps your charger outputs

And the software will output some helpful information!

## Example use: 

Input: 
```
Enter your battery voltage 36
Enter your battery Amp Hours 10.5
Calculated battery Watt Hours: 378
Do you know your battery's Wh/Mile rate? (1 for yes, 0 for no) 0
Please enter your range (miles) 20
Your Wh/Mi rate is 18.9
Enter your charger's amperage 2
Enter your battery % remaining 64
```

Output: 
```
Battery Voltage: 36V
Battery Amp Hours: 10.5A
Battery Watt Hours: 378Wh
Bike Watt Hours/mi: 18.9Wh/Mi
Bike Range: 20Mi
Remaining Battery: 64%
Charger amperage: 2A
Time to fully charge: 3.78H
Power used: 3.78A
Power remaining: 6.72Ah
Est. traveled distance: 7.2Mi
Range remaining: 12.8Mi
```
