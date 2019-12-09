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
Time to fully charge: 1.89H (113.4M)
Charging at 3.80952380952381MPH
Power used: 3.78A
Power remaining: 6.72Ah
Est. traveled distance: 7.2Mi
Range remaining: 12.8Mi

Select an option:
1) Recharging calculator
2) Compare charging rates

```


### Recharging calculator

Calculate your range, battery % and remaining charging time after X minutes of charging

Input:
```
How many minutes are you charging for? 30
```

Output:
```
After charging for 30M:
64% -> 73.4502857142857% (+9.45028571428571%)
6.72A -> 7.71228A (+1A)
Time left to fully charge: 1.39386H (83.6316M)  (-29.7684M)
Range: 14.7047619047619Mi (+1.9047619047619Mi)
```

### Charger comparison
Compare charging speeds with different charger amperages

Input:
```
Enter how many amps the charger you want to compare supplies: 5
```

Output:
```
Time to fully charge: 1.89H (113.4M) -> 0.756H (45.36M)
Time difference: 1.134H (68.04M)
Charging speed: 3.80952380952381MPH -> 9.52380952380952MPH
Speed difference: 5.71428571428571MPH
```
