def metric_bmi(height, weight):
    return weight / pow(height, 2)


def imperial_bmi(height, weight):
    return (weight * 703) / pow(height, 2)


# Prompt the user to choose the measurement system
choice = input("Metric or Imperial units? Type 1 for Metric, 2 for Imperial: ")

bmi = None
if choice == "1":
    height = float(input("Please input height in cm: ")) / 100  # Convert cm to meters
    weight = float(input("Please input weight in kg: "))
    bmi = metric_bmi(height, weight)
elif choice == "2":
    height = float(input("Please input height in inches: "))
    weight = float(input("Please input weight in lbs: "))
    bmi = imperial_bmi(height, weight)
else:
    print("Invalid input.")
    exit()

# Display the BMI value
print(f"Your BMI is {bmi:.2f}")

# Determine the BMI category
if bmi < 18.5:
    print("You are underweight!")
elif 18.5 <= bmi <= 24.9:
    print("Good weight!")
elif 25.0 <= bmi <= 39.9:
    print("You are overweight!")
elif bmi > 39.9:
    print("You are obese!")
